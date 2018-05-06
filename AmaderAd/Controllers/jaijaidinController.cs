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
        public ActionResult Jaijaidinfirstpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin first page color advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult Jaijaidinlastpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin last page color advertisement",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult Jaijaidinlastpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin last page black and white advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult Jaijaidingeneraldisplaycoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin general display color advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult Jaijaidingeneraldisplayblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin general display black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult Jaijaidinthirdpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin third page color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult Jaijaidinthirdpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin third page black and white advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult Jaijaidinfifthpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "jaijaidin fifth page color advertisement",
                PriceDescription = 7000
            };
            return View(model);
        }
        public ActionResult Jaijaidinfifthpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin fifth page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult Jaijaidinsportspagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin sports page color advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult Jaijaidinsportspageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin sports page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult Jaijaidininnerpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "jaijaidin inner page color advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult Jaijaidininnerpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin inner page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult Jaijaidinsummonsnoticefinanacecourtadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin summons notice finance court advertisement",
                PriceDescription = 3400
            };
            return View(model);
        }
        public ActionResult Jaijaidinfirstpageadvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin first page spot advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }
        public ActionResult Jaijaidinlastpageadvertisement_Spot()
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