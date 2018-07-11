using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Filters;
using AmaderAd.Models;
using AspNetSeo.Mvc;

namespace AmaderAd.Controllers
{
    [ExceptionHandler]
    [SeoBaseTitle("publish advertisement in Ittefaq through amader ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/Ittefaq")]
    public class IttefaqController : BaseController
    {
        // GET: Ittefaq
        public ActionResult Index()
        {
            return View();
        }

        #region classified        
        //classified advertisement
        [SeoMetaKeywords("amader ad manab zamin classified advertisement,manab zamin classified ad, manab zamin classified advertisement,  publish classied advertisement at manab zamin , classified advertisement cost at manab zamin, manab zamin classified advertisement rate, classified advertisement at manab zamin, মানবজমিনে  শ্রেণীভুক্ত বিজ্ঞাপন দিন,  rent at manab zamin,  house rent at manab zamin, publish rent advertisement at manab zamin, manab zamin rent advertisement, ইত্তেফাক বাড়ি ভাড়া বিজ্ঞাপন,  land slae advertisement at manab zamin, manab zamin land sale advertisement, manab zamin land sale ad cost, মানবজমিনে জমি বিক্রয়ের বিজ্ঞাপন দিন,  miscellaneous sales advertisement at manab zamin, manab zamin miscellaneous slaes advetisement,  miscellaneous sales cost at manab zamin, publish miscellaneous advertisement at manab zamin, miscellaneous at manab zamin, মানবজমিনে বিবিধ বিক্রয়ের বিজ্ঞাপন দিন, house sale advertisement at manab zamin, manab zamin alo house sales advertisement, house sales advertisement cost at manab zamin, publish house sale advertisement at manab zamin, house sale advertisement at manab zamin, মানবজমিনে বাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  shop sale advertisement at manab zamin, manab zamin shop sales advertisement, shop sales advertisement cost at manab zamin, publish shop sale advertisement at manab zamin, house shop advertisement at manab zamin, মানবজমিনে দোকান বিক্রয়ের বিজ্ঞাপন দিন,    car sale advertisement at manab zamin, manab zamin car sales advertisement, car sales advertisement cost at manab zamin, publish car sale advertisement at manab zamin, car sale advertisement at manab zamin, মানবজমিনে গাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  plot purchase advertisement at manab zamin, manab zamin plot purchase advertisement, plot purchase advertisement cost at manab zamin, publish plot purchase advertisement at manab zamin, plot purchase advertisement at manab zamin, মানবজমিনে প্লট ক্রয়ের  বিজ্ঞাপন দিন, 	 wanted advertisement at manab zamin, manab zamin wanted advertisement, wanted advertisement cost at manab zamin, publish wanted advertisement at manab zamin, wanted advertisement at manab zamin, 	 tution wanted advertisement at manab zamin, manab zamin tution wante advertisement, tution wanted advertisement cost at manab zamin, publish tution wanted advertisement at manab zamin, tuiton wanted advertisement at manab zamin, মানবজমিনে  পড়াতে চাই   বিজ্ঞাপন দিন,  groom wanted advertisement at manab zamin, manab zamin groom wanted advertisement, groom wanted advertisement cost at manab zamin, publish groom wanted advertisement at manab zamin, groom wnated advertisement at manab zamin, মানবজমিনে  পাত্র চাই  বিজ্ঞাপন দিন,  bride wanted advertisement at manab zamin, manab zamin plot bride wanted advertisement, bride wanted  advertisement cost at manab zamin, bride wanted purchase advertisement at manab zamin, bride wanted  advertisement at manab zamin, মানবজমিনে  পাত্রী চাই  বিজ্ঞাপন দিন")]
        [SeoTitle("Publish classified advertisement in manab zamin through")]
        [SeoMetaDescription("Through Amader Ad publish your classified advertisement in manab zamin")]
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,                
                PriceDescription = 600,
                ExtraWordPrice = 40,
                WordLimit = 50,
                VAT = 0.15,
                AdLocation = "Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        #endregion

