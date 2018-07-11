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
    [SeoBaseTitle("Publish advertisement in Amader Shomoy through amader ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/AmaderShomoy")]
    public class AmaderShomoyController : BaseController
    {
        // GET: AmaderShomoy
        public ActionResult Index()
        {
            return View();

        }
        #region classified advertisement
        [SeoMetaKeywords("amader ad amader shomoy classified advertisement,amader shomoy classified ad, amader shomoy classified advertisement, publish classied advertisement at amader shomoy , classified advertisement cost at amader shomoy, amader shomoy classified advertisement rate, classified advertisement at amader shomoy, আমাদের সময়ে  শ্রেণীভুক্ত বিজ্ঞাপন দিন,  rent at amader shomoy, house rent at amader shomoy, publish rent advertisement at amader shomoy, amader shomoy rent advertisement, আমাদের সময়ে বাড়ি ভাড়া বিজ্ঞাপন, land slae advertisement at amader shomoy, amader shomoy land sale advertisement, amader shomoy land sale ad cost, আমাদের সময়ে জমি বিক্রয়ের বিজ্ঞাপন দিন,  miscellaneous sales advertisement at amader shomoy, amader shomoy miscellaneous slaes advetisement, miscellaneous sales cost at amader shomoy, publish miscellaneous advertisement at amader shomoy, miscellaneous at amader shomoy, আমাদের সময়ে বিবিধ বিক্রয়ের বিজ্ঞাপন দিন, house sale advertisement at amader shomoy, amader shomoy house sales advertisement, house sales advertisement cost at amader shomoy, publish house sale advertisement at amader shomoy, house sale advertisement at amader shomoy, আমাদের সময়ে বাড়ি বিক্রয়ের বিজ্ঞাপন দিন, shop sale advertisement at amader shomoy, amader shomoy shop sales advertisement, shop sales advertisement cost at amader shomoy, publish shop sale advertisement at amader shomoy, house shop advertisement at amader shomoy, আমাদের সময়ে দোকান বিক্রয়ের বিজ্ঞাপন দিন, car sale advertisement at amader shomoy, amader shomoy car sales advertisement, car sales advertisement cost at amader shomoy, publish car sale advertisement at amader shomoy, car sale advertisement at amader shomoy, আমাদের সময়ে গাড়ি বিক্রয়ের বিজ্ঞাপন দিন, plot purchase advertisement at amader shomoy, amader shomoy plot purchase advertisement, plot purchase advertisement cost at amader shomoy, publish plot purchase advertisement at amader shomoy, plot purchase advertisement at amader shomoy, আমাদের সময়ে প্লট ক্রয়ের  বিজ্ঞাপন দিন, wanted advertisement at amader shomoy, amader shomoy wanted advertisement, wanted advertisement cost at amader shomoy, publish wanted advertisement at amader shomoy, wanted advertisement at amader shomoy, tution wanted advertisement at amader shomoy, amader shomoy tution wante advertisement, tution wanted advertisement cost at amader shomoy, publish tution wanted advertisement at amader shomoy, tuiton wanted advertisement at amader shomoy, আমাদের সময়ে  পড়াতে চাই   বিজ্ঞাপন দিন, groom wanted advertisement at amader shomoy, amader shomoy groom wanted advertisement, groom wanted advertisement cost at amader shomoy, publish groom wanted advertisement at amader shomoy, groom wnated advertisement at amader shomoy, আমাদের সময়ে  পাত্র চাই  বিজ্ঞাপন দিন,  bride wanted advertisement at amader shomoy, amader shomoy plot bride wanted advertisement, bride wanted  advertisement cost at amader shomoy, bride wanted purchase advertisement at amader shomoy, bride wanted  advertisement at amader shomoy, আমাদের সময়ে  পাত্রী চাই  বিজ্ঞাপন দিন")]
        [SeoTitle("Publish classified advertisement in amader shomoy through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your classified advertisement amader shomoy")]
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy Classified Advertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 20,
                PriceDescription = 300,
                ExtraWordPrice = 15,
                WordLimit = 60,
                VAT=0.15,

                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
#endregion
        #region MainPage

        [SeoBaseTitle("Publish color advertisement in amader shomoy first page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy first page advertisement, amader shomoy first page color advertisement, amader shomoy 1st page advertisement,  amader shomoy 1st page color advbertisement, amader shomoy 1 number page advertisement, amader shomoy one number page color advertisement, publish advertisement at amader shomoy first page, advertisement cost at amader shomoy first page, amader shomoy first page advertisement rate, color advertisement at amader shomoy first page,")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in amader shomoy first page")]
        public ActionResult FirstPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy First Page Color",
                PriceDescription = 16000,


                // column inch restrictions
                MinTotalColumnInch = 12,
                MaxTotalColumnInch = 80,
                MinMaxRestrictiion = true,

            };
            return View(model);
        }
        [SeoBaseTitle("Publish color advertisement in amader shomoy last page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy last page advertisement, amader shomoy last page color advertisement, amader shomoy last page advertisement, publish advertisement at amader shomoy last  page, advertisement cost at amader shomoy last page, amader shomoy last page advertisement rate, color advertisement at amader shomoy last page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in amader shomoy last page")]
        public ActionResult LastPageColorAdvertisemnet_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy last page color advertisemnet",
                PriceDescription = 14000,


                // column inch restrictions
                MinTotalColumnInch = 4,
                MaxTotalColumnInch = 80,
                MinMaxRestrictiion = true,

            };
            return View(model);
        }
        [SeoBaseTitle("Publish advertisement in amader shomoy third page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy third page advertisement, amader shomoy third page  advertisement, amader shomoy 3rd page advertisement,  amader shomoy 3rd page color advbertisement, amader shomoy 3 number page advertisement, amader shomoy three number page advertisement, publish advertisement at amader shomoy third page, advertisement cost at amader shomoy third page, amader shomoy third page advertisement rate,  advertisement at amader shomoy third page")]
        [SeoMetaDescription("Through Amader Ad publish your  advertisement in amader shomoy third page")]
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy third page advertisement",
                PriceDescription = 9000,
                PriceDescriptionBlack = 8000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoBaseTitle("Publish black and white advertisement in amader shomoy third page through amader ad")]
        //[SeoMetaKeywords("amader ad amader shomoy third page advertisement, amader shomoy third page black and white advertisement, amader shomoy 3rd page advertisement,  amader shomoy 3rd page black and white advbertisement, amader shomoy 3 number page advertisement, amader shomoy three number page black and white advertisement, publish advertisement at amader shomoy third page, advertisement cost at amader shomoy third page, amader shomoy third page advertisement rate, black and white advertisement at amader shomoy third page")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in amader shomoy third page")]
        //public ActionResult ThirdPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Amader Shomoy",
        //        AdLocation = "Amader Shomoy third page black and white advertisement",
        //        PriceDescription = 8000
        //    };
        //    return View(model);
        //}
        [SeoBaseTitle("Publish color advertisement in amader shomoy fifth page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy fifth page advertisement, amader shomoy fifth page  advertisement, amader shomoy 1st page advertisement,  amader shomoy 1st page color advbertisement, amader shomoy 5 number page advertisement, amader shomoy five number page color advertisement, publish advertisement at amader shomoy fifth page, advertisement cost at amader shomoy fifth page, amader shomoy fifth page advertisement rate, color advertisement at amader shomoy fifth page")]
        [SeoMetaDescription("Through Amader Ad publish your  advertisement in amader shomoy fifth page")]
        public ActionResult FifthPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy fifth page advertisement",
                PriceDescription = 6500 ,
                PriceDescriptionBlack = 5500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoBaseTitle("Publish black and white advertisement in amader shomoy fifth page through amader ad")]
        //[SeoMetaKeywords("amader ad amader shomoy fifth page advertisement, amader shomoy fifth page black and white advertisement, amader shomoy 5th page advertisement,  amader shomoy 5th page black and white advbertisement, amader shomoy 5 number page advertisement, amader shomoy five number page black and white advertisement, publish advertisement at amader shomoy fifth page, advertisement cost at amader shomoy fifth page, amader shomoy fifth page advertisement rate, black and white advertisement at amader shomoy fifth page")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in amader shomoy fifth page")]
        //public ActionResult FifthPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Amader Shomoy",
        //        AdLocation = "Amader Shomoy fifth page black and white advertisement",
        //        PriceDescription = 5500
        //    };
        //    return View(model);
        //}
        [SeoBaseTitle("Publish color advertisement in amader shomoy eight page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy eighth page advertisement, amader shomoy eighth page color advertisement, amader shomoy 8th page advertisement,  amader shomoy 8th page color advbertisement, amader shomoy 5 number page advertisement, amader shomoy eight number page color advertisement, publish advertisement at amader shomoy eighth page, advertisement cost at amader shomoy eighth page, amader shomoy eighth page advertisement rate, color advertisement at amader shomoy eighth page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in amader shomoy eighth page")]
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
        [SeoBaseTitle("Publish color advertisement in amader shomoy ten page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy tenth page advertisement, amader shomoy ten page color advertisement, amader shomoy 10th page advertisement,  amader shomoy 10th page color advbertisement, amader shomoy 10 number page advertisement, amader shomoy ten number page color advertisement, publish advertisement at amader shomoy tenth page, advertisement cost at amader shomoy tenth page, amader shomoy tenth page advertisement rate, color advertisement at amader shomoy tenth page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in amader shomoy tenth page")]
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
        [SeoBaseTitle("Publish color advertisement in amader shomoy second page")]
        [SeoMetaKeywords("amader ad amader shomoy second page advertisement, amader shomoy second page color advertisement, amader shomoy 2nd page advertisement,  amader shomoy 2nd page color advbertisement, amader shomoy 2 number page advertisement, amader shomoy second number page color advertisement, publish advertisement at amader shomoy second page, advertisement cost at amader shomoy second page, amader shomoy second page advertisement rate, color advertisement at amader shomoy second page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in amader shomoy second page")]
        public ActionResult SecondPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy second page color advertisement",
                PriceDescription = 6500,
                PriceDescriptionBlack = 5000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoBaseTitle("Publish black and white advertisement in amader shomoy second page through amader ad")]
        //[SeoMetaKeywords("amader ad amader shomoy second page advertisement, amader shomoy second page black and white advertisement, amader shomoy 2nd page advertisement,  amader shomoy 2nd page black and white advbertisement, amader shomoy 2 number page advertisement, amader shomoy second number page black and white advertisement, publish advertisement at amader shomoy second page, advertisement cost at amader shomoy second page, amader shomoy second page advertisement rate, black and white advertisement at amader shomoy second page")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in amader shomoy second page")]
        //public ActionResult SecondPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Amader Shomoy",
        //        AdLocation = "Amader Shomoy second page black and white advertisement",
        //        PriceDescription = 5000
        //    };
        //    return View(model);
        //}
        [SeoBaseTitle("Publish  advertisement in amader shomoy eleven page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy eleven page advertisement, amader shomoy eleven page  advertisement, amader shomoy 11th page advertisement,  amader shomoy 11th page color advbertisement, amader shomoy 11 number page advertisement, amader shomoy eleven number page color advertisement, publish advertisement at amader shomoy eleven page, advertisement cost at amader shomoy eleven page, amader shomoy eleven page advertisement rate, color advertisement at amader shomoy eleven page")]
        [SeoMetaDescription("Through Amader Ad publish your  advertisement in amader shomoy eleven page")]
        public ActionResult ElevenPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy eleven page  advertisement",
                PriceDescription = 6000,
                PriceDescriptionBlack = 4500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoBaseTitle("Publish black and white advertisement in amader shomoy eleven page through amader ad")]
        //[SeoMetaKeywords("amader ad amader shomoy eleven page advertisement, amader shomoy eleven page black and white advertisement, amader shomoy 11th page advertisement,  amader shomoy 11th page black and white advbertisement, amader shomoy 11 number page advertisement, amader shomoy eleven number page black and white advertisement, publish advertisement at amader shomoy eleven page, advertisement cost at amader shomoy eleven page, amader shomoy eleven page advertisement rate, black and white advertisement at amader shomoy eleven page")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in amader shomoy eleven page")]
        //public ActionResult ElevenPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Amader Shomoy",
        //        AdLocation = "Amader Shomoy eleven page black and white advertisement",
        //        PriceDescription = 4500
        //    };
        //    return View(model);
        //}
        [SeoBaseTitle("Publish advertisement in inner page of Amader Shomoy through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy inner page advertisement, amader shomoy inner page  advertisement, amader shomoy inner page advertisement, publish advertisement at amader shomoy inner page, advertisement cost at amader shomoy inner page, amader shomoy inner page advertisement rate, color advertisement at amader shomoy inner page")]
        [SeoMetaDescription("Through Amader Ad publish your  advertisement in amader shomoy inner page")]
        public ActionResult InnerPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy inner page advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoBaseTitle("Publish black and white advertisement in inner page of Amader Shomoy through amader ad")]
        //[SeoMetaKeywords("amader ad amader shomoy inner page advertisement, amader shomoy inner page black and white advertisement, amader shomoy inner page advertisement, publish advertisement at amader shomoy inner page, advertisement cost at amader shomoy inner page, amader shomoy inner page advertisement rate, black and white advertisement at amader shomoy inner page")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in amader shomoy inner page")]
        //public ActionResult InnerPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Amader Shomoy",
        //        AdLocation = "Amader Shomoy inner page black and white advertisement",
        //        PriceDescription = 4000
        //    };
        //    return View(model);
        //}
        #endregion

        #region spot ad
        [SeoBaseTitle("Publish spot advertisement in amader shomoy first page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy first page spot advertisement, amader shomoy first page spot advertisement, publish spot advertisement at amader shomoy first page,spot advertisement cost at amader shomoy first page, amader shomoy first page spot advertisement rate, spot advertisement at amader shomoy first page ")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in amader shomoy first page")]
        public ActionResult FirstPageSpotAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy first page spot advertisement",
                PriceDescription = 30000,

                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 4,
                MinMaxRestrictiion = true,
            };
            return View(model);
        }



        [SeoBaseTitle("Publish spot advertisement in amader shomoy last page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy last page spot advertisement, amader shomoy last page spot advertisement, publish spot advertisement at amader shomoy last page,spot advertisement cost at amader shomoy last page, amader shomoy last page spot advertisement rate, spot advertisement at amader shomoy last page")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in amader shomoy last page")]
        public ActionResult LastPageSpotAdvertisementMainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy last page spot advertisement",
                PriceDescription = 20000,
                // column inch restrictions
                MinTotalColumnInch = 1,
                MaxTotalColumnInch = 4,
                MinMaxRestrictiion = true,
            };
            return View(model);
        }


        #endregion
        #region SpecialKororpotro
        [SeoBaseTitle("Publish color advertisement in amader shomoy special kororpotro through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy bishesh korrorpotro advertisement,amader shomoy bisesh korrorpotro ad, amader shomoy bisesh korrorpotro color advertisement, amader shomoy bisesh korrorpotro 1st page ad,  amader shomoy bisesh korrorpotro 1st page color advertisement, amader shomoy bisesh orrorpotro 1 number page advertisement, amader shomoy bisesh korrorpotro one  number page color advertisement, publish advertisement at amader shomoy bisesh korrorpotro first page, advertisement cost at amader shomoy bisesh korrorpotro first  page, amader shomoy bisesh korrorpotro first page advertisement rate, color advertisement at amader shomoy bisesh korrorpotro first page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in bishesh korrorpotro page at amader shomoy")]
        public ActionResult SpecialKororpotroColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy special kororpotro color advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoBaseTitle("Publish black and white advertisement in amader shomoy special kororpotro through amader ad")]
        //[SeoMetaKeywords("amader ad amader shomoy bishesh korrorpotro advertisement,amader shomoy bisesh korrorpotro ad, amader shomoy bisesh korrorpotro black and white advertisement, amader shomoy bisesh korrorpotro 1st page ad,  amader shomoy bisesh korrorpotro 1st page black and white advertisement, amader shomoy bisesh orrorpotro 1 number page advertisement, amader shomoy bisesh korrorpotro one  number page black and white advertisement, publish advertisement at amader shomoy bisesh korrorpotro first page, advertisement cost at amader shomoy bisesh korrorpotro first  page, amader shomoy bisesh korrorpotro first page advertisement rate, black and white advertisement at amader shomoy bisesh korrorpotro first page")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in bishesh korrorpotro page at amader shomoy")]
        //public ActionResult SpecialKororpotroBlackandWhiteAdvertisement()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Amader Shomoy",
        //        AdLocation = "Amader Shomoy special kororpotro black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        #endregion
        #region Aynashomoy   
   
        [SeoBaseTitle("Publish color advertisement in ayna shomoy first page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy ayna shomoy first page advertisement, amader shomoy ayna shomoy first page color advertisement, amader shomoy ayna shomoy first page advertisement, publish advertisement at amader shomoy ayna shomoy first page, advertisement cost at amader shomoy ayna shomoy first page, amader shomoy ayna shomoy first page advertisement rate, color advertisement at amader shomoy ayna shomoy first page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in amader shomoy ayna shomoy first page")]
        public ActionResult AynashomoyFirstPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy ayna shomoy first page color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        [SeoBaseTitle("Publish color advertisement in ayna shomoy last page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy ayna shomoy last page advertisement, amader shomoy ayna shomoy last page color advertisement, amader shomoy ayna shomoy last page advertisement, publish advertisement at amader shomoy ayna shomoy last page, advertisement cost at amader shomoy ayna shomoy last page, amader shomoy ayna shomoy last page advertisement rate, color advertisement at amader shomoy ayna shomoy last page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in amader shomoy ayna shomoy last page")]
        public ActionResult AynashomoyLastPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy ayna shomoy last page color advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        [SeoBaseTitle("Publish color advertisement in ayna shomoy third page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy ayna shomoy third page advertisement, amader shomoy ayna shomoy third page color advertisement, amader shomoy ayna shomoy third page advertisement, publish advertisement at amader shomoy ayna shomoy third page, advertisement cost at amader shomoy ayna shomoy third page, amader shomoy ayna shomoy third page advertisement rate, color advertisement at amader shomoy ayna shomoy third page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in amader shomoy ayna shomoy third page")]
        public ActionResult AynashomoyThirdPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy ayna shomoy third page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        [SeoBaseTitle("Publish color advertisement in ayna shomoy general page through amader ad")]
        [SeoMetaKeywords("amader ad amader shomoy ayna shomoy general page advertisement, amader shomoy ayna shomoy general page color advertisement, amader shomoy ayna shomoy general page advertisement, publish advertisement at amader shomoy ayna shomoy general page, advertisement cost at amader shomoy ayna shomoy general page, amader shomoy ayna shomoy general page advertisement rate, color advertisement at amader shomoy ayna shomoy general page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in amader shomoy ayna shomoy general page")]
        public ActionResult AynashomoyGeneralPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy ayna shomoy general page color advertisement",
                PriceDescription = 4000
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
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy Govt. Advertisement",
                TitleDescription = "Govt. Advertisement At Amader Shomoy",
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
                NewspaperName = "Amader Shomoy",
                AdLocation = "Amader Shomoy- Govt. Commercial Advertisement",
                TitleDescription = "Govt. Commercial Advertisement At Amader Shomoy",
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