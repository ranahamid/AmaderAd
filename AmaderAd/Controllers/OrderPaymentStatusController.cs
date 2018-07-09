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

namespace AmaderAd.Controllers
{
    [Authorize(Roles = "Admin")]
    [ExceptionHandler]
    public class OrderPaymentStatusController : BaseController
    {

        public OrderPaymentStatusController()
        {
            //api url                  
            url = baseUrl + "api/OrderPaymentStatusApi";
        }
        
        // GET: OrderPaymentStatuss
        public async Task<ActionResult> Index()
        {
            var responseMessage = await client.GetAsync(url);
            if (!responseMessage.IsSuccessStatusCode) throw new Exception("Exception");
            var responseData = responseMessage.Content.ReadAsStringAsync().Result;
            var entity = JsonConvert.DeserializeObject<List<OrderPaymentStatus>>(responseData);
            return View(entity);
        }

        // GET: OrderPaymentStatuss/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            var responseMessage = await client.GetAsync(url + "/" + id);
            if (!responseMessage.IsSuccessStatusCode) throw new Exception("Exception");
            var responseData = responseMessage.Content.ReadAsStringAsync().Result;
            var entity = JsonConvert.DeserializeObject<OrderPaymentStatus>(responseData);
            return View(entity);
        }

        // GET: OrderPaymentStatuss/Create
        public ActionResult Create()
        {
            var entity = new OrderPaymentStatus();
            return View(entity);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderPaymentStatus entity)
        {
            if (!ModelState.IsValid) return View(entity);
            Db.OrderPaymentStatusTbls.InsertOnSubmit(new OrderPaymentStatusTbl
            {
                //   Id              = entity.Id,           
                Name = entity.Name,
                DefaultStatus = entity.DefaultStatus,

            });
            try
            {
                Db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw new Exception("Exception");
            }
            //var responseMessage = await client.PostAsJsonAsync(url, entity);
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    return RedirectToAction("Index");
            //}

            //return View(entity);
        }

        // GET: OrderPaymentStatuss/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            var responseMessage = await client.GetAsync(url + "/" + id);
            if (!responseMessage.IsSuccessStatusCode) throw new Exception("Exception");
            var responseData = responseMessage.Content.ReadAsStringAsync().Result;
            var entity = JsonConvert.DeserializeObject<OrderPaymentStatus>(responseData);
            return View(entity);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OrderPaymentStatus entity)
        {
            if (!ModelState.IsValid) return View(entity);

            var isEntity = from x in Db.OrderPaymentStatusTbls
                           where x.Id == entity.Id
                           select x;

            if (isEntity == null)
            {
                return View(entity);
            }

            if (isEntity != null)
            {
                OrderPaymentStatusTbl entitySingle = isEntity.Single();

                entitySingle.Name = entity.Name;
                entitySingle.DefaultStatus = entity.DefaultStatus;
            }

            try
            {
                Db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw new Exception("Exception");
            }

            //var responseMessage = await client.PutAsJsonAsync(url + "/" + id, entity);
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    return RedirectToAction("Index");
            //}
            //return View(entity);
        }



        // GET: OrderPaymentStatuss/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            var responseMessage = await client.GetAsync(url + "/" + id);
            if (!responseMessage.IsSuccessStatusCode) throw new Exception("Exception");
            var responseData = responseMessage.Content.ReadAsStringAsync().Result;
            var entity = JsonConvert.DeserializeObject<OrderPaymentStatus>(responseData);
            return View(entity);
        }

        // POST: OrderPaymentStatuss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var query = from x in Db.OrderPaymentStatusTbls
                        where x.Id == id
                        select x;

            if (query != null && query.Count() == 1)
            {
                OrderPaymentStatusTbl entity = query.SingleOrDefault();
                Db.OrderPaymentStatusTbls.DeleteOnSubmit(entity);
            }

            try
            {
                Db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw new Exception("Exception");
            }
            //var responseMessage = await client.DeleteAsync(url + "/" + id);
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    return RedirectToAction("Index");
            //}
            //throw new Exception("Exception");
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
