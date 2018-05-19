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
                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,
                PriceDescription = 300,
                ExtraWordPrice = 40,
                WordLimit = 50,


                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        public ActionResult FirstPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab first page color advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult LastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab last page color advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }
        public ActionResult GeneralDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab general display advertisement",
                PriceDescription = 3600
            };
            return View(model);
        }
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab third page color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab third page black and white advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult SecondPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab second page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult InnerPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab inner page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult InnerPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab inner page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult SportsPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab sports page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult SportsPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab sports page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult PageBeforeLastPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab page before last page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult EntertainmentPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab entertainment page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult EntertainmentPageBlackWhiteAdvertisement_MainPage()
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