using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;
using AspNetSeo.Mvc;

namespace AmaderAd.Controllers
{
    [SeoBaseTitle("publish advertisement in Daily Sun through amader ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/DailySun")]
    public class DailySunController : BaseController
    {
        // GET: DailySun
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Sun",
                AdLocation = "Daily Sun Classified Advertisement",

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

        [SeoMetaKeywords("amader ad Daily Sun first page advertisement, Daily Sun first page color advertisement, Daily Sun 1st page advertisement, Daily Sun 1st page color advbertisement, Daily Sun 1 number page advertisement, Daily Sun one number page color advertisement, publish advertisement at Daily Sun first page, advertisement cost at Daily Sun first page, Daily Sun first page advertisement rate, color advertisement at Daily Sun first page, Daily Sun front page color advertisement")]
        [SeoTitle("Publish color advertisement in Daily Sun  front page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in Daily Sun first page")]
        public ActionResult FrontPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Sun",
                AdLocation = "Daily Sun front page color advertisement",
                PriceDescription = 9000,

                // column inch restrictions
                MinTotalColumnInch = 12,
                MaxTotalColumnInch = 80,
                MinMaxRestrictiion = true,
            };
            return View(model);
        }

        [SeoMetaKeywords("amader ad Daily Sun backpage advertisement, Daily Sun backpage color advertisement, Daily Sun backpage advertisement, Daily Sun backpage color advbertisement, publish advertisement at Daily Sun backpage, advertisement cost at Daily Sun backpage, Daily Sun backpage advertisement rate, color advertisement at Daily Sun backpage, Daily Sun back page color advertisement")]
        [SeoTitle("Publish color advertisement in Daily Sun  back page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in Daily Sun back page")]
        public ActionResult BackPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Sun",
                AdLocation = "Daily Sun back page color advertisement",
                PriceDescription = 8000,
                // column inch restrictions
                MinTotalColumnInch = 4,
                MaxTotalColumnInch = 80,
                MinMaxRestrictiion = true,
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad Daily Sun second page advertisement, Daily Sun second page  advertisement, Daily Sun 2nd page advertisement,  Daily Sun 2nd page  advertisement, Daily Sun 2 number page advertisement, Daily Sun two number page color advertisement, publish advertisement at Daily Sun second page, advertisement cost at Daily Sun second page, Daily Sun second page color advertisement rate, color advertisement at Daily Sun second page, Daily Sun second page color advertisement")]
        [SeoTitle("Publish  advertisement in Daily Sun  second page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your  advertisement in Daily Sun second page")]
        public ActionResult SecondPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Sun",
                AdLocation = "Daily Sun Second page advertisement",
                PriceDescription = 3000,
                PriceDescriptionBlack = 2200,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad Daily Sun second page advertisement, Daily Sun second page Black and White advertisement, Daily Sun 2nd page advertisement, Daily Sun 2nd page Black and White advertisement, Daily Sun 2 number page advertisement, Daily Sun two number page Black and White advertisement, publish advertisement at Daily Sun second page, advertisement cost at Daily Sun second page, Daily Sun second page black and white advertisement rate, Black and White advertisement at Daily Sun second page, Daily Sun second page Black and White advertisement")]
        //[SeoTitle("Publish Black and White advertisement in Daily Sun  second page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your Black and White advertisement in Daily Sun second page")]
        //public ActionResult SecondPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Daily Sun",
        //        AdLocation = "Daily Sun Second page black and white advertisement",
        //        PriceDescription = 2200
        //    };
        //    return View(model);
        //}

        [SeoMetaKeywords("amader ad Daily Sun third page advertisement, Daily Sun third page  advertisement, Daily Sun 3rd page advertisement, Daily Sun 3rd page color advertisement, Daily Sun 3 number page advertisement, Daily Sun three number page color advertisement, publish advertisement at Daily Sun third page, advertisement cost at Daily Sun third page, Daily Sun third page advertisement rate, color advertisement at Daily Sun third page, Daily Sun third page color advertisement")]
        [SeoTitle("Publish advertisement in Daily Sun third page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your  advertisement in Daily Sun third page")]
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Sun",
                AdLocation = "Daily Sun Third page  advertisement",
                PriceDescription = 4500,
                PriceDescriptionBlack = 3000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad Daily Sun third page advertisement, Daily Sun third page Black and White advertisement, Daily Sun 3rd page advertisement,  Daily Sun 3rd page Black and White advertisement, Daily Sun 3 number page advertisement, Daily Sun three number page Black and White advertisement, publish advertisement at Daily Sun third page, advertisement cost at Daily Sun third page, Daily Sun third page black and white advertisement rate, Black and White advertisement at Daily Sun third page, Daily Sun third page Black and White advertisement")]
        //[SeoTitle("Publish Black and White advertisement in Daily Sun  third page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your Black and White advertisement in Daily Sun third page")]
        //public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Daily Sun",
        //        AdLocation = "Daily Sun Third page black and white advertisement",
        //        PriceDescription = 3000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad Daily Sun fifth page advertisement, Daily Sun fifth page  advertisement, Daily Sun 5th page advertisement,  Daily Sun 5th page color advertisement, Daily Sun 5 number page advertisement, Daily Sun five number page color advertisement, publish advertisement at Daily Sun fifth page, advertisement cost at Daily Sun fifth page, Daily Sun fifth page color advertisement rate, color advertisement at Daily Sun fifth page, Daily Sun fifth page color advertisement")]
        [SeoTitle("Publish advertisement in Daily Sun  fifth page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your  advertisement in Daily Sun fifth page")]
        public ActionResult FifthPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Sun",
                AdLocation = "Daily Sun Fifth page advertisement",
                PriceDescription = 3000,
                PriceDescriptionBlack = 2200,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad Daily Sun fifth page advertisement, Daily Sun fifth page Black and White advertisement, Daily Sun 5th page advertisement, Daily Sun 5th page Black and White advertisement, Daily Sun 5 number page advertisement, Daily Sun five number page Black and White advertisement, publish advertisement at Daily Sun fifth page, advertisement cost at Daily Sun fifth page, Daily Sun fifth page black and white advertisement rate, Black and White advertisement at Daily Sun fifth page, Daily Sun fifth page Black and White advertisement")]
        //[SeoTitle("Publish Black and White advertisement in Daily Sun  fifth page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your Black and White advertisement in Daily Sun fifth page")]
        //public ActionResult FifthPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Daily Sun",
        //        AdLocation = "Daily Sun Fifth page black and white advertisement",
        //        PriceDescription = 2200
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad Daily Sun Other Inside page advertisement, Daily Sun Other Inside page  advertisement, Daily Sun other inside page advertisement, Daily Sun other inside page color advertisement, Daily Sun other inside number page advertisement, publish advertisement at Daily Sun Other Inside page, advertisement cost at Daily Sun Other Inside page, Daily Sun Other Inside page color advertisement rate, color advertisement at Daily Sun Other Inside page, Daily Sun Other Inside page color advertisement")]
        [SeoTitle("Publish advertisement in Daily Sun  Other Inside page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your  advertisement in Daily Sun Other Inside page")]
        public ActionResult OtherInsidePageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Daily Sun",
                AdLocation = "Daily Sun Other Inside page advertisement",
                PriceDescription = 2800,
                PriceDescriptionBlack = 2000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad Daily Sun Other Inside page advertisement, Daily Sun Other Inside page Black and White advertisement, Daily Sun other inside page advertisement, Daily Sun other inside page Black and White advertisement, Daily Sun other inside number page advertisement, publish advertisement at Daily Sun Other Inside page, advertisement cost at Daily Sun Other Inside page, Daily Sun Other Inside page advertisement rate, Black and White advertisement at Daily Sun Other Inside page, Daily Sun Other Inside page Black and White advertisement")]
        //[SeoTitle("Publish Black and White advertisement in Daily Sun Other Inside page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your Black and White advertisement in Daily Sun Other Inside page")]
        //public ActionResult OtherInsidePageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Daily Sun",
        //        AdLocation = "Daily Sun Other Inside page black and White advertisement",
        //        PriceDescription = 2000
        //    };
        //    return View(model);
        //}
    }
}