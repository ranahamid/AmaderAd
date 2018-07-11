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
    public class KalerKanthoController : BaseController
    {
        // GET: KalerKantho
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
        #region Govt. Ad
        public ActionResult GovtAd()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Kaler Kontho",
                AdLocation = "Kaler Kontho Govt. Advertisement",
                TitleDescription = "Govt. Advertisement At Kaler Kontho",
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
                IsGovtPageOption = true,

            };
            return PartialView("GovtAd", model);
        }

        public ActionResult GovtCommercialAd()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Kaler Kontho",
                AdLocation = "Kaler Kontho- Govt. Commercial Advertisement",
                TitleDescription = "Govt. Commercial Advertisement At Kaler Kontho",
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