        #region main page
        [SeoMetaKeywords("amader ad ittefaq first page advertisement, ittefaq first page color advertisement, ittefaq 1st page advertisement, ittefaq 1st page color advbertisement, ittefaq 1 number page advertisement, ittefaq one number page color advertisement, publish advertisement at ittefaq first page, advertisement cost at ittefaq first page, ittefaq first page advertisement rate, color advertisement at ittefaq first page")]
        [SeoTitle("Publish color advertisement in ittefaq first page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in ittefaq first page")]
        public ActionResult FirstPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq First Page Color",
                PriceDescription = 14000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq last page advertisement, ittefaq last page color advertisement, ittefaq last page advertisement, publish advertisement at ittefaq last page, advertisement cost at ittefaq last page, ittefaq last page advertisement rate, color advertisement at ittefaq last page")]
        [SeoTitle("Publish color advertisement in ittefaq last page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in ittefaq last page")]
        public ActionResult LastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Last Page Color",
                PriceDescription = 12000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq third page advertisement, ittefaq third page color advertisement, ittefaq 3rd page advertisement, ittefaq 3rd page color advbertisement, ittefaq 3 number page advertisement, ittefaq three number page color advertisement, publish advertisement at ittefaq third page, advertisement cost at ittefaq third page, ittefaq third page advertisement rate, color advertisement at ittefaq third page")]
        [SeoTitle("Publish color advertisement in ittefaq third page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in ittefaq third page")]
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Third Page Color",
                PriceDescription = 9000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq fifth page advertisement, ittefaq fifth page color advertisement, ittefaq 5th page advertisement,  ittefaq 5th page color advbertisement, ittefaq 5 number page advertisement, ittefaq five number page color advertisement, publish advertisement at ittefaq fifth page, advertisement cost at ittefaq fifth page, ittefaq fifth page advertisement rate, color advertisement at ittefaq fifth page")]
        [SeoTitle("Publish color advertisement in ittefaq fifth page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in ittefaq fifth page")]
        public ActionResult FifthPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Fifth Page",
                PriceDescription = 7500,
            
                PriceDescriptionBlack = 5000,
                IsColor = true,
            
        };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad ittefaq fifth page advertisement, ittefaq fifth page black and white advertisement, ittefaq 5th page advertisement, ittefaq 5th page black and white advbertisement, ittefaq 5 number page advertisement, ittefaq five number page black and white advertisement, publish advertisement at ittefaq fifth page, advertisement cost at ittefaq fifth page, ittefaq fifth page advertisement rate, black and white advertisement at ittefaq fifth page")]
        //[SeoTitle("Publish black and white advertisement in ittefaq fifth page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in ittefaq fifth page")]
        //public ActionResult FifthPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Ittefaq",
        //        AdLocation = "Ittefaq Fifth Page Black & White",
        //        PriceDescription = 5000
        //    };
        //    return View(model);
        //}

        [SeoMetaKeywords("amader ad ittefaq second page advertisement, ittefaq second page advertisement, ittefaq 2nd page advertisement, ittefaq 2nd page color advbertisement, ittefaq 2 number page advertisement, ittefaq second number page color advertisement, publish advertisement at ittefaq second page, advertisement cost at ittefaq second page, ittefaq second page advertisement rate, color advertisement at ittefaq second page")]
        [SeoTitle("Publish advertisement in ittefaq second page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your advertisement in ittefaq second page")]
        public ActionResult SecondPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Second Page",
                PriceDescription = 6500,
                PriceDescriptionBlack = 5000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad ittefaq second page advertisement, ittefaq second page black and white advertisement, ittefaq 2nd page advertisement,  ittefaq 2nd page black and white advbertisement, ittefaq 2 number page advertisement, ittefaq second number page black and white advertisement, publish advertisement at ittefaq second page, advertisement cost at ittefaq second page, ittefaq second page black and white advertisement rate, black and white advertisement at ittefaq second page")]
        //[SeoTitle("Publish black and white advertisement in ittefaq second page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in ittefaq second page")]
        //public ActionResult SecondPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Ittefaq",
        //        AdLocation = "Ittefaq Second Page Black & White",
        //        PriceDescription = 6500 //check the price
        //    };
        //    return View(model);
        //}

