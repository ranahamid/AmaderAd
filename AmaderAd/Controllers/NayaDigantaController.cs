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
    [SeoBaseTitle("Publish advertisement in Naya Diganta through amader ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/NayaDiganta")]
    public class NayaDigantaController : BaseController
    {
        // GET: NayaDiganta
        public ActionResult Index()
        {
            return View();
        }
        #region  classified advertisement
        [SeoMetaKeywords("amader ad naya diganta  classified advertisement,naya diganta classified ad, naya diganta classified advertisement, publish classied advertisement at naya diganta, classified advertisement cost at naya diganta , naya diganta  classified advertisement rate, classified advertisement at naya diganta, নয়া দিগন্তে  শ্রেণীভুক্ত বিজ্ঞাপন দিন,  rent at naya diganta,  house rent at naya diganta, publish rent advertisement at naya diganta, naya diganta  rent advertisement, নয়া দিগন্ত বাড়ি ভাড়া বিজ্ঞাপন,  land slae advertisement at naya diganta, naya diganta  land sale advertisement, naya diganta  land sale ad cost, নয়া দিগন্তে জমি বিক্রয়ের বিজ্ঞাপন দিন,  miscellaneous sales advertisement at naya diganta, naya diganta  miscellaneous slaes advetisement, miscellaneous sales cost at naya diganta, publish miscellaneous advertisement at naya diganta , miscellaneous at naya diganta, নয়া দিগন্তে বিবিধ বিক্রয়ের বিজ্ঞাপন দিন, house sale advertisement at naya diganta, naya diganta house sales advertisement, house sales advertisement cost at naya diganta, publish house sale advertisement at naya diganta, house sale advertisement at naya diganta, নয়া দিগন্তে বাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  shop sale advertisement at naya diganta, naya diganta  shop sales advertisement, shop sales advertisement cost at naya diganta, publish shop sale advertisement at naya diganta, house shop advertisement at naya diganta, নয়া দিগন্তে দোকান বিক্রয়ের বিজ্ঞাপন দিন, car sale advertisement at naya diganta, naya diganta  car sales advertisement, car sales advertisement cost at naya diganta, publish car sale advertisement at naya diganta, car sale advertisement at naya diganta, নয়া দিগন্তে গাড়ি বিক্রয়ের বিজ্ঞাপন দিন, plot purchase advertisement at naya diganta , naya diganta  plot purchase advertisement, plot purchase advertisement cost at naya diganta, publish plot purchase advertisement at naya diganta, plot purchase advertisement at naya diganta, নয়া দিগন্তে প্লট ক্রয়ের  বিজ্ঞাপন দিন,  wanted advertisement at naya diganta, naya diganta  wanted advertisement, wanted advertisement cost at naya diganta, publish wanted advertisement at naya diganta, wanted advertisement at naya diganta, tution wanted advertisement at naya diganta, naya diganta  tution wante advertisement, tution wanted advertisement cost at naya diganta, publish tution wanted advertisement at naya diganta, tuiton wanted advertisement at naya diganta, নয়া দিগন্তে  পড়াতে চাই   বিজ্ঞাপন দিন,  groom wanted advertisement at naya diganta, naya diganta groom wanted advertisement, groom wanted advertisement cost at naya diganta, publish groom wanted advertisement at naya diganta, groom wnated advertisement at naya diganta, নয়া দিগন্তে  পাত্র চাই  বিজ্ঞাপন দিন, bride wanted advertisement at naya diganta, naya diganta  plot bride wanted advertisement, bride wanted  advertisement cost at naya diganta, bride wanted purchase advertisement at naya diganta, bride wanted  advertisement at naya diganta, নয়া দিগন্তে  পাত্রী চাই  বিজ্ঞাপন দিন,")]
        [SeoTitle("Publish classified advertisement in naya diganta  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your classified advertisement naya diganta")]
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",     
                AdLocation = "Naya Diganta Classified Advertisement",

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
      
        #region  MainPage
        [SeoMetaKeywords("amader ad naya diganta general display advertisement, naya diganta general display advertisement, publish general display advertisement in naya diganta , general display advertisement cost at naya diganta , naya diganta general display advertisement rate, general display advertisement at naya diganta")]
        [SeoTitle("Publish general display advertisement in naya diganta through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your general advertisement in naya diganta")]
        public ActionResult GeneralDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta general display advertisement.",
                PriceDescription = 3500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad naya diganta first page advertisement, naya diganta first page color advertisement, naya diganta 1st page advertisement,  naya diganta 1st page color advbertisement, naya diganta 1 number page advertisement, naya diganta one number page color advertisement, publish advertisement at naya diganta first page, advertisement cost at naya diganta first page, naya diganta first page advertisement rate, color advertisement at naya diganta first page")]
        [SeoTitle("Publish color advertisement in naya diganta first page thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta first page")]
        public ActionResult FirstPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta first page color advertisement.",
                PriceDescription = 15000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad naya diganta second page advertisement, naya diganta second page black and white advertisement, naya diganta 2nd page advertisement,  naya diganta 2nd page black and white advbertisement, naya diganta 2 number page advertisement, naya diganta second number page black and white advertisement, publish advertisement at naya diganta second page, advertisement cost at naya diganta second page, naya diganta second page advertisement rate, black and white advertisement at naya diganta second page")]
        [SeoTitle("Publish black and white advertisement in naya diganta second page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta second page")]
        public ActionResult SecondPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta second page black and white advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad naya diganta last page advertisement, naya diganta last page advertisement, naya diganta last page advertisement, publish advertisement at naya diganta last  page, advertisement cost at naya diganta last page, naya diganta last page advertisement rate, color advertisement at naya diganta last page")]
        [SeoTitle("Publish advertisement in naya diganta last page thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your advertisement in naya diganta last page")]
        public ActionResult LastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta last page advertisement.",
                PriceDescription = 12500,
                PriceDescriptionBlack = 10000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta last page advertisement, naya diganta last page black and white advertisement, naya diganta last page advertisement, publish advertisement at naya diganta last  page, advertisement cost at naya diganta last page, naya diganta last page advertisement rate, black and white advertisement at naya diganta last page")]
        //[SeoTitle("Publish black and white advertisement in naya diganta last page thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta last page")]
        //public ActionResult LastPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta last page black and white advertisement.",
        //        PriceDescription = 10000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta third page advertisement, naya diganta third page color advertisement, naya diganta 3rd page advertisement,  naya diganta 3rd page color advbertisement, naya diganta 3 number page advertisement, naya diganta three number page color advertisement, publish advertisement at naya diganta third page, advertisement cost at naya diganta third page, naya diganta third page advertisement rate, color advertisement at naya diganta third page")]
        [SeoTitle("Publish color advertisement in naya diganta third page thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta third page")]
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "naya Diganta third page color advertisement.",
                PriceDescription = 10000,
                PriceDescriptionBlack = 7500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta third page advertisement, naya diganta third page black and white advertisement, naya diganta 3rd page advertisement,  naya diganta 3rd page black and white advbertisement, naya diganta 3 number page advertisement, naya diganta three number page black and white advertisement, publish advertisement at naya diganta third page, advertisement cost at naya diganta third page, naya diganta third page advertisement rate, black and white advertisement at naya diganta third page")]
        //[SeoTitle("Publish black and white advertisement in naya diganta third page thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta third page")]
        //public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta third page black and white advertisement.",
        //        PriceDescription = 7500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad Naya Diganta fifth page advertisement, Naya Diganta fifth page color advertisement, Naya Diganta 5th page advertisement, Naya Diganta 5th page color advbertisement, Naya Diganta 5 number page advertisement, Naya Diganta five number page color advertisement, publish advertisement at Naya Diganta fifth page, advertisement cost at Naya Diganta fifth page, Naya Diganta fifth page advertisement rate, color advertisement at Naya Diganta fifth page")]
        [SeoTitle("Publish color advertisement in Naya Diganta   fifth page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in Naya Diganta fifth page")]
        public ActionResult FifthPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta fifth page color advertisement.",
                PriceDescription = 7000,
                PriceDescriptionBlack = 5000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta fifth page advertisement, naya diganta fifth page black and white advertisement, naya diganta 5th page advertisement, naya diganta 5th page black and white advbertisement, naya diganta 5 number page advertisement, naya diganta five number page black and white advertisement, publish advertisement at naya diganta fifth page, advertisement cost at naya diganta fifth page, naya diganta fifth page advertisement rate, black and white advertisement at naya diganta fifth page")]
        //[SeoTitle("Publish black and white advertisement in naya diganta   fifth page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta fifth page")]
        //public ActionResult FifthPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta fifth page black and white advertisement.",
        //        PriceDescription = 5000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta business page advertisement, naya diganta business page color advertisement, publish advertisement at naya diganta business page, advertisement cost at naya diganta business page, naya diganta business page advertisement rate, color advertisement at naya diganta businness page")]
        [SeoTitle("Publish color advertisement in business page at naya diganta thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta business and page")]
        public ActionResult BusinessPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta business page color advertisement.",
                PriceDescription = 5000,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta business page advertisement, naya diganta business page black and white advertisement, publish advertisement at naya diganta business page, advertisement cost at naya diganta business page, naya diganta business page advertisement rate, black and white advertisement at naya diganta businness page")]
        //[SeoTitle("Publish black and white advertisement in business  page at naya diganta thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta business page")]
        //public ActionResult BusinessPageBlacWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta business page black and white advertisement.",
        //        PriceDescription = 4000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta entertainment page advertisement, naya diganta entertainment page color advertisement, naya diganta entertainment page advertisement, publish advertisement at naya diganta entertainment  page, advertisement cost at naya diganta entertainment page, naya diganta entertainment page advertisement rate, color advertisement at naya diganta entertainment page")]
        [SeoTitle("Publish color advertisement in naya diganta entertainment page thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta entertainment page")]
        public ActionResult EntertainmentPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta entertainment page color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta entertainment page advertisement, naya diganta entertainment page black and white advertisement, naya diganta entertainment page advertisement, publish advertisement at naya diganta entertainment  page, advertisement cost at naya diganta entertainment page, naya diganta entertainment page advertisement rate, black and white advertisement at naya diganta entertainment page")]
        //[SeoTitle("Publish black and white advertisement in naya diganta entertainment page thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta entertainment page")]
        //public ActionResult EntertainmentPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta entertainment page black and white advertisement",
        //        PriceDescription = 4000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta sports page advertisement, naya diganta sports page color advertisement, naya diganta sports page advertisement, publish advertisement at naya diganta sports  page, advertisement cost at naya diganta sports page, naya diganta sports page advertisement rate, color advertisement at naya diganta sports page")]
        [SeoTitle("Publish color advertisement in naya diganta sports page thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta sports page")]
        public ActionResult SportsPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta sports page color advertisement",
                PriceDescription = 6000,
                PriceDescriptionBlack = 5000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta sports page advertisement, naya diganta sports page black and white advertisement, naya diganta sports page advertisement, publish advertisement at naya diganta sports  page, advertisement cost at naya diganta sports page, naya diganta sports page advertisement rate, black and white advertisement at naya diganta sports page")]
        //[SeoTitle("Publish black and white advertisement in naya diganta sports page thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta sports page")]
        //public ActionResult SportsPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta sports page black and white advertisement",
        //        PriceDescription = 5000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta inner page advertisement, naya diganta inner page color advertisement, naya diganta inner page advertisement, publish advertisement at naya diganta inner  page, advertisement cost at naya diganta inner page, naya diganta inner page advertisement rate, color advertisement at naya diganta inner page")]
        [SeoTitle("Publish color advertisement in naya diganta inner page thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta inner page")]
        public ActionResult InnerPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta inner page color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta inner page advertisement, naya diganta inner page black and white advertisement, naya diganta inner page advertisement, publish advertisement at naya diganta inner  page, advertisement cost at naya diganta inner page, naya diganta inner page advertisement rate, black and white advertisement at naya diganta inner page")]
        //[SeoTitle("Publish black and white advertisement in naya diganta inner page thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta inner page")]
        //public ActionResult InnerPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta inner page black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta back inner page advertisement, naya diganta back inner page black and white advertisement, naya diganta back inner page advertisement, publish advertisement at naya diganta back inner  page, advertisement cost at naya diganta back inner page, naya diganta back inner page advertisement rate, black and white advertisement at naya diganta back inner page")]
        [SeoTitle("Publish black and white advertisement in naya diganta back inner page thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta back inner page")]
        public ActionResult BackInnerPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta back inner page black and white advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad financial court related advertisement in naya diganta, finacial court related advertisement in naaya diganta, financial court related advertisement cost at naya diganta, financial court related advertisement rate at naya diganta,financial court advertisement")]
        [SeoTitle("Publish financial court related advertisement in naya diganta through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your financial court related advertisement in naya diganta")]
        public ActionResult FinanceCourtAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta Finance Court related advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad naya diganta birthday meritorius student missing  advertisement, naya diganta birthday meritorius student missing  color advertisement, naya diganta birthday meritorius student missing  advertisement, publish advertisement at naya diganta birthday meritorius student missing, advertisement cost at naya diganta birthday meritorius student missing , naya diganta birthday meritorius student missing  advertisement rate, color advertisement at naya diganta birthday meritorius student missing")]
        [SeoTitle("Publish color advertisement in naya diganta birthday meritorius student missing  thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta birthday meritorius student missing")]
        public ActionResult BirthdayMeritoriousStudentMissingColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta birthday meritorious student missing color advertisement",
                PriceDescription = 1500,
                PriceDescriptionBlack = 800,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta birthday meritorius student missing  advertisement, naya diganta birthday meritorius student missing  black and white advertisement, naya diganta birthday meritorius student missing  advertisement, publish advertisement at naya diganta birthday meritorius student missing, advertisement cost at naya diganta birthday meritorius student missing, naya diganta birthday meritorius student missing  advertisement rate, black and white advertisement at naya diganta birthday meritorius student missing")]
        //[SeoTitle("Publish black and white advertisement in naya diganta birthday meritorius student missing  thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta birthday meritorius student missing")]
        //public ActionResult BirthdayMeritoriousStudentMissingBlackWhiteAdvertiement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta birthday meritorious student missing black and white advertisement",
        //        PriceDescription = 800
        //    };
        //    return View(model);
        //}
        #endregion

        #region Spot
        [SeoMetaKeywords("amader ad naya diganta first page spot advertisement, naya diganta first page spot advertisement, publish spot advertisement at naya diganta first page,spot advertisement cost at naya diganta first page, naya diganta first page spot advertisement rate, spot advertisement at naya diganta first page")]
        [SeoTitle("Publish spot advertisement in naya diganta first page thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in naya diganta first page")]
        public ActionResult FirstPageColorAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta First Page Spot Advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad naya diganta last page spot advertisement, naya diganta last page spot advertisement, publish spot advertisement at naya diganta last page,spot advertisement cost at naya diganta last page, naya diganta last page spot advertisement rate, spot advertisement at naya diganta last page")]
        [SeoTitle("Publish spot advertisement in naya diganta last page thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in naya diganta last page")]
        public ActionResult LastPageColorAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta Last Page Spot Advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }
        #endregion
        #region WeeklyPublication
        [SeoMetaKeywords("amader ad naya diganta weekly obokash  advertisement, naya diganta weekly obokash  color advertisement, naya diganta weekly obokash  advertisement, publish advertisement at naya diganta weekly obokash  , advertisement cost at naya diganta weekly obokash , naya diganta weekly obokash  advertisement rate, color advertisement at naya diganta weekly obokash")]
        [SeoTitle("Publish color advertisement in naya diganta weekly obokash  thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta weekly obokash")]
        public ActionResult ObokashColorAdvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta obokash color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta weekly obokash advertisement, naya diganta weekly obokash black and white advertisement, naya diganta weekly obokash  advertisement, publish advertisement at naya diganta weekly obokash, advertisement cost at naya diganta weekly obokash, naya diganta weekly obokash advertisement rate, black and white advertisement at naya diganta weekly obokash")]
        //[SeoTitle("Publish black and white advertisement in naya diganta weekly obokash thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta weekly obokash")]
        //public ActionResult ObokashBlackWhiteAdvertisement_WeeklyPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta obokash black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta weekly therapy advertisement, naya diganta weekly therapy color advertisement, naya diganta weekly therapy advertisement, publish advertisement at naya diganta weekly therapy, advertisement cost at naya diganta weekly therapy , naya diganta weekly therapy advertisement rate, color advertisement at naya diganta weekly therapy")]
        [SeoTitle("Publish color advertisement in naya diganta weekly therapy thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta weekly therapy")]
        public ActionResult WeeklyTherapyColoradvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta weekly therapy color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta weekly therapy advertisement, naya diganta weekly therapy black and white advertisement, naya diganta weekly therapy  advertisement, publish advertisement at naya diganta weekly therapy, advertisement cost at naya diganta weekly therapy, naya diganta weekly therapy advertisement rate, black and white advertisement at naya diganta weekly therapy")]
        //[SeoTitle("Publish black and white advertisement in naya diganta weekly therapy  thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta weekly therapy")]
        //public ActionResult WeeklyTherapyBlackWhiteAdvertisement_WeeklyPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta weekly therapy black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta weekly shatrong advertisement, naya diganta weekly shatrong color advertisement, naya diganta weekly shatrong advertisement, publish advertisement at naya diganta weekly shatrong, advertisement cost at naya diganta weekly shatrong , naya diganta weekly shatrong advertisement rate, color advertisement at naya diganta weekly shatrong")]
        [SeoTitle("Publish color advertisement in naya diganta weekly shatrong  thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta weekly shatrong")]
        public ActionResult WeeklyShatrongColorAdvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta weekly shatrong color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta weekly shatrong  advertisement, naya diganta weekly shatrong black and white advertisement, naya diganta weekly shatrong advertisement, publish advertisement at naya diganta weekly shatrong, advertisement cost at naya diganta weekly shatrong, naya diganta weekly shatrong advertisement rate, black and white advertisement at naya diganta weekly shatrong")]
        //[SeoTitle("Publish black and white advertisement in naya diganta weekly shatrong  thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta weekly shatrong")]
        //public ActionResult WeeklyShatrongBlackWhiteAdvertisement_WeeklyPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta weekly shatrong black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        #endregion
        #region RegularPublication
        [SeoMetaKeywords("amader ad naya diganta anondolok  advertisement, naya diganta anondolok  color advertisement, naya diganta anondolok  advertisement, publish advertisement at naya diganta anondolok, advertisement cost at naya diganta anondolok , naya diganta anondolok  advertisement rate, color advertisement at naya diganta anondolok")]
        [SeoTitle("Publish color advertisement in naya diganta anondolok  thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta anondolok")]
        public ActionResult AnondolokColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta anondolok color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta anondolok advertisement, naya diganta anondolok black and white advertisement, naya diganta anondolok advertisement, publish advertisement at naya diganta anondolok, advertisement cost at naya diganta anondolok, naya diganta anondolok  advertisement rate, black and white advertisement at naya diganta anondolok")]
        //[SeoTitle("Publish black and white advertisement in naya diganta anondolok  thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta anondolok")]
        //public ActionResult AnondolokBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta anondolok black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta binodon sharadin advertisement, naya diganta binodon sharadin color advertisement, naya diganta binodon sharadin advertisement, publish advertisement at naya diganta binodon sharadin, advertisement cost at naya diganta binodon sharadin, naya diganta binodon sharadin advertisement rate, color advertisement at naya diganta binodon sharadin")]
        [SeoTitle("Publish color advertisement in naya diganta binodon sharadin thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta binodon sharadin")]
        public ActionResult BinodonSharadinColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta binodon sharadin color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta binodon sharadin advertisement, naya diganta binodon sharadin  black and white advertisement, naya diganta binodon sharadin advertisement, publish advertisement at naya diganta binodon sharadin, advertisement cost at naya diganta binodon sharadin, naya diganta binodon sharadin advertisement rate, black and white advertisement at naya diganta binodon sharadin")]
        //[SeoTitle("Publish black and white advertisement in naya diganta binodon sharadin thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta binodon sharadin")]
        //public ActionResult BinodonSharadinBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta binodon sharadin black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta diganta shahitto advertisement, naya diganta diganta shahitto color advertisement, naya diganta diganta shahitto advertisement, publish advertisement at naya diganta diganta shahitto, advertisement cost at naya diganta diganta shahitto, naya diganta diganta shahitto advertisement rate, color advertisement at naya diganta diganta shahitto")]
        [SeoTitle("Publish color advertisement in naya diganta diganta shahitto thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta diganta shahitto")]
        public ActionResult DigantaShahittoColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya diganta diganta shahitto color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta diganta shahitto advertisement, naya diganta diganta shahitto black and white advertisement, naya diganta diganta shahitto advertisement, publish advertisement at naya diganta diganta shahitto, advertisement cost at naya diganta diganta shahitto, naya diganta diganta shahitto advertisement rate, black and white advertisement at naya diganta diganta shahitto")]
        //[SeoTitle("Publish black and white advertisement in naya diganta diganta shahitto thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta diganta shahitto")]
        //public ActionResult DigantaShahittoBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya diganta diganta shahitto black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta nittodin advertisement, naya diganta nittodin color advertisement, naya diganta nittodin advertisement, publish advertisement at naya diganta nittodin, advertisement cost at naya diganta nittodin, naya diganta nittodin  advertisement rate, color advertisement at naya diganta nittodin")]
        [SeoTitle("Publish color advertisement in naya diganta nittodin thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta nittodin")]
        public ActionResult NittodinColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta nittodin color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta nittodin advertisement, naya diganta nittodin  black and white advertisement, naya diganta nittodin advertisement, publish advertisement at naya diganta nittodin, advertisement cost at naya diganta nittodin, naya diganta nittodin advertisement rate, black and white advertisement at naya diganta nittodin")]
        //[SeoTitle("Publish black and white advertisement in naya diganta nittodin thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta nittodin")]
        //public ActionResult NittodinBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta nittodin black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta syllabus advertisement, naya diganta syllabus color advertisement, naya diganta syllabus advertisement, publish advertisement at naya diganta syllabus, advertisement cost at naya diganta syllabus, naya diganta syllabus advertisement rate, color advertisement at naya diganta syllabus")]
        [SeoTitle("Publish color advertisement in naya diganta syllabus thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta syllabus")]
        public ActionResult SyllabusColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta syllabus color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta syllabus  advertisement, naya diganta syllabus black and white advertisement, naya diganta syllabus advertisement, publish advertisement at naya diganta syllabus, advertisement cost at naya diganta syllabus, naya diganta syllabus advertisement rate, black and white advertisement at naya diganta syllabus")]
        //[SeoTitle("Publish black and white advertisement in naya diganta syllabus thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta syllabus")]
        //public ActionResult SyllabusBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta syllabus black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta nari  advertisement, naya diganta nari  color advertisement, naya diganta nari advertisement, publish advertisement at naya diganta nari, advertisement cost at naya diganta nari, naya diganta nari advertisement rate, color advertisement at naya diganta nari")]
        [SeoTitle("Publish color advertisement in naya diganta nari thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta nari")]
        public ActionResult NariColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta nari color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta nari advertisement, naya diganta nari black and white advertisement, naya diganta nari advertisement, publish advertisement at naya diganta nari, advertisement cost at naya diganta nari, naya diganta nari advertisement rate, black and white advertisement at naya diganta nari")]
        //[SeoTitle("Publish black and white advertisement in naya diganta nari thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta nari")]
        //public ActionResult NariBlacWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta nari black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta agdum bagdum advertisement, naya diganta agdum bagdum color advertisement, naya diganta agdum bagdum advertisement, publish advertisement at naya diganta agdum bagdum , advertisement cost at naya diganta agdum bagdum , naya diganta agdum bagdum advertisement rate, color advertisement at naya diganta agdum bagdum")]
        [SeoTitle("Publish color advertisement in naya diganta agdum bagdum thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta agdum bagdum")]
        public ActionResult AgdumBagdumColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta agdum bagdum color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta agdum bagdum advertisement, naya diganta agdum bagdum  black and white advertisement, naya diganta agdum bagdum advertisement, publish advertisement at naya diganta agdum bagdum, advertisement cost at naya diganta agdum bagdum, naya diganta agdum bagdum advertisement rate, black and white advertisement at naya diganta agdum bagdum")]
        //[SeoTitle("Publish black and white advertisement in naya diganta agdum bagdum thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta agdum bagdum")]
        //public ActionResult AgdumBagdumBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta agdum bagdum black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta science and technology advertisement, naya diganta science and technology  color advertisement, naya diganta science and technology advertisement, publish advertisement at naya diganta science and technology, advertisement cost at naya diganta science and technology, naya diganta science and technology advertisement rate, color advertisement at naya diganta science and technology")]
        [SeoTitle("Publish color advertisement in naya diganta science and technology thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta science and technology")]
        public ActionResult ScienceAndTechnologyColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta science and technology color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta science and technology advertisement, naya diganta science and technology black and white advertisement, naya diganta science and technology advertisement, publish advertisement at naya diganta science and technology, advertisement cost at naya diganta science and technology, naya diganta science and technology advertisement rate, black and white advertisement at naya diganta science and technology")]
        //[SeoTitle("Publish black and white advertisement in naya diganta science and technology thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta science and technology")]
        //public ActionResult ScienceAndTechnologyBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta science and technology black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta muktobazar advertisement, naya diganta muktobazar color advertisement, naya diganta muktobazar advertisement, publish advertisement at naya diganta muktobazar, advertisement cost at naya diganta muktobazar, naya diganta muktobazar advertisement rate, color advertisement at naya diganta muktobazar")]
        [SeoTitle("Publish color advertisement in naya diganta muktobazar thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta muktobazar")]
        public ActionResult MuktoBazarColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta muktobazar color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta muktobazar advertisement, naya diganta muktobazar black and white advertisement, naya diganta muktobazar advertisement, publish advertisement at naya diganta muktobazar, advertisement cost at naya diganta muktobazar, naya diganta muktobazar advertisement rate, black and white advertisement at naya diganta muktobazar")]
        //[SeoTitle("Publish black and white advertisement in naya diganta muktobazar thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta muktobazar")]
        //public ActionResult MuktoBazarBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta muktobazar black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta Priyojon advertisement, naya diganta Priyojon color advertisement, naya diganta Priyojon advertisement, publish advertisement at naya diganta Priyojon, advertisement cost at naya diganta Priyojon, naya diganta Priyojon advertisement rate, color advertisement at naya diganta Priyojon")]
        [SeoTitle("Publish color advertisement in naya diganta Priyojon thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your classifThrough Amader Ad publish your color advertisement in naya diganta Priyojon")]
        public ActionResult PriyoJonColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta Priyojon color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta Priyojon advertisement, naya diganta Priyojon  black and white advertisement, naya diganta Priyojon advertisement, publish advertisement at naya diganta Priyojon, advertisement cost at naya diganta Priyojon, naya diganta Priyojon advertisement rate, black and white advertisement at naya diganta Priyojon")]
        //[SeoTitle("Publish black and white advertisement in naya diganta Priyojon thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta Priyojon")]
        //public ActionResult PriyoJonBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta priyojon black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta niramoy advertisement, naya diganta niramoy color advertisement, naya diganta niramoy advertisement, publish advertisement at naya diganta niramoy, advertisement cost at naya diganta niramoy, naya diganta niramoy advertisement rate, color advertisement at naya diganta niramoy")]
        [SeoTitle("Publish color advertisement in naya diganta niramoy thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta niramoy")]
        public ActionResult NiramoyColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta niramoy color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta niramoy advertisement, naya diganta niramoy black and white advertisement, naya diganta niramoy advertisement, publish advertisement at naya diganta niramoy, advertisement cost at naya diganta niramoy, naya diganta niramoy advertisement rate, black and white advertisement at naya diganta niramoy")]
        //[SeoTitle("Publish black and white advertisement in naya diganta niramoy thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta niramoy")]
        //public ActionResult NiramoyBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta niramoy black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta islami diganta advertisement, naya diganta islami diganta color advertisement, naya diganta islami diganta advertisement, publish advertisement at naya diganta islami diganta, advertisement cost at naya diganta islami diganta, naya diganta islami diganta advertisement rate, color advertisement at naya diganta islami diganta")]
        [SeoTitle("Publish color advertisement in naya diganta islami diganta thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta islami diganta")]
        public ActionResult IslamiDigantaColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta islami diganta color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta islami diganta advertisement, naya diganta islami diganta  black and white advertisement, naya diganta islami diganta advertisement, publish advertisement at naya diganta islami diganta, advertisement cost at naya diganta islami diganta, naya diganta islami diganta advertisement rate, black and white advertisement at naya diganta islami diganta")]
        //[SeoTitle("Publish black and white advertisement in naya diganta islami diganta thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta islami diganta")]
        //public ActionResult IslamiDigantaBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta islami diganta black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta desh mohadesh advertisement, naya diganta desh mohadesh color advertisement, naya diganta desh mohadesh advertisement, publish advertisement at naya diganta desh mohadesh, advertisement cost at naya diganta desh mohadesh, naya diganta desh mohadesh advertisement rate, color advertisement at naya diganta desh mohadesh")]
        [SeoTitle("Publish color advertisement in naya diganta desh mohadesh thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your coloradvertisement in naya diganta desh mohadesh")]
        public ActionResult DeshMohadeshColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta desh mohadesh color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta desh mohadesh advertisement, naya diganta desh mohadesh  black and white advertisement, naya diganta desh mohadesh advertisement, publish advertisement at naya diganta desh mohadesh, advertisement cost at naya diganta desh mohadesh, naya diganta desh mohadesh advertisement rate, black and white advertisement at naya diganta desh mohadesh")]
        //[SeoTitle("Publish black and white advertisement in naya diganta desh mohadesh thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta desh mohadesh")]
        //public ActionResult DeshMohadeshBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta desh mohadesh black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad naya diganta ajker computer advertisement, naya diganta ajker computer color advertisement, naya diganta ajker computer advertisement, publish advertisement at naya diganta ajker computer, advertisement cost at naya diganta ajker computer, naya diganta ajker computer advertisement rate, color advertisement at naya diganta ajker computer")]
        [SeoTitle("Publish color advertisement in naya diganta ajker computer thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in naya diganta ajker computer")]
        public ActionResult AjkerComputerColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta ajker computer color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad naya diganta ajker computer advertisement, naya diganta ajker computer black and white advertisement, naya diganta ajker computer advertisement, publish advertisement at naya diganta ajker computer, advertisement cost at naya diganta ajker computer, naya diganta ajker computer advertisement rate, black and white advertisement at naya diganta ajker computer")]
        //[SeoTitle("Publish black and white advertisement in naya diganta ajker computer thourgh amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in naya diganta ajker computer")]
        //public ActionResult AjkerComputerBlackWhiteAdvertisement_RegularPublication()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Naya Diganta",
        //        AdLocation = "Naya Diganta ajker computer black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        #endregion

    }
}