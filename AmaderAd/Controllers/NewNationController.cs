using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class NewNationController : BaseController
    {
        // GET: NewNation
        public ActionResult Index()
        {
            return View();
        }

        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
    }
}