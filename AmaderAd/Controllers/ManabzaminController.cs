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
        public ActionResult FirstPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin first page color advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult LastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin last page color advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }

        public ActionResult SpecialDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin special display advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult GeneralDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin general display advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult EducativeReligiousAffairAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin educative religious affair advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin third page color advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin third page black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult EntertainmentPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin entertainment page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult EntertainmentPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin entertainment page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult SportPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin sport page color advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult OtherPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin other page color advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult FirstPageColorAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin First Page Spot Advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }
        public ActionResult LastPageColorAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin last Page Spot Advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }
        public ActionResult FirstPage_pannel()
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