using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;
using AspNetSeo.Mvc;

namespace AmaderAd.Controllers
{
    [SeoBaseTitle("publish advertisement in JaiJaidin through amader ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/jaijaidin")]
    public class JaiJaidinController : BaseController
    {

        // GET: Jaijaidin
        public ActionResult Index()
        {
            return View();
        }

        //classified advertisement
        [SeoMetaKeywords("amader ad jaijaidin classified advertisement,jaijaidin classified ad, jaijaidin classified advertisement, publish classied advertisement at jaijaidin , classified advertisement cost at jaijaidin, jaijaidin classified advertisement rate, classified advertisement at jaijaidin, যায়যায়দিনে  শ্রেণীভুক্ত বিজ্ঞাপন দিন,  rent at jaijaidin, house rent at jaijaidin, publish rent advertisement at jaijaidin, jaijaidin rent advertisement, যায়যায়দিন বাড়ি ভাড়া বিজ্ঞাপন,  land slae advertisement at jaijaidin, jaijaidin land sale advertisement, jaijaidin land sale ad cost, যায়যায়দিনে জমি বিক্রয়ের বিজ্ঞাপন দিন,  miscellaneous sales advertisement at jaijaidin, jaijaidin miscellaneous slaes advetisement, miscellaneous sales cost at jaijaidin, publish miscellaneous advertisement at jaijaidin, miscellaneous at jaijaidin, যায়যায়দিনে বিবিধ বিক্রয়ের বিজ্ঞাপন দিন, house sale advertisement at jaijaidin, jaijaidin house sales advertisement, house sales advertisement cost at jaijaidin, publish house sale advertisement at jaijaidin, house sale advertisement at jaijaidin, যায়যায়দিনে বাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  shop sale advertisement at jaijaidin, jaijaidin shop sales advertisement, shop sales advertisement cost at jaijaidin, publish shop sale advertisement at jaijaidin, house shop advertisement at jaijaidin, যায়যায়দিনে দোকান বিক্রয়ের বিজ্ঞাপন দিন,     car sale advertisement at jaijaidin, jaijaidin car sales advertisement, car sales advertisement cost at jaijaidin, publish car sale advertisement at jaijaidin, car sale advertisement at jaijaidin, যায়যায়দিনে গাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  plot purchase advertisement at jaijaidin, jaijaidin plot purchase advertisement, plot purchase advertisement cost at jaijaidin, publish plot purchase advertisement at jaijaidin, plot purchase advertisement at jaijaidin, যায়যায়দিনে প্লট ক্রয়ের  বিজ্ঞাপন দিন, 	 wanted advertisement at jaijaidin, jaijaidin wanted advertisement, wanted advertisement cost at jaijaidin, publish wanted advertisement at jaijaidin, wanted advertisement at jaijaidin, 	 tution wanted advertisement at jaijaidin, jaijaidin tution wante advertisement, tution wanted advertisement cost at jaijaidin, publish tution wanted advertisement at jaijaidin, tuiton wanted advertisement at jaijaidin, যায়যায়দিনে  পড়াতে চাই   বিজ্ঞাপন দিন,  groom wanted advertisement at jaijaidin, jaijaidin groom wanted advertisement, groom wanted advertisement cost at jaijaidin, publish groom wanted advertisement at jaijaidin, groom wnated advertisement at jaijaidin, যায়যায়দিনে  পাত্র চাই  বিজ্ঞাপন দিন,  bride wanted advertisement at jaijaidin, jaijaidin plot bride wanted advertisement, bride wanted  advertisement cost at jaijaidin, bride wanted purchase advertisement at jaijaidin, bride wanted  advertisement at jaijaidin, যায়যায়দিনে  পাত্রী চাই  বিজ্ঞাপন দিন")]
        [SeoTitle("Publish classified advertisement in jaijaidin through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your classified advertisement jaijaidin")]        
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
           
                AdLocation = "JaijaidinClassifiedAdvertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,
                PriceDescription = 300,
                ExtraWordPrice = 40,
                WordLimit = 50,

                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        [SeoTitle("First Page Color Advertisement")]
        public ActionResult FirstPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin first page color advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }

        [SeoTitle("Classified Advertisement")]
        public ActionResult lastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin last page color advertisement",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult LastPageblacWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin last page black and white advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult GeneralDisplayColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin general display color advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult GeneralDisplayBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin general display black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin third page color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin third page black and white advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult FifthPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "jaijaidin fifth page color advertisement",
                PriceDescription = 7000
            };
            return View(model);
        }
        public ActionResult FifthPageblackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin fifth page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult SportsPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin sports page color advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult SportsPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin sports page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult InnerPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "jaijaidin inner page color advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult InnerPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin inner page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult SummonsNoticeFinanaceCourtAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin summons notice finance court advertisement",
                PriceDescription = 3400
            };
            return View(model);
        }
        public ActionResult FirstPageAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin first page spot advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }
        public ActionResult LastPageAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin last page spot advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }



    }
}