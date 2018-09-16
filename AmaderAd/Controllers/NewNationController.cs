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
    [SeoBaseTitle("Publish advertisement in New Nation through amader ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/NewNation")]
    public class NewNationController : BaseController
    {
        // GET: NewNation
        public ActionResult Index()
        {
            return View();
        }

        #region classified advertisement
        [SeoMetaKeywords("amader ad new nation classified advertisement,new nation classified ad, new nation classified advertisement,  publish classified advertisement at new nation , classified advertisement cost at new nation, new nation classified advertisement rate, classified advertisement at new nation, নিউ নেশন  শ্রেণীভুক্ত বিজ্ঞাপন দিন,  rent at new nation,  house rent at new nation, publish rent advertisement at new nation, new nation rent advertisement, land slae advertisement at new nation, new nation land sale advertisement, new nation land sale ad cost, new nation জমি বিক্রয়ের বিজ্ঞাপন দিন,  miscellaneous sales advertisement at new nation, new nation miscellaneous slaes advetisement,  miscellaneous sales cost at new nation, publish miscellaneous advertisement at new nation, miscellaneous at new nation, house sale advertisement at new nation, new nation house sales advertisement, house sales advertisement cost at new nation, publish house sale advertisement at new nation, house sale advertisement at new nation, নিউ নেশন বাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  shop sale advertisement at new nation, new nation shop sales advertisement, shop sales advertisement cost at new nation, publish shop sale advertisement at new nation, house shop advertisement at new nation, new nation দোকান বিক্রয়ের বিজ্ঞাপন দিন,     car sale advertisement at new nation, new nation car sales advertisement, car sales advertisement cost at new nation, publish car sale advertisement at new nation, car sale advertisement at new nation, new nation গাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  plot purchase advertisement at new nation, new nation plot purchase advertisement, plot purchase advertisement cost at new nation, publish plot purchase advertisement at new nation, plot purchase advertisement at new nation, new nation প্লট ক্রয়ের  বিজ্ঞাপন দিন, 	 wanted advertisement at new nation, new nation wanted advertisement, wanted advertisement cost at new nation, publish wanted advertisement at new nation, wanted advertisement at new nation, 	 tution wanted advertisement at new nation, new nation tution wante advertisement, tution wanted advertisement cost at new nation, publish tution wanted advertisement at new nation, tuiton wanted advertisement at new nation, new nation পড়াতে চাই   বিজ্ঞাপন দিন,  groom wanted advertisement at new nation, new nation groom wanted advertisement, groom wanted advertisement cost at new nation, publish groom wanted advertisement at new nation, groom wnated advertisement at new nation,  bride wanted advertisement at new nation, new nation plot bride wanted advertisement, bride wanted  advertisement cost at new nation, bride wanted purchase advertisement at new nation, bride wanted  advertisement at new nation")]
        [SeoTitle("Publish classified advertisement in new nation through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your classified advertisement new nation")]
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation Classified Advertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,
                PriceDescription = 500,
                ExtraWordPrice = 40,
                WordLimit = 60,
                VAT = 0.15,
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        #endregion

        #region MainPage
        [SeoMetaKeywords("amader ad new nation first page advertisement, new nation first page color advertisement, new nation 1st page advertisement,  new nation 1st page color advbertisement, new nation 1 number page advertisement, new nation one number page color advertisement, publish advertisement at new nation first page, advertisement cost at new nation first page, new nation first page advertisement rate, color advertisement at new nation first page, new nation front page color advertisement")]
        [SeoTitle("Publish color advertisement in new nation  front page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in new nation first page")]
        public ActionResult FrontPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation front page color advertisement",
                PriceDescription = 9000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new nation backpage advertisement, new nation backpage color advertisement, new nation backpage advertisement,  new nation backpage color advbertisement,  publish advertisement at new nation backpage, advertisement cost at new nation backpage, new nation backpage advertisement rate, color advertisement at new nation backpage, new nation back page color advertisement")]
        [SeoTitle("Publish color advertisement in new nation  back page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in new nation backpage")]
        public ActionResult BackpageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation back page color advertisement",
                PriceDescription = 7000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new nation third page advertisement, new nation third page advertisement, new nation 3rd page advertisement,  new nation 3rd page advertisement, new nation 3 number page advertisement, new nation three number page color advertisement, publish advertisement at new nation third page, advertisement cost at new nation third page, new nation third page advertisement rate, color advertisement at new nation third page, new nation third page color advertisement")]
        [SeoTitle("Publish advertisement in new nation  third page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your advertisement in new nation third page")]
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation third page advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad new nation third page advertisement, new nation third page Black and White advertisement, new nation 3rd page advertisement,  new nation 3rd page Black and White advertisement, new nation 3 number page advertisement, new nation three number page Black and White advertisement, publish advertisement at new nation third page, advertisement cost at new nation third page, new nation third page advertisement rate, Black and White advertisement at new nation third page, new nation third page Black and White advertisement")]
        //[SeoTitle("Publish Black and White advertisement in new nation  third page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your Black and White advertisement in new nation third page")]
        //public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "New Nation",
        //        AdLocation = "New Nation third page black and white advertisement",
        //        PriceDescription = 3000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad new nation Other Inside page advertisement, new nation Other Inside page color advertisement, new nation other inside page advertisement,  new nation other inside page color advertisement, new nation other inside number page advertisement, publish advertisement at new nation Other Inside page, advertisement cost at new nation Other Inside page, new nation Other Inside page advertisement rate, color advertisement at new nation Other Inside page, new nation Other Inside page color advertisement")]
        [SeoTitle("Publish color advertisement in new nation  Other Inside page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in new nation Other Inside page")]
        public ActionResult OtherInsidePageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation other inside page color advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new nation  commercial display advertisement, new nation commercial display advertisement, new nation public meeting advertisement, new nation conference advertisement, new nation raders ads advertisement, new nation company notice advertisement, new nation layoff notice advertisement, new nation calender advertisement, new nation trademark notice advertisement, new nation election advertisement, new nation tender notice advertisement")]
        [SeoTitle("Publish commercial display advertisement in new nation  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish commercial display advertisement new nation")]
        public ActionResult CommercialDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation Commercial Display Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new nation  high court and judge court related advertisement, new nation high court and judge court related advertisement, new nation books and magazine advertisement, new nation urs advertisement, new nation milad-e-mahfil advertisement, new nation relagious advertisement, new nation educational admission advertisement, new nation marriage and qulkhwani advertisement, new nation technical and commertial notice advertisement, new nation academic feat advertisement, new nation reunion advertisement, new nation books and magazine advertisement, new nation note books advertisement, new nation exibitions advertisement, new nation circus advertisement,new nation concert, magic show advertisement,new nation cinema, theatre, dance drama, musical night advertisement")]
        [SeoTitle("Publish high court and judge court related  advertisement in new nation  through amader ad")]
        [SeoMetaDescription("Publish high court and judje court related advertisement in new nation")]
        public ActionResult HighCourtJudgeCourtAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Nation",
                AdLocation = "New Nation High Court Judge Court Advertisement",
                PriceDescription = 3000
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
                NewspaperName = "New Nation",
                AdLocation = "New Nation Govt. Advertisement",
                TitleDescription = "Govt. Advertisement At New Nation",
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
                NewspaperName = "New Nation",
                AdLocation = "New Nation- Govt. Commercial Advertisement",
                TitleDescription = "Govt. Commercial Advertisement At New Nation",
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