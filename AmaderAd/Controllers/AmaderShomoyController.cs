using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class AmaderShomoyController : BaseController
    {
        // GET: AmaderShomoy
        public ActionResult Index()
        {
            return View();

        }
        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy Classified Advertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,
                PriceDescription = 300,
                ExtraWordPrice = 40,
                WordLimit = 50,
                VAT=0.15,

                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult FirstPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shonoy First Page Color",
                PriceDescription = 16000
            };
            return View(model);
        }
        public ActionResult LastPageColorAdvertisemnet_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy last page color advertisemnet",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy third page color advertisement",
                PriceDescription = 9000
            };
            return View(model);
        }
        public ActionResult ThirdPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy third page black and white advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult FifthPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy fifth page color advertisement",
                PriceDescription = 6500
            };
            return View(model);
        }
        public ActionResult FifthPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy fifth page black and white advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult EightPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy eight page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult TenPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy ten page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult SecondPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy second page color advertisement",
                PriceDescription = 6500
            };
            return View(model);
        }
        public ActionResult SecondPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy second page black and white advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult ElevenPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy eleven page color advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult ElevenPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy eleven page black and white advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult InnerPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy inner page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult InnerPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy inner page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult FirstPageSpotAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy first page spot advertisement",
                PriceDescription = 300000
            };
            return View(model);
        }
        public ActionResult LastPageSpotAdvertisementMainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy last page spot advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }
        public ActionResult SpecialKororpotroColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy special kororpotro color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult SpecialKororpotroBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy special kororpotro black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult AynashomoyFirstPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy ayna shomoy first page-color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult AynashomoyLastPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy ayna shomoy last page-color advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult AynashomoyThirdPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy ayna shomoy third page-color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult AynashomoyGeneralPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy ayna shomoy general page-color advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }

    }

}