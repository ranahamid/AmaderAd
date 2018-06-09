using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class DailyStarController : BaseController
    {
        // GET: DailyStar
        public ActionResult Index()
        {
            return View();
        }


        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star Classified Advertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,
                PriceDescription = 300,
                ExtraWordPrice = 40,
                WordLimit = 50,
                VAT = 0.15,

                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        #region Display Advertisement
        public ActionResult Frontpage_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star- Front Page",

                //others day
                PriceDescription = 13500, //color
                PriceDescriptionBlack = 0, //black & white
                //Friday
                PriceDescriptionFriday = 14500, //color
                PriceDescriptionBlackFriday = 0, //black & white

                // column inch restrictions
                MinTotalColumnInch = 12,
                MaxTotalColumnInch = 64,
                MinMaxRestrictiion=true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }

        public ActionResult Backpage_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star- Back Page",

                //others day
                PriceDescription = 10500, //color
                PriceDescriptionBlack = 0, //black & white
                //Friday
                PriceDescriptionFriday = 11500, //color
                PriceDescriptionBlackFriday = 0, //black & white

                // column inch restrictions
                MinTotalColumnInch = 4,
                MaxTotalColumnInch = 80,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }

        public ActionResult PageThree_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star Page Three",

                //others day
                PriceDescription = 7500, //color
                PriceDescriptionBlack = 0, //black & white
                //Friday
                PriceDescriptionFriday = 8500, //color
                PriceDescriptionBlackFriday = 0, //black & white

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }

        public ActionResult PageFive_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star Page Five",
                PriceDescription = 6000,
                PriceDescriptionBlack = 4500,

                PriceDescriptionFriday = 7000,
                PriceDescriptionBlackFriday =5500,

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,


                IsColor = true,
                IsColorOption= true,
            };
            return View(model);
        }



        public ActionResult PageSeven_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star Page Seven",

                //others day
                PriceDescription = 4800, //color
                PriceDescriptionBlack = 3600, //black & white
                //Friday
                PriceDescriptionFriday = 5300, //color
                PriceDescriptionBlackFriday = 4100, //black & white

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,

                IsColor = true,
                IsColorOption = true,
            };
            return View(model);
        }

        public ActionResult FrontBusinessPage_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Business Page (Front Page Color)",

                //others day
                PriceDescription = 6000, //color
                PriceDescriptionBlack = 0, //black & white
                //Friday
                PriceDescriptionFriday = 7000, //color
                PriceDescriptionBlackFriday = 0, //black & white

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }

        public ActionResult BackBusinessPage_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Business Page (Back Page Color)",

                //others day
                PriceDescription = 4500, //color
                PriceDescriptionBlack = 0, //black & white
                //Friday
                PriceDescriptionFriday = 5500, //color
                PriceDescriptionBlackFriday = 0, //black & white

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }

        public ActionResult InnerBusinessPage_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Business Page (Inner Page)",

                //others day
                PriceDescription = 4000, //color
                PriceDescriptionBlack = 3000, //black & white
                //Friday
                PriceDescriptionFriday = 4500, //color
                PriceDescriptionBlackFriday = 3500, //black & white

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,

                IsColor = true,
                IsColorOption = true,
            };
            return View(model);
        }

        public ActionResult OtherInsidePages_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Other Inside Pages",

                //others day
                PriceDescription = 4200, //color
                PriceDescriptionBlack = 3200, //black & white
                //Friday
                PriceDescriptionFriday = 4700, //color
                PriceDescriptionBlackFriday = 3600, //black & white

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,

                IsColor = true,
                IsColorOption = true,
            };
            return View(model);
        }

        public ActionResult CareerNotice_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Career Opportunity/ Job Search/ Notice (Tender, Legal, Announcement, Affidavit)",

                //others day
                PriceDescription = 3300, //color
                PriceDescriptionBlack = 2400, //black & white
                //Friday
                PriceDescriptionFriday = 3800, //color
                PriceDescriptionBlackFriday = 2800, //black & white

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,

                IsColor = true,
                IsColorOption = true,
            };
            return View(model);
        }

        public ActionResult BirthdayTolet_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Birthday/ To-Let/ Purchase/ Sale/ Tution/ Lost/ Theatre",

                //others day
                PriceDescriptionLow= 1000,
                PriceDescription = 3000, //color
                PriceDescriptionBlack = 2000, //black & white
                //Friday
                PriceDescriptionLowFriday = 1200,
                PriceDescriptionFriday = 3500, //color
                PriceDescriptionBlackFriday = 2500, //black & white

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,

                IsColor = true,
                IsColorOption = true,
            };
            return View(model);
        }
        #endregion


    }
}