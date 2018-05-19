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

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,
                PriceDescription = 300,
                ExtraWordPrice = 40,
                WordLimit = 50,

                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult FirstPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",

                AdLocation = "Janakantha First Page Color",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult GeneralDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "Janakantha General Display Advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult SecondpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "Janakantha Secondpage black and white Advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult thirdpagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "Janakantha third page color Advertisement",
                PriceDescription = 9000
            };
            return View(model);
        }
        public ActionResult thirdpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha third page black and white advertisement",
                PriceDescription = 7000
            };
            return View(model);
        }
        public ActionResult fifthpagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha fifth page color advertisement",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult fifthpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha fifth page black and white advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult sportspagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha sports page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult  sportspageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha sports page black and white Advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult pagebeforlastpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha page befor last page black and white advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult lastpagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha last page color advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }
        public ActionResult firstpagespotAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha first page spot advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }
        public ActionResult lastpagespotAdvertisement_MainPage()
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