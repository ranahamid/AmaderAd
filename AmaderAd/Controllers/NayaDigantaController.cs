using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class NayaDigantaController : BaseController
    {
        // GET: NayaDiganta
        public ActionResult Index()
        {
            return View();
        }
        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
    }
}