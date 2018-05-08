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
        public ActionResult FrontPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation front page color advertisement",
                PriceDescription = 9000
            };
            return View(model);
        }
        public ActionResult BackpageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation back page color advertisement",
                PriceDescription = 7000
            };
            return View(model);
        }
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation third page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation third page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult OtherInsidePageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation other inside page color advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult CommercialDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation Commercial Display Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        public ActionResult HighCourtJudgeCourtAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation High Court Judge Court Advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
    }
}