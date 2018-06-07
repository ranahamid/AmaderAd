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
        public ActionResult PageFive()
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
                IsColor = true,
                IsColorOption= true,
            };
            return View(model);
        }
        #endregion


    }
}