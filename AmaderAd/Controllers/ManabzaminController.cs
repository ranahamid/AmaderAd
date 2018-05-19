using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;
using AspNetSeo.Mvc;

namespace AmaderAd.Controllers
{
    [SeoBaseTitle("Publish advertisement in Manab Zamin through amader ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/Manabzamin")]
    public class ManabzaminController : BaseController
    {
        // GET: Manabzamin
        public ActionResult Index()
        {
            return View();
        }

        //classified advertisement
        [SeoMetaKeywords("amader ad manab zamin classified advertisement,manab zamin classified ad, manab zamin classified advertisement,  publish classied advertisement at manab zamin , classified advertisement cost at manab zamin, manab zamin classified advertisement rate, classified advertisement at manab zamin, মানবজমিনে  শ্রেণীভুক্ত বিজ্ঞাপন দিন,  rent at manab zamin,  house rent at manab zamin, publish rent advertisement at manab zamin, manab zamin rent advertisement, ইত্তেফাক বাড়ি ভাড়া বিজ্ঞাপন,  land slae advertisement at manab zamin, manab zamin land sale advertisement, manab zamin land sale ad cost, মানবজমিনে জমি বিক্রয়ের বিজ্ঞাপন দিন,  miscellaneous sales advertisement at manab zamin, manab zamin miscellaneous slaes advetisement,  miscellaneous sales cost at manab zamin, publish miscellaneous advertisement at manab zamin, miscellaneous at manab zamin, মানবজমিনে বিবিধ বিক্রয়ের বিজ্ঞাপন দিন, house sale advertisement at manab zamin, manab zamin alo house sales advertisement, house sales advertisement cost at manab zamin, publish house sale advertisement at manab zamin, house sale advertisement at manab zamin, মানবজমিনে বাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  shop sale advertisement at manab zamin, manab zamin shop sales advertisement, shop sales advertisement cost at manab zamin, publish shop sale advertisement at manab zamin, house shop advertisement at manab zamin, মানবজমিনে দোকান বিক্রয়ের বিজ্ঞাপন দিন,    car sale advertisement at manab zamin, manab zamin car sales advertisement, car sales advertisement cost at manab zamin, publish car sale advertisement at manab zamin, car sale advertisement at manab zamin, মানবজমিনে গাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  plot purchase advertisement at manab zamin, manab zamin plot purchase advertisement, plot purchase advertisement cost at manab zamin, publish plot purchase advertisement at manab zamin, plot purchase advertisement at manab zamin, মানবজমিনে প্লট ক্রয়ের  বিজ্ঞাপন দিন, 	 wanted advertisement at manab zamin, manab zamin wanted advertisement, wanted advertisement cost at manab zamin, publish wanted advertisement at manab zamin, wanted advertisement at manab zamin, 	 tution wanted advertisement at manab zamin, manab zamin tution wante advertisement, tution wanted advertisement cost at manab zamin, publish tution wanted advertisement at manab zamin, tuiton wanted advertisement at manab zamin, মানবজমিনে  পড়াতে চাই   বিজ্ঞাপন দিন,  groom wanted advertisement at manab zamin, manab zamin groom wanted advertisement, groom wanted advertisement cost at manab zamin, publish groom wanted advertisement at manab zamin, groom wnated advertisement at manab zamin, মানবজমিনে  পাত্র চাই  বিজ্ঞাপন দিন,  bride wanted advertisement at manab zamin, manab zamin plot bride wanted advertisement, bride wanted  advertisement cost at manab zamin, bride wanted purchase advertisement at manab zamin, bride wanted  advertisement at manab zamin, মানবজমিনে  পাত্রী চাই  বিজ্ঞাপন দিন")]
        [SeoTitle("Publish classified advertisement in manab zamin through")]
        [SeoMetaDescription("Publish your advertisement in manab zamin from any where through amader ad")]
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manab Zamin",
      
                AdLocation = "Manab Zamin Classified Advertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,
                PriceDescription = 600,
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
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin first page color advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult LastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin last page color advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }

        public ActionResult SpecialDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin special display advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult GeneralDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin general display advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult EducativeReligiousAffairAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin educative religious affair advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin third page color advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin third page black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult EntertainmentPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin entertainment page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult EntertainmentPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin entertainment page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult SportPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin sport page color advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult OtherPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin other page color advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult FirstPageColorAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin First Page Spot Advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }
        public ActionResult LastPageColorAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin last Page Spot Advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }
        public ActionResult FirstPage_pannel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin First page pannel",
                PriceDescription = 7000
            };
            return View(model);
        }

    }
}