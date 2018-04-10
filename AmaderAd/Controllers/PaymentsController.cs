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
    public class PaymentsController : BaseController
    {
        public PaymentsController()
        {
            //api url                  
         
        }

        // GET: Payments
    
        public async Task<ActionResult> Index(Newspaper entity)
        {
            entity.Id = Db.NewspaperTbls.Where(x => x.NewsGuidId == entity.NewsGuidId).Select(x => x.Id).FirstOrDefault();
            

            url = baseUrl + "api/OrderPaymentMethodApi";
            var responseMessage = await client.GetAsync(url);
            if (!responseMessage.IsSuccessStatusCode) throw new Exception("Exception");
            var responseData = responseMessage.Content.ReadAsStringAsync().Result;
            var entityOrderPayment = JsonConvert.DeserializeObject<List<OrderPaymentMethod>>(responseData);

            Payment payment = new Payment();
            payment.PaymentMethods = entityOrderPayment;
            payment.Newspaper = entity;

            return View(payment);
        }

        [HttpPost]
        public ActionResult Index(Payment entity)
        {
            return View();
        }


    }
}