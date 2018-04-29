using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class AmaderShomoyController : BaseController
    {
        // GET: AmaderShomoy
        public ActionResult Index()
        {
            return View();
        }
        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
    }
}