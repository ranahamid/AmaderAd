using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using AmaderAd.DAL;
using System.Configuration;
using AmaderAd.Filters;
using AmaderAd.Helpers;
using System.IO;
using System.Web.Hosting;


namespace AmaderAd.Controllers
{
    [ExceptionHandler]
    [Authorize(Roles = "Admin")]
    public class NewspapersController : BaseController
    {
        private readonly FilesHelper _filesHelper;
        readonly string tempPath = "~/newspapersfile/";
        readonly string serverMapPath = "~/Content/images/newspapersfile/";
        private readonly string UrlBase = "/Content/images/newspapersfile/"; //with out '/'
        readonly string DeleteURL = "/newspapers/DeleteAdditionalFile/?file=";
        private string StorageRoot => Path.Combine(HostingEnvironment.MapPath(serverMapPath));
        string DeleteType = "GET";

        public string[] ValidImageTypes = new string[]
        {
            "image/gif",
            "image/jpeg",
            "image/pjpeg",
            "image/png",
            "application/pdf",
        };

        public NewspapersController()
        {
            int randN = GetRandomNumber();
            _filesHelper = new FilesHelper(DeleteURL, DeleteType, StorageRoot + randN + "/", UrlBase + randN + "/", tempPath + randN + "/", serverMapPath + randN + "/");
            //api url                  
            url = baseUrl + "api/NewspaperApi";
        }



        // GET: Products
        public async Task<ActionResult> Index()
        {
            var responseMessage = await client.GetAsync(url);
            if (!responseMessage.IsSuccessStatusCode) throw new Exception("Exception");
            var responseData = responseMessage.Content.ReadAsStringAsync().Result;
            var entity = JsonConvert.DeserializeObject<List<Newspaper>>(responseData);
            return View(entity);
        }

        // GET: Products/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            var responseMessage = await client.GetAsync(url + "/" + id);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception("Exception");
            var responseData = responseMessage.Content.ReadAsStringAsync().Result;

            var entity = JsonConvert.DeserializeObject<Newspaper>(responseData);          
            return View(entity);
        }


  
        // GET: Products/Create
        public ActionResult Create()
        {
            var entity = new Newspaper
            {
                AllAdCategory = GetAllAdCategory(),
            };
            return View(entity);
        }

        [AllowAnonymous]
        // POST: Products/Create
        [ValidateInput(false)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Newspaper entity)
        {            
            // Home is default controller
            string controller = string.Empty;
            string action = string.Empty;

            if (Request.UrlReferrer != null)
            {
                 controller = (Request.UrlReferrer.Segments.Skip(1).Take(1).SingleOrDefault() ?? "Home").Trim('/');
            }

            // Index is default action 
            if (Request.UrlReferrer != null)
            {
                 action = (Request.UrlReferrer.Segments.Skip(2).Take(1).SingleOrDefault() ?? "Index").Trim('/');
            }
            //start method
       
            if (entity.MainImagePath == null || entity.MainImagePath.ContentLength == 0)
            {
                ModelState.AddModelError("ImageUpload", "This field is required");
            }
            else if (!ValidImageTypes.Contains(entity.MainImagePath.ContentType))
            {
                ModelState.AddModelError("ImageUpload", "Please choose either a GIF, JPG or PNG image.");
            }


            if (ModelState.IsValid)
            {
                //test
                //end of test
                entity.RawDbImagePath= UploadFile(entity);
                entity.NewsGuidId=Guid.NewGuid();
                entity.MainImagePath = null;
                var responseMessage = await client.PostAsJsonAsync(url, entity);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("DoPayment", "Payments", entity);
                }
            }
            return RedirectToAction(action, controller, entity);          
        }

   



        [HttpPost]
        public JsonResult Upload()
        {
            var resultList = new List<ViewDataUploadFilesResult>();

            var currentContext = HttpContext;
            _filesHelper.UploadAndShowResults(currentContext, resultList);
            JsonFiles files = new JsonFiles(resultList);

            bool isEmpty = !resultList.Any();
            if (isEmpty)
            {
                return Json("Error ");
            }

            return Json(files);
        }

     
        [HttpGet]
        public JsonResult DeleteFile(string file)
        {
            _filesHelper.DeleteFile(file);
            return Json("OK", JsonRequestBehavior.AllowGet);
        }



        // GET: Products/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var entity = JsonConvert.DeserializeObject<Newspaper>(responseData);
                entity.AllAdCategory = GetAllAdCategory();
                return View(entity);
            }
            throw new Exception("Exception");
        }

        // POST: Products/Edit/5
        [ValidateInput(false)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Newspaper entity)
        {
            if (entity.MainImagePath == null || entity.MainImagePath.ContentLength == 0)
            {
                ModelState.AddModelError("ImageUpload", "This field is required");
            }
            else if (!ValidImageTypes.Contains(entity.MainImagePath.ContentType))
            {
                ModelState.AddModelError("ImageUpload", "Please choose either a GIF, JPG or PNG image.");
            }
            if (ModelState.IsValid)
            {
                entity.RawDbImagePath = UploadFile(entity);
                entity.MainImagePath = null;

                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(url + "/" + id, entity);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            
            return View(entity);
        }

        // GET: Products/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var entity = JsonConvert.DeserializeObject<Newspaper>(responseData);
                if (entity != null)
                {                    
                    return View(entity);
                }
            }
            throw new Exception("Exception");
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {

            HttpResponseMessage responseMessage = await client.DeleteAsync(url + "/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            throw new Exception("Exception");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
