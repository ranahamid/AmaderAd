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
        public ActionResult ManabZaminfirstpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin first page color advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult Manabzaminlastpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin last page color advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }

        public ActionResult Manabzaminspecialdisplayadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin special display advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult Manabzamingeneraldisplayadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin general display advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult Manabzamineducativereligiousaffairadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin educative religious affair advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        public ActionResult Manabzaminthirdpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin third page color advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult Manabzaminthirdpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin third page black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Manabzaminentertainmentpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin entertainment page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Manabzaminentertainmentpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin entertainment page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult Manabzaminsportpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin sport page color advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult Manabzaminotherpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin other page color advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult ManabzaminFirstPageColorAdvertisement_SpotPanel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin First Page Spot Advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }
        public ActionResult ManabzaminLastPageColorAdvertisement_SpotPanel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin last Page Spot Advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }
        public ActionResult Manabzaminfirstpagepannel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin First page pannel",
                PriceDescription = 7000
            };
            return View(model);
        }

    }
}