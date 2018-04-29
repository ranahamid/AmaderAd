using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class JaiaidinController : BaseController
    {
        // GET: Jaijaidin
        public ActionResult Index()
        {
            return View();
        }

        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "JaijaidinClassifiedAdvertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }



    }
}