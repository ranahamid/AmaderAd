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
    [SeoBaseTitle("publish advertisement in Inqilab through amader ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/Inqilab")]
    public class InqilabController : BaseController
    {
        // GET: Inqilab
        public ActionResult Index()
        {
            return View();
        }

        #region  Classified



        //classified advertisement
        [SeoMetaKeywords("amader ad inqilab classified advertisement,inqilab classified ad, inqilab classified advertisement, publish classied advertisement at inqilab, classified advertisement cost at inqilab, inqilab classified advertisement rate, classified advertisement at inqilab, ইনকিলাবে শ্রেণীভুক্ত বিজ্ঞাপন দিন, rent at inqilab, house rent at inqilab, publish rent advertisement at inqilab, inqilab rent advertisement, ইত্তেফাক বাড়ি ভাড়া বিজ্ঞাপন, land slae advertisement at inqilab, inqilab land sale advertisement, inqilab land sale ad cost, ইনকিলাবে জমি বিক্রয়ের বিজ্ঞাপন দিন, miscellaneous sales advertisement at inqilab, inqilab miscellaneous slaes advetisement, miscellaneous sales cost at inqilab, publish miscellaneous advertisement at inqilab, miscellaneous at inqilab, ইনকিলাবে বিবিধ বিক্রয়ের বিজ্ঞাপন দিন, house sale advertisement at inqilab, inqilab alo house sales advertisement, house sales advertisement cost at inqilab, publish house sale advertisement at inqilab, house sale advertisement at inqilab, ইনকিলাবে বাড়ি বিক্রয়ের বিজ্ঞাপন দিন, shop sale advertisement at inqilab, inqilab shop sales advertisement, shop sales advertisement cost at inqilab, publish shop sale advertisement at inqilab, house shop advertisement at inqilab, ইনকিলাবে দোকান বিক্রয়ের বিজ্ঞাপন দিন, car sale advertisement at inqilab, inqilab car sales advertisement, car sales advertisement cost at inqilab, publish car sale advertisement at inqilab, car sale advertisement at inqilab, ইনকিলাবে গাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  plot purchase advertisement at inqilab, inqilab plot purchase advertisement, plot purchase advertisement cost at inqilab, publish plot purchase advertisement at inqilab, plot purchase advertisement at inqilab, ইনকিলাবে প্লট ক্রয়ের  বিজ্ঞাপন দিন,  wanted advertisement at inqilab, inqilab wanted advertisement, wanted advertisement cost at inqilab, publish wanted advertisement at inqilab, wanted advertisement at inqilab, tution wanted advertisement at inqilab, inqilab tution wante advertisement, tution wanted advertisement cost at inqilab, publish tution wanted advertisement at inqilab, tuiton wanted advertisement at inqilab, ইনকিলাবে  পড়াতে চাই   বিজ্ঞাপন দিন, groom wanted advertisement at inqilab, inqilab groom wanted advertisement, groom wanted advertisement cost at inqilab, publish groom wanted advertisement at inqilab, groom wnated advertisement at inqilab, ইনকিলাবে  পাত্র চাই  বিজ্ঞাপন দিন, bride wanted advertisement at inqilab, inqilab plot bride wanted advertisement, bride wanted advertisement cost at inqilab, bride wanted purchase advertisement at inqilab, bride wanted advertisement at inqilab, ইনকিলাবে  পাত্রী চাই  বিজ্ঞাপন দিন")]
        [SeoTitle("Publish classified advertisement in inqilab through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your classified advertisement inqilab")]
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
         
                AdLocation = "Classified Advertisement",
                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,
                PriceDescription = 300,
                ExtraWordPrice = 40,
                WordLimit = 50,


                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        #endregion

        #region special place
        [SeoMetaKeywords("amader ad inqilab financial court summons notice advertisement, inqilab financial court summons notice advertisement, publish advertisement at inqilab financial court summons notice, advertisement cost at inqilab financial court summons notice, inqilab financial court summons notice advertisement rate, advertisement inqilab financial court summons notice ")]
        [SeoTitle("Publish financial court summons notice advertisement in inqilab through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your financial court summons notice advertisement inqilab")]
        public ActionResult FinancialCourt()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",

                AdLocation = "Financial Court, Sommons, Notice, Tender",
                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                //FirstWordLimitBase = 16,
                 PriceDescription = 3600,
                //ExtraWordPrice = 40,
                //WordLimit = 50,
                VAT = 0.15,
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad inqilab educational religious advertisement, inqilab educational religious advertisement, publish advertisement at inqilab educational religious, advertisement cost at inqilab educational religious, inqilab educational religious advertisement rate, advertisement inqilab educational religious")]
        [SeoTitle("Publish educational religious advertisement in inqilab through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your eduactional religious advertisement in inqilab")]
        public ActionResult EduReligious()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",

                AdLocation = "Educational, Religious Advertisement",
                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                //FirstWordLimitBase = 16,
                PriceDescription = 2400,
                //ExtraWordPrice = 40,
                //WordLimit = 50,

                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        #endregion

        #region  main Paper
        [SeoMetaKeywords("amader ad inqilab first page advertisement, inqilab first page color advertisement, inqilab 1st page advertisement,  inqilab 1st page color advbertisement, inqilab 1 number page advertisement, inqilab one number page color advertisement, publish advertisement at inqilab first page, advertisement cost at inqilab first page, inqilab first page advertisement rate, color advertisement at inqilab first page")]
        [SeoTitle("Publish color advertisement in inqilab first page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in inqilab first page")]
        public ActionResult FirstPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab first page color advertisement",
                PriceDescription = 14000,
                PriceDescriptionBlack = 12000,
                IsColor = true,
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad inquilab last page advertisement, inquilab last page color advertisement, inquilab last page advertisement, publish advertisement at inquilab last  page, advertisement cost at inquilab last page, inquilab last page advertisement rate, color advertisement at inquilab last page")]
        [SeoTitle("Publish color advertisement in inqilab last page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in inquilab last page")]
        public ActionResult LastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab last page color advertisement",
                PriceDescription = 12000,
                PriceDescriptionBlack = 10000,
                IsColor = true,
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad inqilab general display advertisement, inqilab general display advertisement, publish general display advertisement in inqilab, general display advertisement cost at inqilab, inqilab general display advertisement rate, general display advertisement at inqilab")]
        [SeoTitle("Publish general display advertisement in inqilab through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your general display advertisement in inqilab")]
        public ActionResult GeneralDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab general display advertisement",
                PriceDescription = 3600
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad inquilab third page advertisement, inquilab third page advertisement, inquilab 3rd page advertisement, inquilab 3rd page advbertisement, inquilab 3 number page advertisement, inquilab three number page color advertisement, publish advertisement at inquilab third page, advertisement cost at inquilab third page, inquilab third page advertisement rate, color advertisement at inquilab third page")]
        [SeoTitle("Publish advertisement in inqilab third page thrrough amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your advertisement in inquilab third page")]
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab third page  advertisement",
                PriceDescription = 8000,
                PriceDescriptionBlack = 5000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad inqilab third page advertisement, inqilab third page black and white advertisement, inqilab 3rd page advertisement,  inqilab 3rd page black and white advbertisement, inqilab 3 number page advertisement, inqilab three number page black and white advertisement, publish advertisement at inqilab third page, advertisement cost at inqilab third page, inqilab third page black and white advertisement rate, black and white advertisement at inqilab third page")]
        //[SeoTitle("Publish black and white advertisement in inqilab third page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in inqilab third page")]
        //public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Inqilab",
        //        AdLocation = "Inqilab third page black and white advertisement",
        //        PriceDescription = 5000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad inqilab second page advertisement, inqilab second page black and white advertisement, inqilab 2nd page advertisement,  inqilab 2nd page black and white advbertisement, inqilab 2 number page advertisement, inqilab second number page black and white advertisement, publish advertisement at inqilab second page, advertisement cost at inqilab second page, inqilab second page black and white advertisement rate, black and white advertisement at inqilab second page")]
        [SeoTitle("Publish black and white advertisement in inqilab second page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in inqilab second page")]
        public ActionResult SecondPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab second page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad inqilab inner page advertisement, inqilab inner page color advertisement, advertisememnt at inqilab inner page, inqilab inner page color advertisement cost,publish color advertisement at inqilab inner page, inqilab inner page color advertisement rate")]
        [SeoTitle("Publish advertisement in inqilab inner page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your advertisement in inqilab inner page")]
        public ActionResult InnerPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab inner page advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad inqilab inner page black and white advertisement, inqilab inner page black and white advertisement,black and white advertisememnt at inqilab inner page, inqilab inner page black and white advertisement cost,publish black and white advertisement at inqilab inner page, inqilab inner page black and white advertisement rate")]
        //[SeoTitle("Publish black and white advertisement in inqilab inner page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in inqilab inner page")]
        //public ActionResult InnerPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Inqilab",
        //        AdLocation = "Inqilab inner page black and white advertisement",
        //        PriceDescription = 3000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad inqilab sports page advertisement, inqilab sports page advertisement, inqilab sports page advertisement, publish advertisement at inqilab sports page, advertisement cost at inqilab sports page, inqilab sports page advertisement rate, color advertisement at inqilab sports page")]
        [SeoTitle("Publish advertisement in inqilab sports page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your advertisement in inqilab sports page")]
        public ActionResult SportsPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab sports page advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad inqilab sports page advertisement, inqilab sports page black and white advertisement, inqilab sports page advertisement, publish advertisement at inqilab sports page, advertisement cost at inqilab sports page, inqilab sports page black and white advertisement rate, black and white advertisement at inqilab sports page")]
        //[SeoTitle("Publish black and white advertisement in inqilab sports page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in inqilab sports page")]
        //public ActionResult SportsPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Inqilab",
        //        AdLocation = "Inqilab sports page black and white advertisement",
        //        PriceDescription = 4000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad inqilab page before last page advertisement, inqilab page before last page black and white advertisement, inqilab page before last page advertisement, publish advertisement at inqilab page before last page, advertisement cost at inqilab page before last page, inqilab page before last page black and white advertisement rate, black and white advertisement at inqilab sports page")]
        [SeoTitle("Publish black and white advertisement in inqilab page before last page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement page before last page in inqilab")]
        public ActionResult PageBeforeLastPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab page before last page black and white advertisement (15th Page)",
                PriceDescription = 4000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad inqilab entertainment page advertisement, inqilab entertainment page  advertisement, inqilab entertainment page advertisement, publish advertisement at inqilab entertainment page, advertisement cost at inqilab entertainment page, inqilab entertainment page color advertisement rate, color advertisement at inqilab entertainment page")]
        [SeoTitle("Publish  advertisement in inqilab entertainment page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your  advertisement in inqilab entertainment page")]
        public ActionResult EntertainmentPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab entertainment page advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3000,
                IsColor = true,
            };
            return View(model);
        }


        //[SeoMetaKeywords("amader ad inqilab entertainment page advertisement, inqilab entertainment page black and white advertisement, inqilab entertainment page advertisement, publish advertisement at inqilab entertainment page, advertisement cost at inqilab entertainment page, inqilab entertainment page black and white advertisement rate, black and white advertisement at inqilab entertainment page")]
        //[SeoTitle("Publish black and white advertisement in inqilab entertainment page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in inqilab entertainment page")]
        //public ActionResult EntertainmentPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Inqilab",
        //        AdLocation = "Inqilab entertainment page black and white advertisement",
        //        PriceDescription = 3000
        //    };
        //    return View(model);
        //}
        #endregion

        #region  Bishesh Koropotro

        public ActionResult FeaturePaper()
        {
            // black-white / color
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Inqilab bishesh krorpotro",
                PriceDescription = 10000,
                PriceDescriptionBlack= 5000,
                IsColor = true,
            };
            return View(model);
        }

        #endregion

        #region  Spot Advertisement
        public ActionResult FirstPage_SpotAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "First Page -Spot Advertisement",
                PriceDescription = 40000,
                PriceDescriptionLow = 30000
            };
            return View(model);
        }

        public ActionResult LastPage_SpotAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Last Page -Spot Advertisement",
                PriceDescription = 30000,
                PriceDescriptionLow = 25000
            };
            return View(model);
        }

        public ActionResult SportsPage_SpotAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Sports Page -Spot Advertisement",
                PriceDescription = 10000,
             
            };
            return View(model);
        }


        #endregion

        #region Government Advertisement
        public ActionResult Government()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Government Advertisement",
                PriceDescription = 853,

            };
            return View(model);
        }

        public ActionResult Government_Commercial()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Inqilab",
                AdLocation = "Government Commercial Advertisement",
                PriceDescription = 853,

            };
            return View(model);
        }

        #endregion
    }
}