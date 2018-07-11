using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Filters;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    [ExceptionHandler]
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
                AdLocation = "Daily Star- Color Advertisement Front Page",
                //others day
                PriceDescription = 18000, //color
                PriceDescriptionBlack = 0, //black & white
                //Friday
                PriceDescriptionFriday = 19000, //color
                PriceDescriptionBlackFriday = 0, //black & white

                // column inch restrictions
                MinTotalColumnInch = 12,
                MaxTotalColumnInch = 64,
                MinMaxRestrictiion = true,

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
                PriceDescription = 14000, //color
                PriceDescriptionBlack = 0, //black & white
                //Friday
                PriceDescriptionFriday = 15000, //color
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
                PriceDescription = 10000, //color
                PriceDescriptionBlack = 0, //black & white
                //Friday
                PriceDescriptionFriday = 11000, //color
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
                PriceDescription = 8000,
                PriceDescriptionBlack = 6500,

                PriceDescriptionFriday = 9000,
                PriceDescriptionBlackFriday = 7500,

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,


                IsColor = true,
                IsColorOption = true,
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
                PriceDescription = 6000, //color
                PriceDescriptionBlack = 4800, //black & white
                //Friday
                PriceDescriptionFriday = 6500, //color
                PriceDescriptionBlackFriday = 5300, //black & white

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
                PriceDescription = 8000, //color
                PriceDescriptionBlack = 0, //black & white
                //Friday
                PriceDescriptionFriday = 9000, //color
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

        public ActionResult InnerBusinessPage_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Business Page (Inner Page)",

                //others day
                PriceDescription = 5500, //color
                PriceDescriptionBlack = 4500, //black & white
                //Friday
                PriceDescriptionFriday = 6000, //color
                PriceDescriptionBlackFriday = 5000, //black & white

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
                PriceDescription = 5500, //color
                PriceDescriptionBlack = 4500, //black & white
                //Friday
                PriceDescriptionFriday = 6000, //color
                PriceDescriptionBlackFriday = 5000, //black & white

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,

                IsColor = true,
                IsColorOption = true,
            };
            return View(model);
        }
        public ActionResult AcademicNotice_Display()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Academic Notice",

                //others day
                PriceDescription = 4500, //color
                PriceDescriptionBlack = 3500, //black & white
                //Friday
                PriceDescriptionFriday = 5000, //color
                PriceDescriptionBlackFriday = 4000, //black & white

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
                PriceDescription = 4500, //color
                PriceDescriptionBlack = 3500, //black & white
                //Friday
                PriceDescriptionFriday = 5000, //color
                PriceDescriptionBlackFriday = 4000, //black & white

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
                PriceDescriptionLow = 1500,
                PriceDescription = 5500, //color
                PriceDescriptionBlack = 4500, //black & white
                //Friday
                PriceDescriptionLowFriday = 1700,
                PriceDescriptionFriday = 6000, //color
                PriceDescriptionBlackFriday = 5000, //black & white

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

        #region side panel
        public ActionResult FrontPage_SidePanel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Side Panel- Front Page",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 20000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "1.50",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult BackPage_SidePanel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Side Panel- Back Page",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 20000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "6.429",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult BusinessPage_Panel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Panel- Business Page",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 15000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "3.00",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult SportsPage_SidePanel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Side Panel- Sports Page",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 10000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "3.00",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult BoxNumber_SidePanel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Side Panel- Box Number Service Charge",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 5000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "-",
                InchFloat = "-",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        #endregion

        #region Style
        public ActionResult FrontPage_Style()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Front Page (Style)",

                PriceDescription = 8000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult FrontInner_Style()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Front Inner (Style)",

                PriceDescription = 6000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult BackPage_Style()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Back Page (Style)",

                PriceDescription = 7000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult BackInner_Style()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Back Inner (Style)",

                PriceDescription = 5500,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult ThirdPage_Style()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Third Page (Style)",

                PriceDescription = 4500,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult InnerPage_Style()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Inner Page (Style)",

                PriceDescription = 3000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        #endregion

        #region Shout
        public ActionResult FrontPage_Shout()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Front Page (Shout)",

                PriceDescription = 4000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult FrontInner_Shout()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Front Inner (Shout)",

                PriceDescription = 2500,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult BackPage_Shout()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Back Page (Shout)",

                PriceDescription = 3000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult BackInner_Shout()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Back Inner (Shout)",

                PriceDescription = 2500,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }

        public ActionResult InnerPage_Shout()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Inner Page (Shout)",

                PriceDescription = 2000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        #endregion

        #region Showbiz
        public ActionResult FrontPage_Showbiz()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Front Page (Showbiz)",

                PriceDescription = 6000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult FrontInner_Showbiz()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Front Inner (Showbiz)",

                PriceDescription = 4000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult BackPage_Showbiz()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Back Page (Showbiz)",

                PriceDescription = 5000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult BackInner_Showbiz()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Back Inner (Showbiz)",

                PriceDescription = 4000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }

        public ActionResult InnerPage_Showbiz()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Inner Page (Showbiz)",

                PriceDescription = 3000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        #endregion

        #region StarWeekend
        public ActionResult FrontPage_StarWeekend()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Front Page (Star Weekend)",

                PriceDescription = 4500,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult FrontInner_StarWeekend()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Front Inner (Star Weekend)",

                PriceDescription = 2500,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult BackPage_StarWeekend()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Back Page (Star Weekend)",

                PriceDescription = 3500,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        public ActionResult BackInner_StarWeekend()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Back Inner (Star Weekend)",

                PriceDescription = 2500,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }

        public ActionResult InnerPage_StarWeekend()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star -Inner Page (Star Weekend)",

                PriceDescription = 2000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 72,
                MinMaxRestrictiion = true,

                IsColor = false,
                IsColorOption = false,
            };
            return View(model);
        }
        #endregion

        #region Govt. Ad
        public ActionResult GovtAd()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star Govt. Advertisement",
                TitleDescription = "Govt. Advertisement At Daily Star",
                PriceDescription = 533,

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,

                //color
                IsColor = false,
                IsColorOption = true,

                // page - choose
                GovtPageOption = "0",
                IsGovtPageOption =true,

            };
            return PartialView("GovtAd", model);
        }

        public ActionResult GovtCommercialAd()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Star",
                AdLocation = "Daily Star- Govt. Commercial Advertisement",
                TitleDescription = "Govt. Commercial Advertisement At Daily Star",
                PriceDescription = 799,

                // column inch restrictions
                MinTotalColumnInch = 0,
                MaxTotalColumnInch = 0,
                MinMaxRestrictiion = false,

                //color
                IsColor = false,
                IsColorOption = true,

                // page - choose
                GovtPageOption = "0",
                IsGovtPageOption = true,

            };
            return PartialView("GovtCommercialAd", model);
        }




        #endregion


    }
}