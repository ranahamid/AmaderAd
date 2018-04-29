using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class ManabzaminController : BaseController
    {
        // GET: Manabzamin
        public ActionResult Index()
        {
            return View();
        }

        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manab Zamin",
                AdLocation = "Manab Zamin Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

    }
}