        [SeoMetaKeywords("amader ad ittefaq nineteenth page advertisement, ittefaq nineteenth page color advertisement, ittefaq 19th page advertisement,  ittefaq 19th page color advbertisement, ittefaq 19 number page advertisement, ittefaq nineteenth number page color advertisement, publish advertisement at ittefaq nineteenth page, advertisement cost at ittefaq nineteenth page, ittefaq nineteenth page advertisement rate, color advertisement at ittefaq nineteenth page, amader ad ittefaq tweentythird page advertisement, ittefaq tweentythird page color advertisement, ittefaq 23th page advertisement,  ittefaq 23th page color advbertisement, ittefaq 23 number page advertisement, ittefaq tweentythird number page color advertisement, publish advertisement at ittefaq tweentythird page, advertisement cost at ittefaq tweentythird page, ittefaq tweentythird page advertisement rate, color advertisement at ittefaq tweentythird page")]
        [SeoTitle("Publish color advertisement in ittefaq nineteenth and tweentythird number page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in ittefaq nineteenth and tweentythird page")]
        public ActionResult NineteenthPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Nineteenth Page",
                PriceDescription = 6000,
                PriceDescriptionBlack = 4500,
                IsColor = true,
            };
            return View(model);
        }

        [SeoMetaKeywords("amader ad ittefaq nineteenth page advertisement, ittefaq nineteenth page color advertisement, ittefaq 19th page advertisement,  ittefaq 19th page color advbertisement, ittefaq 19 number page advertisement, ittefaq nineteenth number page color advertisement, publish advertisement at ittefaq nineteenth page, advertisement cost at ittefaq nineteenth page, ittefaq nineteenth page advertisement rate, color advertisement at ittefaq nineteenth page, amader ad ittefaq tweentythird page advertisement, ittefaq tweentythird page color advertisement, ittefaq 23th page advertisement,  ittefaq 23th page color advbertisement, ittefaq 23 number page advertisement, ittefaq tweentythird number page color advertisement, publish advertisement at ittefaq tweentythird page, advertisement cost at ittefaq tweentythird page, ittefaq tweentythird page advertisement rate, color advertisement at ittefaq tweentythird page")]
        [SeoTitle("Publish color advertisement in ittefaq nineteenth and tweentythird number page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in ittefaq nineteenth and tweentythird page")]
        public ActionResult TwentyThreePage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Tweentythird Page",
                PriceDescription = 6000,
                PriceDescriptionBlack = 4500,
                IsColor = true,
            };
            return View(model);
        }

        //[SeoMetaKeywords("amader ad ittefaq nineteenth page advertisement, ittefaq nineteenth page black and white advertisement, ittefaq 19th page advertisement,  ittefaq 19th page black and white advbertisement, ittefaq 19 number page advertisement, ittefaq nineteenth number page black and white advertisement, publish advertisement at ittefaq nineteenth page, advertisement cost at ittefaq nineteenth page, ittefaq nineteenth page advertisement rate, black and white advertisement at ittefaq nineteenth page, amader ad ittefaq tweentythird page advertisement, ittefaq tweentythird page black and white advertisement, ittefaq 23th page advertisement,  ittefaq 23th page black and white advbertisement, ittefaq 23 number page advertisement, ittefaq tweentythird number page black and white advertisement, publish advertisement at ittefaq tweentythird page, advertisement cost at ittefaq tweentythird page, ittefaq tweentythird page advertisement rate, black and white advertisement at ittefaq tweentythird page")]
        //[SeoTitle("Publish black and white advertisement in ittefaq nineteenth and tweentythird number page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in ittefaq nineteenth and tweentythird page")]

        //public ActionResult Nineteenth_TweentythirdPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Ittefaq",
        //        AdLocation = "Ittefaq Nineteenth & Tweentythird Page Black & White",
        //        PriceDescription = 4500
        //    };
        //    return View(model);
        //}

        [SeoMetaKeywords("amader ad ittefaq sports page advertisement, ittefaq sports page advertisement, ittefaq sports page advertisement, publish advertisement at ittefaq sports page, advertisement cost at ittefaq sports page, ittefaq sports page advertisement rate, color advertisement at ittefaq sports page")]
        [SeoTitle("Publish advertisement in ittefaq sports page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your advertisement in ittefaq sports page")]

        public ActionResult SportsPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Sports Page",
                PriceDescription = 5000,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad ittefaq sports page advertisement, ittefaq sports page black and white advertisement, ittefaq sports page advertisement, publish advertisement at ittefaq sports page, advertisement cost at ittefaq sports page, ittefaq sports page black and white advertisement rate, black and white advertisement at ittefaq sports page")]
        //[SeoTitle("Publish black and white advertisement in ittefaq sports page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in ittefaq sports page")]
        //public ActionResult SportsPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Ittefaq",
        //        AdLocation = "Ittefaq Sports Page Black & White",
        //        PriceDescription = 4000 //check the price
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad ittefaq middle two page advertisement, ittefaq middle two page color advertisement, ittefaq middle two page advertisement, publish advertisement at ittefaq middle two page, advertisement cost at ittefaq middle two page, ittefaq middle two page advertisement rate, color advertisement at ittefaq middle two page")]
        [SeoTitle("Publish color advertisement in ittefaq middle two page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in ittefaq middle two page")]
        public ActionResult MiddleTwoPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Middle Two Page",
                PriceDescription = 4500,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad ittefaq inner page black and white advertisement, ittefaq inner page black and white advertisement,black and white advertisememnt at ittefaq inner page, ittefaq inner page black and white advertisement cost,publish black and white advertisement at ittefaq inner page, ittefaq inner page black and white advertisement rate")]
        //[SeoTitle("Publish black and white advertisement in ittefaq inner page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in ittefaq inner page")]
        //public ActionResult InnerPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Ittefaq",
        //        AdLocation = "Ittefaq Inner Page Black & White",
        //        PriceDescription = 3000 //check the price
        //    };
        //    return View(model);
        //}

        [SeoMetaKeywords("amader ad inquilab inner page color advertisement, inquilab inner page color advertisement,color advertisememnt at inquilab inner page, inquilab inner page color advertisement cost,publish color advertisement at inquilab inner page, inquilab inner page color advertisement rate")]
        [SeoTitle("Publish color advertisement in inquilab inner page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in inquilab inner page")]
        public ActionResult InnerPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Inner Page",
                PriceDescription = 4000,
                PriceDescriptionBlack = 3000,
                IsColor = true,
            };
            return View(model);
        }
        #endregion


        #region  Thatta
        [SeoMetaKeywords("amader ad ittefaq thatta last page advertisement,ittefaq thatta ad, thatta last page advertisement, ittefaq thatta last page color advertisement, ittefaq thatta last page ad,  ittefaq thatta last page color advertisement,  publish advertisement at ittefaq thatta last page, advertisement cost at ittefaq thatta last  page, ittefaq thatta last page advertisement rate, color advertisement at ittefaq thatta last page")]
        [SeoTitle("Publish advertisement in thatta last cover page of ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in thatta last page at ittefaq")]
        public ActionResult LastCoverPageColorAdvertisement_Thatta()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Thatta Last cover page(full page) Advertisement",
                PriceDescription = 40000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq thatta second page advertisement,ittefaq thatta ad, thatta second page advertisement, ittefaq thatta second page color advertisement, ittefaq thatta second page ad,  ittefaq thatta second page color advertisement,  publish advertisement at ittefaq thatta second page, advertisement cost at ittefaq thatta second  page, ittefaq thatta second page advertisement rate, color advertisement at ittefaq thatta second page")]
        [SeoTitle("Publish advertisement in thatta second cover page of ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in thatta second page at ittefaq")]
        public ActionResult SecondCoverPageColorAdvertisement_Thatta()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Thatta Second cover page(full page) Advertisement",
                PriceDescription = 30000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq thatta third page advertisement,ittefaq thatta ad, thatta third page advertisement, ittefaq thatta third page color advertisement, ittefaq thatta third page ad,  ittefaq thatta third page color advertisement,  publish advertisement at ittefaq thatta third page, advertisement cost at ittefaq thatta third  page, ittefaq thatta third page advertisement rate, color advertisement at ittefaq thatta third page")]
        [SeoTitle("Publish advertisement in thatta third cover page of ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in thatta third page at ittefaq")]
        public ActionResult ThirdCoverPageColorAdvertisement_Thatta()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Thatta Third cover page(full page) Advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq thatta inner page advertisement,ittefaq thatta ad, thatta inner page advertisement, ittefaq thatta inner page color advertisement, ittefaq thatta inner page ad,  ittefaq thatta inner page color advertisement,  publish advertisement at ittefaq thatta inner page, advertisement cost at ittefaq thatta inner page, ittefaq thatta inner page advertisement rate, color advertisement at ittefaq thatta inner page")]
        [SeoTitle("Publish advertisement in thatta inner page of ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in thatta inner page at ittefaq")]
        public ActionResult InnerPageColorAdvertisement_Thatta()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Thatta Inner Page(full page) Advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }

        [SeoMetaKeywords("amader ad ittefaq thatta inner two page advertisement,ittefaq thatta ad, thatta inner two page advertisement, ittefaq thatta inner two page color advertisement, ittefaq thatta inner two page ad,  ittefaq thatta inner two page color advertisement,  publish advertisement at ittefaq thatta inner two page, advertisement cost at ittefaq thatta inner two  page, ittefaq thatta inner two page advertisement rate, color advertisement at ittefaq thatta inner two page")]
        [SeoTitle("Publish advertisement in thatta inner two page of ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in thatta inner two page at ittefaq")]

        public ActionResult InnerTwoPageColorAdvertisement_Thatta()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Thatta Inner Two Page(full page) Advertisement",
                PriceDescription = 35000
            };
            return View(model);
        }



        #endregion

        #region projonmo
        [SeoMetaKeywords("amader ad ittefaq projonmo first page advertisement,ittefaq projonmo ad, projonmo first page advertisement, ittefaq projonmo first page color advertisement, ittefaq projonmo first page ad,  ittefaq projonmo first page color advertisement,  publish advertisement at ittefaq projonmo first page, advertisement cost at ittefaq projonmo first  page, ittefaq projonmo first page advertisement rate, color advertisement at ittefaq projonmo first page")]
        [SeoTitle("Publish color advertisement in projonmo first page at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in projonmo first page at ittefaq")]
        public ActionResult FirstPageColorAdvertisement_Projonmo()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Projonmo First Page Advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq projonmo kochi kachar asor last page advertisement,ittefaq projonmo kochi kachar asor ad, projonmo kochi kachar asor last page advertisement, ittefaq projonmo kochi kachar asor last page color advertisement, ittefaq projonmo last page ad,  ittefaq projonmo last page color advertisement,  publish advertisement at ittefaq projonmo last page, advertisement cost at ittefaq projonmo last  page, ittefaq projonmo last page advertisement rate, color advertisement at ittefaq projonmo last page, kochi kachar asor")]
        [SeoTitle("Publish advertisement in kochi kachar asor section at last page of projonmo of ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in projonmo kochi kachar asor last page at ittefaq")]
        public ActionResult LastPageColorAdvertisement_Projonmo()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Projonmo Last Page Advertisement( kochi kachar ashor)",
                PriceDescription = 3000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq projonmo inner page advertisement,ittefaq projonmo ad, projonmo inner page advertisement, ittefaq projonmo inner page color advertisement, ittefaq projonmo inner page ad,  ittefaq projonmo inner page color advertisement,  publish advertisement at ittefaq projonmo inner page, advertisement cost at ittefaq projonmo inner page, ittefaq projonmo inner page advertisement rate, color advertisement at ittefaq projonmo inner page")]
        [SeoTitle("Publish color advertisement in projonmo inner page at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in projonmo inner page at ittefaq")]
        public ActionResult InnerPageColorAdvertisement_Projonmo()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Projonmo Inner Page Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }

        #endregion

        #region korcha
        [SeoMetaKeywords("amader ad ittefaq korcha first page advertisement,ittefaq korcha ad, korcha first page advertisement, ittefaq korcha first page color advertisement, ittefaq korcha first page ad,  ittefaq korcha first page color advertisement,  publish advertisement at ittefaq korcha first page, advertisement cost at ittefaq korcha first  page, ittefaq korcha first page advertisement rate, color advertisement at ittefaq korcha first page")]
        [SeoTitle("Publish color advertisement in korcha first page at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in korcha first page at ittefaq")]
        public ActionResult FirstPageColorAdvertisement_Korcha()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Korcha First Page Advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq korcha last page advertisement,ittefaq korcha ad, korcha last page advertisement, ittefaq korcha last page color advertisement, ittefaq korcha last page ad,  ittefaq korcha last page color advertisement,  publish advertisement at ittefaq korcha last page, advertisement cost at ittefaq korcha last  page, ittefaq korcha last page advertisement rate, color advertisement at ittefaq korcha last page")]
        [SeoTitle("Publish color advertisement in korcha last page at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in korcha last page at ittefaq")]
        public ActionResult LastPageColorAdvertisement_Korcha()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Korcha Last Page Advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq korcha inner page advertisement,ittefaq korcha ad, korcha inner page advertisement, ittefaq korcha inner page color advertisement, ittefaq korcha inner page ad,  ittefaq korcha inner page color advertisement,  publish advertisement at ittefaq korcha inner page, advertisement cost at ittefaq korcha inner  page, ittefaq korcha inner page advertisement rate, color advertisement at ittefaq korcha inner page")]
        [SeoTitle("Publish color advertisement in korcha inner page at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in korcha inner page at ittefaq")]
        public ActionResult InnerPage_Korcha()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Korcha Inner Page Advertisement",
                PriceDescription = 3000,
                PriceDescriptionBlack = 2500,
                IsColor = true,      
             };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad ittefaq korcha inner page advertisement,ittefaq korcha ad, korcha inner page advertisement, ittefaq korcha inner page black and white advertisement, ittefaq korcha inner page ad,  ittefaq korcha inner page black and white advertisement,  publish advertisement at ittefaq korcha inner page, advertisement cost at ittefaq korcha inner  page, ittefaq korcha inner page black and white advertisement rate, black and white advertisement at ittefaq korcha inner page")]
        //[SeoTitle("Publish black and white advertisement in korcha inner page at ittefaq through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in korcha inner page at ittefaq")]
        //public ActionResult InnerPageBlackWhiteAdvertisement_Korcha()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Ittefaq",
        //        AdLocation = "Ittefaq Korcha InnerPage Black & White Advertisement",
        //        PriceDescription = 2500
        //    };
        //    return View(model);
        //}

        #endregion

        #region Campus
        [SeoMetaKeywords("amader ad ittefaq campus campus first page advertisement,ittefaq campus first ad, ittefaq campus first page advertisement, ittefaq campus campus first page color advertisement, ittefaq campus campus first page ad,  ittefaq campus campus first page color advertisement,  publish advertisement at ittefaq campus campus first page, advertisement cost at ittefaq campus campus first page, ittefaq campus campus first page advertisement rate, color advertisement at ittefaq campus campus first page")]
        [SeoTitle("Publish color advertisement in campus first page at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in campus campus first page at ittefaq")]
        public ActionResult FirstPageColorAdvertisement_Campus()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Campus First Page Advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq campus inner page advertisement, ittefaq campus inner page advertisement,  ittefaq campus inner page ad,  ittefaq campus inner page color advertisement,  publish advertisement at ittefaq campus inner page, advertisement cost at ittefaq campus inner  page, ittefaq campus inner page advertisement rate, color advertisement at ittefaq campus inner page")]
        [SeoTitle("Publish color advertisement in campus inner page at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in campus inner page at ittefaq")]
        public ActionResult InnerPageColorAdvertisement_Campus()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Campus Inner Color Page Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq campus information technology page advertisement,ittefaq information technology ad, ittefaq information technology page advertisement, ittefaq campus information technology page color advertisement, ittefaq campus information technology page ad,  ittefaq campus information technology page color advertisement,  publish advertisement at ittefaq campus information technology page, advertisement cost at ittefaq campus information technology  page, ittefaq campus information technology page advertisement rate, color advertisement at ittefaq campus information technology page")]
        [SeoTitle("Publish color advertisement in information and technology page of campus at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in campus information technology page at ittefaq")]
        public ActionResult ITPageColorAdvertisement_Campus()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Campus IT Color Page Advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq campus career page advertisement,ittefaq career ad, ittefaq career page advertisement, ittefaq campus career page color advertisement, ittefaq campus career page ad,  ittefaq campus career page color advertisement,  publish advertisement at ittefaq campus career page, advertisement cost at ittefaq campus career  page, ittefaq campus career page advertisement rate, color advertisement at ittefaq campus career page")]
        [SeoTitle("Publish color advertisement in campus and career page at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in campus and career page at ittefaq")]
        public ActionResult CareerPageColorAdvertisement_Campus()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Campus Career Color Page Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        #endregion

        #region Anondo binodon
        [SeoMetaKeywords("amader ad ittefaq annondo binodon first page advertisement,ittefaq annondo binodon first page ad, annondo binodon first page advertisement, ittefaq annondo binodon first page color advertisement, ittefaq annondo binodon first page ad,  ittefaq annondo binodon first page color advertisement,  publish advertisement at ittefaq annondo binodon first page, advertisement cost at ittefaq annondo binodon first page, ittefaq annondo binodon first page advertisement rate, color advertisement at ittefaq annondo binodon first page")]
        [SeoTitle("Publish Color advertisement in first page of annondo binodon at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in annondo binodon first page at ittefaq")]
        public ActionResult FirstPageColorAdvertisement_AnondoBinodon()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Anondo Binodon Color First Page Advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq annondo binodon inner page advertisement,ittefaq annondo binodon inner page ad, annondo binodon inner page advertisement, ittefaq annondo binodon inner page color advertisement, ittefaq annondo binodon inner page ad,  ittefaq annondo binodon inner page color advertisement,  publish advertisement at ittefaq annondo binodon inner page, advertisement cost at ittefaq annondo binodon inner page, ittefaq annondo binodon inner page advertisement rate, color advertisement at ittefaq annondo binodon inner page")]
        [SeoTitle("Publish Color advertisement in inner page of annondo binodon at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in annondo binodon inner page at ittefaq")]
        public ActionResult InnerPageColorAdvertisement_AnondoBinodon()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Anondo Binodon Color Inner Page Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq annondo binodon last page advertisement,ittefaq annondo binodon last page ad, annondo binodon last page advertisement, ittefaq annondo binodon last page color advertisement, ittefaq annondo binodon last page ad,  ittefaq annondo binodon last page color advertisement,  publish advertisement at ittefaq annondo binodon last page, advertisement cost at ittefaq annondo binodon last page, ittefaq annondo binodon last page advertisement rate, color advertisement at ittefaq annondo binodon last page")]
        [SeoTitle("Publish Color advertisement in last page of annondo binodon at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in annondo binodon last page at ittefaq")]
        public ActionResult LastPageColorAdvertisement_AnondoBinodon()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Anondo Binodon Color Last Page Advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }

        #endregion

        #region Shaitto shamoiki
        [SeoMetaKeywords("amader ad ittefaq shahitto shamoiki first page advertisement,ittefaq shahitto shamoiki ad, shahitto shamoiki first page advertisement, ittefaq shahitto shamoiki first page color advertisement, ittefaq shahitto shamoiki first page ad,  ittefaq shahitto shamoiki first page color advertisement,  publish advertisement at ittefaq shahitto shamoiki first page, advertisement cost at ittefaq shahitto shamoiki first page, ittefaq shahitto shamoiki first page advertisement rate, color advertisement at ittefaq shahitto shamoiki first page")]
        [SeoTitle("Publish Color advertisement in first page of Shahitto Shamoiki at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in shahitto shamoiki first page at ittefaq")]
        public ActionResult FirstPageColorAdvertisement_Shaitto()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Shahitto shamoiki Color First Page Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq shahitto shamoiki last page advertisement,ittefaq shahitto shamoiki ad, shahitto shamoiki last page advertisement, ittefaq shahitto shamoiki last page color advertisement, ittefaq shahitto shamoiki last page ad,  ittefaq shahitto shamoiki last page color advertisement,  publish advertisement at ittefaq shahitto shamoiki last page, advertisement cost at ittefaq shahitto shamoiki last page, ittefaq shahitto shamoiki last page advertisement rate, color advertisement at ittefaq shahitto shamoiki last page")]
        [SeoTitle("Publish Color advertisement in last page of Shahitto Shamoiki at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in shahitto shamoiki last page at ittefaq")]
        public ActionResult LastPageColorAdvertisement_Shaitto()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Shahitto shamoiki Color Last Page Advertisement",
                PriceDescription = 2000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq shahitto shamoiki inner page advertisement,ittefaq shahitto shamoiki ad, shahitto shamoiki inner page advertisement, ittefaq shahitto shamoiki inner page color advertisement, ittefaq shahitto shamoiki inner page ad,  ittefaq shahitto shamoiki inner page color advertisement,  publish advertisement at ittefaq shahitto shamoiki inner page, advertisement cost at ittefaq shahitto shamoiki inner page, ittefaq shahitto shamoiki inner page advertisement rate, color advertisement at ittefaq shahitto shamoiki inner page")]
        [SeoTitle("Publish Color advertisement in inner page of Shahitto Shamoiki at ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in shahitto shamoiki inner page at ittefaq")]
        public ActionResult InnerPageColorAdvertisement_Shaitto()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Shahitto shamoiki Inner Page Advertisement",
                PriceDescription = 1600
            };
            return View(model);
        }
        #endregion

        #region spot panel ad
        [SeoMetaKeywords("amader ad ittefaq first page spot advertisement, ittefaq first page spot advertisement, publish spot advertisement at ittefaq first page,spot advertisement cost at ittefaq first page, ittefaq first page spot advertisement rate, spot advertisement at ittefaq first page")]
        [SeoTitle("Publish spot advertisement in ittefaq first page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in ittefaq first page")]
        public ActionResult FirstPageColorAdvertisement_SpotPanel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq First Page Spot Advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq last page spot advertisement, ittefaq last page spot advertisement, publish spot advertisement at ittefaq last page,spot advertisement cost at ittefaq last page, ittefaq last page spot advertisement rate, spot advertisement at ittefaq last page")]
        [SeoTitle("Publish spot advertisement in ittefaq last page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in ittefaq last page")]
        public ActionResult LastPageColorAdvertisement_SpotPanel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Last Page Spot Advertisement",
                PriceDescription = 15000
            };
            return View(model);
        }
        #endregion

        #region panel

        

    
        [SeoMetaKeywords("amader ad ittefaq last page panel advertisement, ittefaq last page panel advertisement,  publish panel  advertisement at ittefaq last page,last page panel advertisement cost at ittefaq, ittefaq last page panel advertisement rate, advertisement at ittefaq last page panel")]
        [SeoTitle("Publish last page panel  advertisement in ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish last page panel advertisement in ittefaq")]
        public ActionResult LastPageColorAdvertisement_Panel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Last Page Panel Advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad ittefaq inner page panel advertisement, ittefaq inner page panel advertisement,  publish panel  advertisement at ittefaq inner page,inner page panel advertisement cost at ittefaq, ittefaq inner page panel advertisement rate, advertisement at ittefaq inner page panel")]
        [SeoTitle("Publish inner page panel  advertisement in ittefaq through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish inner page panel advertisement in ittefaq")]
        public ActionResult InnerPageColorAdvertisement_Panel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Inner Page Panel Advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }

        #endregion
        #region birthday
        public ActionResult OthersFixed()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "নিঁখোজ, জন্মদিন, বৃত্তিপ্রাপ্তি উপলক্ষে",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 1500,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "2.00",
                InchFloat = "1.00",
                // AllAdCategory = GetAllAdCategory()
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
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Govt. Advertisement",
                TitleDescription = "Govt. Advertisement At Ittefaq",
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
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq- Govt. Commercial Advertisement",
                TitleDescription = "Govt. Commercial Advertisement At Ittefaq",
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