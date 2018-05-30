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

        #region classified

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
                FirstWordLimitBase = 30,
                PriceDescription = 300,
                ExtraWordPrice = 20,
                WordLimit = 60,

                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        #endregion
        //classified advertisement


        #region MAIN PAPER

        [SeoMetaKeywords("amader ad jaijaidin first page advertisement, jaijaidin first page color advertisement, jaijaidin 1st page advertisement, jaijaidin 1st page color advbertisement, jaijaidin 1 number page advertisement, jaijaidin one number page color advertisement, publish advertisement at jaijaidin first page, advertisement cost at jaijaidin first page, jaijaidin first page advertisement rate, color advertisement at jaijaidin first page")]
        [SeoTitle("Publish color advertisement in jaijaidin first page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in jaijaidin first page")]
        public ActionResult FirstPageColor_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin first page color advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }

        [SeoMetaKeywords("amader ad jaijaidin last page advertisement, jaijaidin last page color advertisement, jaijaidin last page advertisement,  jaijaidin last page color advbertisement, jaijaidin last number page advertisement, jaijaidin last number page color advertisement, publish advertisement at jaijaidin last page, advertisement cost at jaijaidin last page, jaijaidin last page advertisement rate, color advertisement at jaijaidin last page")]
        [SeoTitle("Publish color advertisement in jaijaidin last page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in jaijaidin last page")]
        public ActionResult LastPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin last page color advertisement",
                PriceDescription = 10000,

                PriceDescriptionBlack = 8000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad jaijaidin last page advertisement, jaijaidin last page black and white advertisement, jaijaidin last page advertisement,  jaijaidin last page black and white advbertisement, jaijaidin last number page advertisement, jaijaidin last number page black and white advertisement, publish advertisement at jaijaidin last page, advertisement cost at jaijaidin last page, jaijaidin last page black and white advertisement rate, black and white advertisement at jaijaidin last page")]
        //[SeoTitle("Publish black and white advertisement in jaijaidin last page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in jaijaidin last page")]
        //public ActionResult LastPageBW_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Jaijaidin",
        //        AdLocation = "Jaijaidin last page black and white advertisement",
        //        PriceDescription = 8000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad jaijaidin general display color advertisement, jaijaidin general display color advertisement, publish general display color  advertisement in jaijaidin , general display color  advertisement cost at jaijaidin , jaijaidin general display color advertisement rate, general display color advertisement at jaijaidin")]
        [SeoTitle("Publish general display color  advertisement in jaijaidin through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your general display color advertisement in jaijaidin")]
        public ActionResult GeneralDisplay_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin general display color advertisement",
                PriceDescription = 4000,

                PriceDescriptionBlack = 3000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad jaijaidin general display black and white  advertisement, jaijaidin general display black and white  advertisement, publish general display black and white  advertisement in jaijaidin, general display black and white advertisement cost at jaijaidin , jaijaidin general display black and white advertisement rate, general display black and white advertisement at jaijaidin")]
        //[SeoTitle("Publish general display black and white  advertisement in jaijaidin through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your general  advertisement in jaijaidin")]
        //public ActionResult GeneralDisplayBW_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Jaijaidin",
        //        AdLocation = "Jaijaidin general display black and white advertisement",
        //        PriceDescription = 3000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad jaijaidin third page advertisement, jaijaidin third page color advertisement, jaijaidin 3rd page advertisement, jaijaidin 3rd page color advbertisement, jaijaidin 3 number page advertisement, jaijaidin three number page color advertisement, publish advertisement at jaijaidin third page, advertisement cost at jaijaidin third page, jaijaidin third page advertisement rate, color advertisement at jaijaidin third page")]
        [SeoTitle("Publish color advertisement in jaijaidin third page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in jaijaidin third page")]
        public ActionResult ThirdPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin third page color advertisement",
                PriceDescription = 8000,

                PriceDescriptionBlack = 6000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad jaijaidin third page advertisement, jaijaidin third page black and white advertisement, jaijaidin 3rd page advertisement,  jaijaidin 3rd page black and white advbertisement, jaijaidin 3 number page advertisement, jaijaidin three number page black and white advertisement, publish advertisement at jaijaidin third page, advertisement cost at jaijaidin third page, jaijaidin third page black and white advertisement rate, black and white advertisement at jaijaidin third page")]
        //[SeoTitle("Publish black and white advertisement in jaijaidin third page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in jaijaidin third page")]
        //public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Jaijaidin",
        //        AdLocation = "Jaijaidin third page black and white advertisement",
        //        PriceDescription = 6000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad jaijaidin fifth page advertisement, jaijaidin fifth page color advertisement, jaijaidin 5th page advertisement, jaijaidin 5th page color advbertisement, jaijaidin 5 number page advertisement, jaijaidin five number page color advertisement, publish advertisement at jaijaidin fifth page, advertisement cost at jaijaidin fifth page, jaijaidin fifth page color advertisement rate, color advertisement at jaijaidin fifth page")]
        [SeoTitle("Publish color advertisement in jaijaidin fifth page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in jaijaidin third page")]
        public ActionResult FifthPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "jaijaidin fifth page color advertisement",
                PriceDescription = 7000,

                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad jaijaidin fifth page advertisement, jaijaidin fifth page black and white advertisement, jaijaidin 5th page advertisement,  jaijaidin 5th page black and white advbertisement, jaijaidin 5 number page advertisement, jaijaidin five number page black and white advertisement, publish advertisement at jaijaidin fifth page, advertisement cost at jaijaidin fifth page, jaijaidin fifth page black and white advertisement rate, black and white advertisement at jaijaidin fifth page")]
        //[SeoTitle("Publish black and white advertisement in jaijaidin fifth page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in jaijaidin fifth page")]
        //public ActionResult FifthPageblackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Jaijaidin",
        //        AdLocation = "Jaijaidin fifth page black and white advertisement",
        //        PriceDescription = 4000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad jaijaidin sports page advertisement, jaijaidin sports page color advertisement, jaijaidin sports page advertisement, publish advertisement at jaijaidin sports page, advertisement cost at jaijaidin sports page, jaijaidin sports page color advertisement rate, color advertisement at jaijaidin sports page")]
        [SeoTitle("Publish color advertisement in jaijaidin sports page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in jaijaidin sports page")]
        public ActionResult SportsPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin sports page color advertisement",
                PriceDescription = 6000,

                PriceDescriptionBlack = 3000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad jaijaidin sports page advertisement, jaijaidin sports page black and white advertisement, jaijaidin sports page advertisement, publish advertisement at jaijaidin sports page, advertisement cost at jaijaidin sports page, jaijaidin sports page black and white advertisement rate, black and white advertisement at jaijaidin sports page")]
        //[SeoTitle("Publish black and white advertisement in jaijaidin sports page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in jaijaidin sports page")]
        //public ActionResult SportsPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Jaijaidin",
        //        AdLocation = "Jaijaidin sports page black and white advertisement",
        //        PriceDescription = 3000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad jaijaidin inner page advertisement, jaijaidin inner page color advertisement, jaijaidin inner page advertisement, publish advertisement at jaijaidin inner  page, advertisement cost at jaijaidin inner page, jaijaidin inner page color advertisement rate, color advertisement at jaijaidin inner page")]
        [SeoTitle("Publish color advertisement in jaijaidin inner page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in jaijaidin inner page")]
        public ActionResult InnerPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "jaijaidin inner page color advertisement",
                PriceDescription = 4000,

                PriceDescriptionBlack = 3000,
                IsColor = true,
            };
            return View(model);
        }

        //[SeoMetaKeywords("amader ad jaijaidin inner page advertisement, jaijaidin inner page black and white advertisement, jaijaidin inner page advertisement, publish advertisement at jaijaidin inner  page, advertisement cost at jaijaidin inner page, jaijaidin inner page black and white advertisement rate, black and white advertisement at jaijaidin inner page")]
        //[SeoTitle("Publish black and white advertisement in jaijaidin inner page throgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in jaijaidin inner page")]
        //public ActionResult InnerPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Jaijaidin",
        //        AdLocation = "Jaijaidin inner page black and white advertisement",
        //        PriceDescription = 3000
        //    };
        //    return View(model);
        //}

        #endregion

        #region SummonsNoticeFinanaceCourt_MainPage

        [SeoMetaKeywords("amader ad jaijaidin classified advertisement,jaijaidin classified ad, jaijaidin classified advertisement, publish classied advertisement at jaijaidin , classified advertisement cost at jaijaidin, jaijaidin classified advertisement rate, classified advertisement at jaijaidin, যায়যায়দিনে  শ্রেণীভুক্ত বিজ্ঞাপন দিন,  rent at jaijaidin, house rent at jaijaidin, publish rent advertisement at jaijaidin, jaijaidin rent advertisement, যায়যায়দিন বাড়ি ভাড়া বিজ্ঞাপন,  land slae advertisement at jaijaidin, jaijaidin land sale advertisement, jaijaidin land sale ad cost, যায়যায়দিনে জমি বিক্রয়ের বিজ্ঞাপন দিন,  miscellaneous sales advertisement at jaijaidin, jaijaidin miscellaneous slaes advetisement, miscellaneous sales cost at jaijaidin, publish miscellaneous advertisement at jaijaidin, miscellaneous at jaijaidin, যায়যায়দিনে বিবিধ বিক্রয়ের বিজ্ঞাপন দিন, house sale advertisement at jaijaidin, jaijaidin house sales advertisement, house sales advertisement cost at jaijaidin, publish house sale advertisement at jaijaidin, house sale advertisement at jaijaidin, যায়যায়দিনে বাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  shop sale advertisement at jaijaidin, jaijaidin shop sales advertisement, shop sales advertisement cost at jaijaidin, publish shop sale advertisement at jaijaidin, house shop advertisement at jaijaidin, যায়যায়দিনে দোকান বিক্রয়ের বিজ্ঞাপন দিন,     car sale advertisement at jaijaidin, jaijaidin car sales advertisement, car sales advertisement cost at jaijaidin, publish car sale advertisement at jaijaidin, car sale advertisement at jaijaidin, যায়যায়দিনে গাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  plot purchase advertisement at jaijaidin, jaijaidin plot purchase advertisement, plot purchase advertisement cost at jaijaidin, publish plot purchase advertisement at jaijaidin, plot purchase advertisement at jaijaidin, যায়যায়দিনে প্লট ক্রয়ের  বিজ্ঞাপন দিন, 	 wanted advertisement at jaijaidin, jaijaidin wanted advertisement, wanted advertisement cost at jaijaidin, publish wanted advertisement at jaijaidin, wanted advertisement at jaijaidin, 	 tution wanted advertisement at jaijaidin, jaijaidin tution wante advertisement, tution wanted advertisement cost at jaijaidin, publish tution wanted advertisement at jaijaidin, tuiton wanted advertisement at jaijaidin, যায়যায়দিনে  পড়াতে চাই   বিজ্ঞাপন দিন,  groom wanted advertisement at jaijaidin, jaijaidin groom wanted advertisement, groom wanted advertisement cost at jaijaidin, publish groom wanted advertisement at jaijaidin, groom wnated advertisement at jaijaidin, যায়যায়দিনে  পাত্র চাই  বিজ্ঞাপন দিন,  bride wanted advertisement at jaijaidin, jaijaidin plot bride wanted advertisement, bride wanted  advertisement cost at jaijaidin, bride wanted purchase advertisement at jaijaidin, bride wanted  advertisement at jaijaidin, যায়যায়দিনে  পাত্রী চাই  বিজ্ঞাপন দিন")]
        [SeoTitle("Publish classified advertisement in jaijaidin through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your classified advertisement jaijaidin")]
        public ActionResult SummonsNoticeFinanaceCourt_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin summons notice finance court advertisement",
                PriceDescription = 3400
            };
            return View(model);
        }

        #endregion

        #region SPOT

        [SeoMetaKeywords("amader ad jaijaidin first page spot advertisement, jaijaidin first page spot advertisement, publish spot advertisement at jaijaidin first page,spot advertisement cost at jaijaidin first page, jaijaidin first page spot advertisement rate, spot advertisement at jaijaidin first page")]
        [SeoTitle("Publish spot advertisement in jaijaidin first page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in jaijaidin first page")]
        public ActionResult FirstPage_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin first page spot advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad jaijaidin last page spot advertisement, jaijaidin last page spot advertisement, publish spot advertisement at jaijaidin last page,spot advertisement cost at jaijaidin last page, jaijaidin last page spot advertisement rate, spot advertisement at jaijaidin last page")]
        [SeoTitle("Publish Spot advertisement in jaijaidin last page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in jaijaidin last page")]
        public ActionResult LastPage_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Jaijaidin",
                AdLocation = "Jaijaidin last page spot advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }

        #endregion




    }
}