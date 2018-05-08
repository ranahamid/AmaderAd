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
        public ActionResult FirstPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin first page color advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult lastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin last page color advertisement",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult LastPageblacWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin last page black and white advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult GeneralDisplayColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin general display color advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult GeneralDisplayBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin general display black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin third page color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin third page black and white advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult FifthPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "jaijaidin fifth page color advertisement",
                PriceDescription = 7000
            };
            return View(model);
        }
        public ActionResult FifthPageblackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin fifth page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult SportsPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin sports page color advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult SportsPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin sports page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult InnerPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "jaijaidin inner page color advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult InnerPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin inner page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult SummonsNoticeFinanaceCourtAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin summons notice finance court advertisement",
                PriceDescription = 3400
            };
            return View(model);
        }
        public ActionResult FirstPageAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin first page spot advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }
        public ActionResult LastPageAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin last page spot advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }



    }
}