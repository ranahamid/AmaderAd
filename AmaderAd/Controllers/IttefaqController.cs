using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class IttefaqController : BaseController
    {
        // GET: Ittefaq
        public ActionResult Index()
        {
            return View();
        }

        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        public ActionResult FirstPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq First Page Color",
                PriceDescription = 14000
            };
            return View(model);
        }

        public ActionResult LastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Last Page Color",
                PriceDescription = 12000
            };
            return View(model);
        }

        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Third Page Color",
                PriceDescription = 9000
            };
            return View(model);
        }


    }
}