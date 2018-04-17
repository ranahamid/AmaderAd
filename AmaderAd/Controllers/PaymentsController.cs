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
    public class PaymentsController : BaseController
    {
        private readonly FilesHelper _filesHelper;
        readonly string tempPath = "~/payments/";
        readonly string serverMapPath = "~/Content/images/payments/";
        private readonly string UrlBase = "/Content/images/payments/"; //with out '/'
        readonly string DeleteURL = "/Payments/DeleteAdditionalFile/?file=";
        private string StorageRoot => Path.Combine(HostingEnvironment.MapPath(serverMapPath));
        string DeleteType = "GET";

        public PaymentsController()
        {
            int randN = GetRandomNumber();
            _filesHelper = new FilesHelper(DeleteURL, DeleteType, StorageRoot + randN + "/", UrlBase + randN + "/", tempPath + randN + "/", serverMapPath + randN + "/");
            //api url                  
            url = baseUrl + "api/PaymentApi";
        }

        // GET: Payments


        public async Task<List<OrderPaymentMethod>> GetPaymentMethods()
        {
            url = baseUrl + "api/OrderPaymentMethodApi";
            var responseMessage = await client.GetAsync(url);
            if (!responseMessage.IsSuccessStatusCode) throw new Exception("Exception");
            var responseData = responseMessage.Content.ReadAsStringAsync().Result;
            var entityOrderPayment = JsonConvert.DeserializeObject<List<OrderPaymentMethod>>(responseData);
            return entityOrderPayment;
        }

        public async Task<ActionResult> Index(Newspaper entity)
        {
            entity.Id = Db.NewspaperTbls.Where(x => x.NewsGuidId == entity.NewsGuidId).Select(x => x.Id).FirstOrDefault();

            var entityOrderPayment = await GetPaymentMethods();

            Payment payment = new Payment();
            payment.PaymentMethods = entityOrderPayment;
            //payment.Newspaper = entity;
            payment.Id = entity.Id;
            payment.NewsGuidId = entity.NewsGuidId;
            payment.NewspaperName = entity.NewspaperName;
            payment.AdLocation = entity.AdLocation;
            payment.Price = entity.Price;
            payment.AdvertiserName = entity.AdvertiserName;
            payment.AdvertiserAddress = entity.AdvertiserAddress;
            payment.AdvertiserMobile = entity.AdvertiserMobile;
            payment.AdvertiserEmail = entity.AdvertiserEmail;
            payment.DateofPublication = entity.DateofPublication;
            payment.ColumnSize = entity.ColumnSize;
            payment.Inch = entity.Inch;
            payment.TotalColumnInch = entity.TotalColumnInch;
            payment.TotalPrice = entity.TotalPrice;
            payment.Description = entity.Description;
            payment.AllAdCategoryId = entity.AllAdCategoryId;
            payment.MainImagePath = HttpUtility.UrlPathEncode(baseUrl + entity.MainImagePath);
            payment.RawDbImagePath = entity.MainImagePath;
            payment.CreatedOnUtc = entity.CreatedOnUtc;
            payment.UpdatedOnUtc = entity.UpdatedOnUtc;
            payment.Active = entity.Active;

            //end of payment.Newspaper = entity;

            return View(payment);
        }

        [AllowAnonymous]
        // POST: Payments
        [ValidateInput(false)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(Payment entity)
        {
            // Home is default controller
            var controller = string.Empty;
            var action = string.Empty;

            if (Request.UrlReferrer != null)
            {
                controller = (Request.UrlReferrer.Segments.Skip(1).Take(1).SingleOrDefault() ?? "Home").Trim('/');
            }

            // Index is default action 
            if (Request.UrlReferrer != null)
            {
                action = (Request.UrlReferrer.Segments.Skip(2).Take(1).SingleOrDefault() ?? "Index").Trim('/');
            }

            if (ModelState.IsValid)
            {
                entity.PaymentGuidId = Guid.NewGuid();
                //

                //end 
                var responseMessage = await client.PostAsJsonAsync(url, entity);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Success", "Payments", entity);
                }
            }
            return RedirectToAction(action, controller, entity);
        }

        public ActionResult Success()
        {
            return View();
        }

        // GET: Products
        public async Task<ActionResult> List()
        {
            var responseMessage = await client.GetAsync(url);
            if (!responseMessage.IsSuccessStatusCode) throw new Exception("Exception");
            var responseData = responseMessage.Content.ReadAsStringAsync().Result;
            var entity = JsonConvert.DeserializeObject<List<Payment>>(responseData);
            return View(entity);
        }

        // GET: Products/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            var entity = await GetPayment(id);
            return View(entity);
        }

        // GET: Products/Details/5
        public async Task<ActionResult> Invoice(int? id)
        {
            var entity = await GetPayment(id);
            return View(entity);
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

        public async Task<Payment> GetPayment(int? id)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/" + id);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception("Exception");

            var responseData = responseMessage.Content.ReadAsStringAsync().Result;

            var entity = JsonConvert.DeserializeObject<Payment>(responseData);
            return entity;
        }

        // GET: Products/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            var entity = await GetPayment(id);
            var entityOrderPayment = await GetPaymentMethods();
            entity.AllAdCategory = GetAllAdCategory();
            entity.PaymentMethods = entityOrderPayment;
            return View(entity);
        }

        // POST: Products/Edit/5
        [ValidateInput(false)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Payment entity)
        {
            if (ModelState.IsValid)
            {
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
            var entity = await GetPayment(id);
            return View(entity);
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