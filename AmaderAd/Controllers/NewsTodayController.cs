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
    [SeoBaseTitle("Publish advertisement in news today through amader ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/NewsToday")]
    public class NewsTodayController : BaseController
    {
        // GET: NewsToday
        public ActionResult Index()
        {
            return View();
        }
        #region classified advertisement
        [SeoMetaKeywords("amader ad news today classified advertisement,news today classified ad, news today classified advertisement,  publish classied advertisement at news today , classified advertisement cost at news today, news today classified advertisement rate, classified advertisement at news today, নিউজ টুডে  শ্রেণীভুক্ত বিজ্ঞাপন দিন,  rent at news today,  house rent at news today, publish rent advertisement at news today, news today rent advertisement, নিউজ টুডে বাড়ি ভাড়া বিজ্ঞাপন,  land slae advertisement at news today, news today land sale advertisement, news today land sale ad cost, নিউজ টুডে জমি বিক্রয়ের বিজ্ঞাপন দিন,  miscellaneous sales advertisement at news today, news today miscellaneous slaes advetisement,  miscellaneous sales cost at news today, publish miscellaneous advertisement at news today, miscellaneous at news today, নিউজ টুডে বিবিধ বিক্রয়ের বিজ্ঞাপন দিন, house sale advertisement at news today, news today house sales advertisement, house sales advertisement cost at news today, publish house sale advertisement at news today, house sale advertisement at news today, নিউজ টুডে বাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  shop sale advertisement at news today, news today shop sales advertisement, shop sales advertisement cost at news today, publish shop sale advertisement at news today, house shop advertisement at news today, নিউজ টুডে দোকান বিক্রয়ের বিজ্ঞাপন দিন,     car sale advertisement at news today, news today car sales advertisement, car sales advertisement cost at news today, publish car sale advertisement at news today, car sale advertisement at news today, নিউজ টুডে গাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  plot purchase advertisement at news today, news today plot purchase advertisement, plot purchase advertisement cost at news today, publish plot purchase advertisement at news today, plot purchase advertisement at news today, নিউজ টুডে প্লট ক্রয়ের  বিজ্ঞাপন দিন, wanted advertisement at news today, news today wanted advertisement, wanted advertisement cost at news today, publish wanted advertisement at news today, wanted advertisement at news today, tution wanted advertisement at news today, news today tution wante advertisement, tution wanted advertisement cost at news today, publish tution wanted advertisement at news today, tuiton wanted advertisement at news today, নিউজ টুডে  পড়াতে চাই   বিজ্ঞাপন দিন,  groom wanted advertisement at news today, news today groom wanted advertisement, groom wanted advertisement cost at news today, publish groom wanted advertisement at news today, groom wnated advertisement at news today, নিউজ টুডে  পাত্র চাই  বিজ্ঞাপন দিন,  bride wanted advertisement at news today, news today plot bride wanted advertisement, bride wanted  advertisement cost at news today, bride wanted purchase advertisement at news today, bride wanted  advertisement at news today, নিউজ টুডে পাত্রী চাই  বিজ্ঞাপন দিন")]
        [SeoTitle("Publish classified advertisement in news today through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your classified advertisement news today")]

        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today Classified Advertisement",


                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,
                PriceDescription = 800,
                ExtraWordPrice = 40,
                WordLimit = 60,
                VAT = 0.15,
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        #endregion
        #region MainPag
        [SeoMetaKeywords("amader ad news today front page advertisement, news today front page advertisement, news today 1st page advertisement,  news today 1st page advbertisement, news today 1 number page advertisement, news today one number page color advertisement, publish advertisement at news today first page, advertisement cost at news today front page, news today front page advertisement rate, color advertisement at news today front page")]
        [SeoTitle("Publish advertisement in News Today front page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in news today front page")]
        public ActionResult FrontPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today front page advertisement",
                PriceDescription = 9500,
                PriceDescriptionBlack = 6000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad news today front page advertisement, news today front page black and white advertisement, news today 1st page advertisement,  news today 1st page black and white advbertisement, news today 1 number page advertisement, news today one number page black and white advertisement, publish advertisement at news today first page, advertisement cost at news today front page, news today front page advertisement rate, black and white advertisement at news today front page")]
        //[SeoTitle("Publish black and white advertisement in News Today front page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in news today front page")]
        //public ActionResult FrontPageBlackWhitAadvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "News Today",
        //        AdLocation = "News Today front page black and white advertisement",
        //        PriceDescription = 6000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad news today back page advertisement, news today back  page advertisement, news today back page advertisement,  news today back page advbertisement, publish advertisement at news today back page, advertisement cost at news today last page, news today back page advertisement rate, color advertisement at news today back page")]
        [SeoTitle("Publish advertisement in News Today back page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your advertisement in news today back page")]
        public ActionResult BackPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today back page advertisement",
                PriceDescription = 8000,
                PriceDescriptionBlack = 5000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad news today backpage advertisement, news today backpage black and white advertisement, news today backpage advertisement,  news today backpage black and white advbertisement, publish advertisement at news today back page, advertisement cost at news today backpage, news today back page advertisement rate, black and white advertisement at news today back page")]
        //[SeoTitle("Publish black and white advertisement in News Today back page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in news today backpage")]
        //public ActionResult BackPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "News Today",
        //        AdLocation = "News Today back page black and white advertisement",
        //        PriceDescription = 5000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad news today third page advertisement, news today third page advertisement, news today 3rd page advertisement,  news today 3rd page advbertisement, news today 3 number page advertisement, news today three number page color advertisement, publish advertisement at news today third page, advertisement cost at news today third page, news today third page advertisement rate, color advertisement at news today third page")]
        [SeoTitle("Publish advertisement in News Today third page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your advertisement in news today third page")]
        public ActionResult ThirdPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today third page advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad news today third page advertisement, news today third page black and white advertisement, news today 3rd page advertisement,  news today 3rd page black and white advbertisement, news today 3 number page advertisement, news today three number page black and white advertisement, publish advertisement at news today third page, advertisement cost at news today third page, news today third page advertisement rate, black and white advertisement at news today third page")]
        //[SeoTitle("Publish black and white advertisement in News Today third page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in news today third page")]
        //public ActionResult ThirdPageBlacWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "News Today",
        //        AdLocation = "News Today third page black and white advertisement",
        //        PriceDescription = 3000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad news today inner page advertisement, news today inner page advertisement, news today inner page advertisement, publish advertisement at news today inner  page, advertisement cost at news today inside page, news today inner page advertisement rate, color advertisement at news today inner page")]
        [SeoTitle("Publish advertisement in News Today inner page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your advertisement in news today inner page")]
        public ActionResult InnerPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today inner page advertisement",
                PriceDescription = 3500,
                PriceDescriptionBlack = 2500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad news today inner page advertisement, news today inner page black and white advertisement, news today inner page advertisement, publish advertisement at news today inner  page, advertisement cost at news today inside page, news today inner page advertisement rate, black and white advertisement at news today inner page")]
        //[SeoTitle("Publish black and white advertisement in News Today inner page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in news today inner page")]
        //public ActionResult InnerPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "News Today",
        //        AdLocation = "News Today inner page black and white advertisement",
        //        PriceDescription = 2500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords(" news today different categories advertisement,news today different categories advertisment rate,advertisement cost at news today different categorie page,advertisemnt in news today different categorie page")]
        [SeoTitle("Publish different categories advertisement in manab zamin through")]
        [SeoMetaDescription("Through Amader Ad publish your different categories advertisement in news today")]
        public ActionResult DifferentCat_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today different categories page advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad news today career opportunity and vacancy page advertisement, news today career opportunity and vacancy page black and white advertisement, news today career opportunity and vacancy page advertisement, publish advertisement at news today career opportunity and vacancy page, advertisement cost at news today career opportunity and vacancy page, news today career opportunity and vacancy page advertisement rate, black and white advertisement at news today career opportunity and vacancy page")]
        [SeoTitle("Publish career opportunity and vacancy in News Today through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in news today career opportunity and vacancy page")]
        public ActionResult Career_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News today career opportunity vacancy black and white advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad news today birthday to-let purchase sale tution qulkhani lost and found wanted scholarship coaching center renion exhibition academic feat fashion show cultural pogramme page advertisement, news today birthday to-let purchase sale tution qulkhani lost and found wanted scholarship coaching center renion exhibition academic feat fashion show cultural pogramme page color advertisement, news today birthday to-let purchase sale tution qulkhani lost and found wanted scholarship coaching center renion exhibition academic feat fashion show cultural pogramme page advertisement, publish advertisement at news today birthday to-let purchase sale tution qulkhani lost and found wanted scholarship coaching center renion exhibition academic feat fashion show cultural pogramme page, advertisement cost at news today birthday to-let purchase sale tution qulkhani lost and found wanted scholarship coaching center renion exhibition academic feat fashion show cultural pogramme page, news today birthday to-let purchase sale tution qulkhani lost and found wanted scholarship coaching center renion exhibition academic feat fashion show cultural pogramme page advertisement rate, color advertisement at news today birthday to-let purchase sale tution qulkhani lost and found wanted scholarship coaching center renion exhibition academic feat fashion show cultural pogramme page")]
        [SeoTitle("Publish birthday to-let purchase sale tution qulkhani lost and found wanted scholarship coaching center renion exhibition academic feat fashion show cultural pogramme in News Today through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your advertisement in news today birthday to-let purchase sale tution qulkhani lost and found wanted scholarship coaching center renion exhibition academic feat fashion show cultural pogramme page")]
        public ActionResult BirthdayTolet_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today birthday tolet purchase sale tution qulkhani lost and found wanted scholarship coaching center reunion exibition academic feat fashion show cultural programme",
                PriceDescription = 1000
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
                NewspaperName = "News Today",
                AdLocation = "News Today Govt. Advertisement",
                TitleDescription = "Govt. Advertisement At News Today",
                PriceDescription = 452,

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
                NewspaperName = "News Today",
                AdLocation = "News Today- Govt. Commercial Advertisement",
                TitleDescription = "Govt. Commercial Advertisement At News Today",
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