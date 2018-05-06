using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class JanakanthaController : BaseController
    {
        // GET: Janakantha
        public ActionResult Index()
        {
            return View();
        }
        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "JanakanthaClassifiedAdvertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult JanakanthaFirstPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "Janakantha First Page Color",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult JanakanthaGeneralDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "Janakantha General Display Advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult JanakanthaSecondpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "Janakantha Secondpage black and white Advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult JanakanthathirdpagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "Janakantha third page color Advertisement",
                PriceDescription = 9000
            };
            return View(model);
        }
        public ActionResult JanakanthathirdpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha third page black and white advertisement",
                PriceDescription = 7000
            };
            return View(model);
        }
        public ActionResult janakanthafifthpagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha fifth page color advertisement",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult janakanthafifthpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha fifth page black and white advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult janakanthasportspagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha sports page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult janakanthasportspageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha sports page black and white Advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult janakanthapagebeforlastpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha page befor last page black and white advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult JanakanthalastpagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha last page color advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }
        public ActionResult janakanthafirstpagespotAdvertisem_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha first page spot advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }
        public ActionResult jankanthalastpagespotAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "jankantha last page spot advertisement",
                PriceDescription = 15000
            };
            return View(model);
        }
    }
}