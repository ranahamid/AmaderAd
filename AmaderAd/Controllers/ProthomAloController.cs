﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Filters;
using AmaderAd.Models;



namespace AmaderAd.Controllers
{
    [ExceptionHandler]
    public class ProthomAloController : BaseController
    {
        // GET: ProthomAlo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Kaler Kontho",
                AdLocation = "Kaler Kontho Classified Advertisement",

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
    }


}