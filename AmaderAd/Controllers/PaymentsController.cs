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


        public async Task<List<System.Web.Mvc.SelectListItem>> GetPaymentMethods()
        {
            url = baseUrl + "api/OrderPaymentMethodApi/GetAllOrderPaymentMethodSelectList/";
            var responseMessage = await client.GetAsync(url);
            if (!responseMessage.IsSuccessStatusCode) throw new Exception("Exception");
            var responseData = responseMessage.Content.ReadAsStringAsync().Result;
            var entityOrderPayment = JsonConvert.DeserializeObject<List<System.Web.Mvc.SelectListItem>>(responseData);
            return entityOrderPayment;
        }
        public async Task<List<System.Web.Mvc.SelectListItem>> GetPaymentMethodsByMethodId(string paymentChannel)
        {
            var list= await GetPaymentMethods();
            List<System.Web.Mvc.SelectListItem> entities = new List<System.Web.Mvc.SelectListItem>();
            foreach (var item in list)
            {
                entities.Add(new SelectListItem()
                {
                    Value = item.Value,
                    Text = item.Text,
                    Selected = (item.Value == paymentChannel) ? true : false
                });
            }
            return entities;
        }
        
        public async Task<ActionResult> Index(Newspaper entity)
        {
            entity.Id = Db.NewspaperTbls.Where(x => x.NewsGuidId == entity.NewsGuidId).Select(x => x.Id).FirstOrDefault();
            var entityOrderPayment = await GetPaymentMethods();

            Payment payment = new Payment
            {
                PaymentMethods = entityOrderPayment,
                OrderId = entity.Id,

                CreatedOnUtc = entity.CreatedOnUtc,
                UpdatedOnUtc = entity.UpdatedOnUtc,
                Active = entity.Active,
                NewspaperCls =
                {
                    NewsGuidId = entity.NewsGuidId,
                    NewspaperName = entity.NewspaperName,
                    AdLocation = entity.AdLocation,
                    Price = entity.Price,
                    AdvertiserName = entity.AdvertiserName,
                    AdvertiserAddress = entity.AdvertiserAddress,
                    AdvertiserMobile = entity.AdvertiserMobile,
                    AdvertiserEmail = entity.AdvertiserEmail,
                    DateofPublication = entity.DateofPublication,
                    ColumnSize = entity.ColumnSize,
                    Inch = entity.Inch,
                    TotalColumnInch = entity.TotalColumnInch,
                    TotalPrice = entity.TotalPrice,
                    Description = entity.Description,
                    AdCategoryId = entity.AdCategoryId,
                    MainImagePath = entity.MainImagePath
                }
            };


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
            entity.NewspaperCls =await GetNewsPaperData(entity.OrderId);
         
            return View(entity);
        }

     
        // GET: Products/Details/5
        public async Task<ActionResult> Invoice(int? id)
        {
            var entity = await GetPayment(id);
            entity.NewspaperCls = await GetNewsPaperData(entity.OrderId);
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
            url = baseUrl + "api/PaymentApi";
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
                      
            entity.PaymentMethods = await GetPaymentMethodsByMethodId(entity.PaymentChannel);
            entity.NewspaperCls = await GetNewsPaperData(entity.OrderId);
            
            entity.NewspaperCls.AllAdCategory = GetAllAdCategoryBySelect(entity.NewspaperCls.AdCategoryId);
   
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
        
            var entityOrderPayment = await GetPaymentMethods();
            entity.PaymentMethods = entityOrderPayment;
            entity.NewspaperCls = await GetNewsPaperData(entity.OrderId);
            entity.NewspaperCls.AllAdCategory = GetAllAdCategory();
           
            return View(entity);
        }

        // GET: Products/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            var entity = await GetPayment(id);
            entity.NewspaperCls = await GetNewsPaperData(entity.OrderId);
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