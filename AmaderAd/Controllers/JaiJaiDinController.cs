using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class JaiJaiDinController : BaseController
    {
        // GET: JaiJaiDin
        public ActionResult Index()
        {
            return View();
        }

        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "JaiJaiDin",
                AdLocation = "Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        public ActionResult FirstPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "JaiJaiDin",
                AdLocation = "JaiJaiDin First Page Color",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }


    }
}