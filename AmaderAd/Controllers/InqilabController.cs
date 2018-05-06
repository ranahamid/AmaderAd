using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class InqilabController : BaseController
    {
        // GET: Inqilab
        public ActionResult Index()
        {
            return View();
        }

        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        public ActionResult Inqilabfirstpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab first page color advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult Inqilablastpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab last page color advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }
        public ActionResult Inqilabgeneraldisplayadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab general display advertisement",
                PriceDescription = 3600
            };
            return View(model);
        }
        public ActionResult Inqilabthirdpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab third page color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult Inqilabthirdpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab third page black and white advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Inqilabsecondpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab second page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult Inqilabinnerpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab inner page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Inqilabinnerpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab inner page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult Inqilabsportspagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab sports page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Inqilabsportspageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab sports page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult Inqilabpagebeforelastpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab page before last page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult Inqilabentertainmentpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab entertainment page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult inqilabentertainmentpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab entertainment page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }


    }
}