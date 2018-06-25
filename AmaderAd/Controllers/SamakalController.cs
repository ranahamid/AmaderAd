using AmaderAd.Models;
using AspNetSeo.Mvc;
using System.Web.Mvc;


namespace AmaderAd.Controllers
{
    public class SamakalController : BaseController
    {
        // GET: Samakal
        public ActionResult Index()
        {
            return View();
        }

        #region Classified
        //classified advertisement
        [SeoBaseTitle("Publish classified advertisement in Samakal through amader ad")]
        [SeoMetaKeywords("amader ad samakal classified advertisement,samakal classified ad, samakal classified advertisement,  publish classied advertisement at samakal , classified advertisement cost at samakal, samakal classified advertisement rate, classified advertisement at samakal, সমকালে  শ্রেণীভুক্ত বিজ্ঞাপন দিন,  rent at samakal,  house rent at samakal, publish rent advertisement at samakal, samakal rent advertisement, সমকাল বাড়ি ভাড়া বিজ্ঞাপন,  land slae advertisement at samakal, samakal land sale advertisement, samakal land sale ad cost, সমকালে জমি বিক্রয়ের বিজ্ঞাপন দিন,  miscellaneous sales advertisement at samakal, samakal miscellaneous slaes advetisement,  miscellaneous sales cost at samakal, publish miscellaneous advertisement at samakal, miscellaneous at samakal, সমকালে বিবিধ বিক্রয়ের বিজ্ঞাপন দিন, house sale advertisement at samakal, samakal house sales advertisement, house sales advertisement cost at samakal, publish house sale advertisement at samakal, house sale advertisement at samakal, সমকালে বাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  shop sale advertisement at samakal, samakal shop sales advertisement, shop sales advertisement cost at samakal, publish shop sale advertisement at samakal, house shop advertisement at samakal, সমকালে দোকান বিক্রয়ের বিজ্ঞাপন দিন, car sale advertisement at samakal, samakal car sales advertisement, car sales advertisement cost at samakal, publish car sale advertisement at samakal, car sale advertisement at samakal, সমকালে গাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  plot purchase advertisement at samakal, samakal plot purchase advertisement, plot purchase advertisement cost at samakal, publish plot purchase advertisement at samakal, plot purchase advertisement at samakal, সমকালে প্লট ক্রয়ের  বিজ্ঞাপন দিন, wanted advertisement at samakal, samakal wanted advertisement, wanted advertisement cost at samakal, publish wanted advertisement at samakal, wanted advertisement at samakal, tution wanted advertisement at samakal, samakal tution wante advertisement, tution wanted advertisement cost at samakal, publish tution wanted advertisement at samakal, tuiton wanted advertisement at samakal, সমকালে  পড়াতে চাই   বিজ্ঞাপন দিন,  groom wanted advertisement at samakal, samakal groom wanted advertisement, groom wanted advertisement cost at samakal, publish groom wanted advertisement at samakal, groom wnated advertisement at samakal, সমকালে  পাত্র চাই  বিজ্ঞাপন দিন,  bride wanted advertisement at samakal, samakal plot bride wanted advertisement, bride wanted  advertisement cost at samakal, bride wanted purchase advertisement at samakal, bride wanted  advertisement at samakal, সমকালে  পাত্রী চাই  বিজ্ঞাপন দিন, ")]
        [SeoMetaDescription("Through Amader Ad publish your classified advertisement samakal")]
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Classified Advertisement",
                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 20,
                PriceDescription = 400,
                ExtraWordPrice = 25,
                WordLimit = 10000,
                VAT = 0.15,
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        #endregion

        #region Main page
        [SeoMetaKeywords("amader ad samakal first page advertisement, samakal first page color advertisement, samakal 1st page advertisement,  samakal 1st page color advbertisement, samakal 1 number page advertisement, samakal one number page color advertisement, publish advertisement at samakal first page, advertisement cost at samakal first page, samakal first page advertisement rate, color advertisement at samakal first page")]
        [SeoTitle("Publish color advertisement in samakal first page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal first page")]
        public ActionResult FirstPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal First Page Color",
                PriceDescription = 16000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal last page advertisement, samakal last page color advertisement, samakal last page advertisement,  samakal last page color advbertisement, samakal last number page advertisement, samakal last number page color advertisement, publish advertisement at samakal last page, advertisement cost at samakal last page, samakal last page advertisement rate, color advertisement at samakal last page")]
        [SeoTitle("Publish color advertisement in samakal last page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal last page")]
        public ActionResult LastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal Last Page Color",
                PriceDescription = 14000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal third page advertisement, samakal third page color advertisement, samakal 3rd page advertisement,  samakal 3rd page color advbertisement, samakal 3 number page advertisement, samakal three number page color advertisement, publish advertisement at samakal third page, advertisement cost at samakal third page, samakal third page advertisement rate, color advertisement at samakal third page")]
        [SeoTitle("Publish color advertisement in samakal third page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal third page")]
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal third Page",
                PriceDescription = 10000,

                PriceDescriptionBlack = 7500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal third page advertisement, samakal third page black and white advertisement, samakal 3rd page advertisement,  samakal 3rd page black and white advbertisement, samakal 3 number page advertisement, samakal three number page black and white advertisement, publish advertisement at samakal third page, advertisement cost at samakal third page, samakal third page advertisement rate, black and white advertisement at samakal third page")]
        //[SeoTitle("Publish black & white advertisement in samakal third page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal third page")]
        //public ActionResult ThirdPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "Samakal third Page black and white",
        //        PriceDescription = 7500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad samakal fifth page advertisement, samakal fifth page color advertisement, samakal 5th page advertisement,  samakal 5th page color advbertisement, samakal 5 number page advertisement, samakal five number page color advertisement, publish advertisement at samakal fifth page, advertisement cost at samakal fifth page, samakal fifth page advertisement rate, color advertisement at samakal fifth page")]
        [SeoTitle("Publish color advertisement in samakal fifth page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal fifth page")]
        public ActionResult FifthPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal fifth Page Color",
                PriceDescription = 7500,

                PriceDescriptionBlack = 5000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal fifth page advertisement, samakal fifth page black and white advertisement, samakal 5th page advertisement,  samakal 5th page black and white advbertisement, samakal 5 number page advertisement, samakal five number page black and white advertisement, publish advertisement at samakal fifth page, advertisement cost at samakal fifth page, samakal fifth page advertisement rate, black and white advertisement at samakal fifth page")]
        //[SeoTitle("Publish black & white advertisement in samakal fifth page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal fifth page")]
        //public ActionResult FifthPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "Samakal fifth Page black and white",
        //        PriceDescription = 5000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad samakal entertainment page advertisement, samakal entertainment page color advertisement, samakal entertainment page advertisement, publish advertisement at samakal entertainment page, advertisement cost at samakal entertainment page, samakal entertainment page advertisement rate, color advertisement at samakal entertainment page")]
        [SeoTitle("Publish color advertisement in samakal entertainment page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal entertainment page")]
        public ActionResult EntertainmentPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal entertainment Page color",
                PriceDescription = 7000,

                PriceDescriptionBlack = 4500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal entertainment page advertisement, samakal entertainment page black and white advertisement, samakal entertainment page advertisement, publish advertisement at samakal entertainment page, advertisement cost at samakal entertainment page, samakal entertainment page advertisement rate, black and white advertisement at samakal entertainment page")]
        //[SeoTitle("Publish black & white advertisement in samakal entertainment page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal entertainment page")]
        //public ActionResult EntertainmentPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "Samakal entertainment Page black an white",
        //        PriceDescription = 4500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad samakal sports page advertisement, samakal sports page color advertisement, samakal sports page advertisement, publish advertisement at samakal sports page, advertisement cost at samakal sports page, samakal sports page advertisement rate, color advertisement at samakal sports page")]
        [SeoTitle("Publish color advertisement in samakal sports page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal sports page")]
        public ActionResult SportsPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal sports Page color",
                PriceDescription = 6500,

                PriceDescriptionBlack = 5500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal sports page advertisement, samakal sports page black and white advertisement, samakal sports page advertisement, publish advertisement at samakal sports page, advertisement cost at samakal sports page, samakal sports page advertisement rate, black and white advertisement at samakal sports page")]
        //[SeoTitle("Publish black & white advertisement in samakal sports page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal sports page")]
        //public ActionResult SportsPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "Samakal sports Page black and white",
        //        PriceDescription = 5500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad samakal second page advertisement, samakal second page color advertisement, samakal 2nd page advertisement,  samakal 2nd page color advertisement, samakal 2 number page advertisement, samakal second number page color advertisement, publish advertisement at samakal second page, advertisement cost at samakal second page, samakal second page advertisement rate, color advertisement at samakal second page")]
        [SeoTitle("Publish color advertisement in samakal second page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal second page")]
        public ActionResult SecondPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal second page color advertisement",
                PriceDescription = 8000,

                PriceDescriptionBlack = 6000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal second page advertisement, samakal second page black and white advertisement, samakal 2nd page advertisement,  samakal 2nd page black and white advbertisement, samakal 2 number page advertisement, samakal second number page black and white advertisement, publish advertisement at samakal second page, advertisement cost at samakal second page, samakal second page advertisement rate, black and white advertisement at samakal second page")]
        //[SeoTitle("Publish black & white advertisement in samakal second page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal second page")]
        //public ActionResult SecondPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal second page black and white advertisement",
        //        PriceDescription = 6000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad samakal page befor last page advertisement, samakal page befor last page color advertisement, samakal page befor last page advertisement, publish advertisement at samakal page befor last page, advertisement cost at samakal page befor last page, samakal page befor last page advertisement rate, color advertisement at samakal page befor last page")]
        [SeoTitle("Publish color advertisement in samakal page before last page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal page befor last page")]
        public ActionResult PageBeforeLastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal page befor last page color advertisement",
                PriceDescription = 7500,

                PriceDescriptionBlack = 5500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal page befor last page advertisement, samakal page befor last page black and white advertisement, samakal page befor last page advertisement, publish advertisement at samakal page befor last page, advertisement cost at samakal page befor last page, samakal page befor last page advertisement rate, black and white advertisement at samakal page befor last page")]
        //[SeoTitle("Publish black & white advertisement in samakal page before last page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal page befor last page")]
        //public ActionResult PageBeforeLastPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal page befor last page black and white advertisement",
        //        PriceDescription = 5500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad samakal inner other page advertisement, samakal inner other page color advertisement, samakal inner other page advertisement, publish advertisement at samakal inner other page, advertisement cost at samakal inner other page, samakal inner other page advertisement rate, color advertisement at samakal inner other page")]
        [SeoTitle("Publish color advertisement in samakal inner other page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal inner other page")]
        public ActionResult InnerOtherPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal inner other page color advertisement",
                PriceDescription = 5000,

                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal inner other page advertisement, samakal inner other page black and white advertisement, samakal inner other page advertisement, publish advertisement at samakal inner other page, advertisement cost at samakal inner other page, samakal inner other page advertisement rate, black and white advertisement at samakal inner other page")]
        //[SeoTitle("Publish black & white advertisement in samakal inner other page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal inner other page")]
        //public ActionResult InnerOtherPageBlackandWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal inner other page black and white advertisement",
        //        PriceDescription = 4000
        //    };
        //    return View(model);
        //}
        #endregion

        #region KalerKheya

        [SeoMetaKeywords("amader ad samakal magazine shahitto shamoyiki kaler kheya inner full page advertisement, samakal magazine shahitto shamoyiki kaler kheya inner full page color advertisement, samakal magazine shahitto shamoyiki kaler kheya inner full page advertisement, publish advertisement at samakal magazine shahitto shamoyiki kaler kheya inner full page, advertisement cost at samakal magazine shahitto shamoyiki kaler kheya inner full page, samakal magazine shahitto shamoyiki kaler kheya inner full page advertisement rate, color advertisement at samakal magazine shahitto shamoyiki kaler kheya inner full page")]
        [SeoTitle("Publish color advertisement in samakal magazine shahitto shamoyiki kaler kheya inner full page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal magazine shahitto shamoyiki kaler kheya inner full page")]
        public ActionResult MagazineShahittoShamoyikikalerkheyaInnerFullPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya inner full page  advertisement",
                PriceDescription = 25000,
                PriceDescriptionBlack = 20000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal magazine shahitto shamoyiki kaler kheya inner full page advertisement, samakal magazine shahitto shamoyiki kaler kheya inner full page black and white advertisement, samakal magazine shahitto shamoyiki kaler kheya inner full page advertisement, publish advertisement at samakal magazine shahitto shamoyiki kaler kheya inner full page, advertisement cost at samakal magazine shahitto shamoyiki kaler kheya inner full page, samakal magazine shahitto shamoyiki kaler kheya inner full page advertisement rate, black and white advertisement at samakal magazine shahitto shamoyiki kaler kheya inner full page")]
        //[SeoTitle("Publish black & white advertisement in samakal magazine shahitto shamoyiki kaler kheya page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal magazine shahitto shamoyiki kaler kheya inner full page")]
        //public ActionResult MagazineShahittoShamoyikiKalerkheyaInnerFullPageBlackandWhiteAdvertisement()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal magazine shahitto shamoyiki kalerkheya inner full page black and white advertisement",
        //        PriceDescription = 20000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad samakal magazine shahitto shamoyiki kaler kheya inner half page advertisement, samakal magazine shahitto shamoyiki kaler kheya inner half page color advertisement, samakal magazine shahitto shamoyiki kaler kheya inner half page advertisement, publish advertisement at samakal magazine shahitto shamoyiki kaler kheya inner half page, advertisement cost at samakal magazine shahitto shamoyiki kaler kheya inner half page, samakal magazine shahitto shamoyiki kaler kheya inner half page advertisement rate, color advertisement at samakal magazine shahitto shamoyiki kaler kheya inner half page")]
        [SeoTitle("Publish color advertisement in samakal magazine shahitto shamoyiki kaler kheya inner half page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal magazine shahitto shamoyiki kaler kheya inner half page")]
        public ActionResult MagazineshahittoShamoyikikalerkheyaInnerHalfPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya inner half page color advertisement",
                PriceDescription = 15000,
                PriceDescriptionBlack = 10000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal magazine shahitto shamoyiki kaler kheya inner half page advertisement, samakal magazine shahitto shamoyiki kaler kheya inner half page black and white advertisement, samakal magazine shahitto shamoyiki kaler kheya inner half page advertisement, publish advertisement at samakal magazine shahitto shamoyiki kaler kheya inner half page, advertisement cost at samakal magazine shahitto shamoyiki kaler kheya inner half page, samakal magazine shahitto shamoyiki kaler kheya inner half page advertisement rate, black and white advertisement at samakal magazine shahitto shamoyiki kaler kheya inner half page")]
        //[SeoTitle("Publish black & white advertisement in samakal magazine shahitto shamoyiki kaler kheya inner half page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal magazine shahitto shamoyiki kaler kheya inner half page")]
        //public ActionResult MagazineShahittoShamoyikiKalerkheyaInnerHalfPageBlackandWhiteAdvertisement()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal magazine shahitto shamoyiki kaler kheya inner half page black and white advertisement",
        //        PriceDescription = 10000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad samakal magazine shahitto shamoyiki kaler kheya first cover page advertisement, samakal magazine shahitto shamoyiki kaler kheya first cover page color advertisement, samakal magazine shahitto shamoyiki kaler kheya first cover page advertisement, publish advertisement at samakal magazine shahitto shamoyiki kaler kheya first cover page, advertisement cost at samakal magazine shahitto shamoyiki kaler kheya first cover page, samakal magazine shahitto shamoyiki kaler kheya first cover page advertisement rate, color advertisement at samakal magazine shahitto shamoyiki kaler kheya first cover page")]
        [SeoTitle("Publish color advertisement in samakal magazine shahitto shamoyiki kaler kheya first cover through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal magazine shahitto shamoyiki kaler kheya first cover page")]
        public ActionResult MagazineShahittoShamoyikiKalerKheyaFirstCoverColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya first cover color advertisement",
                PriceDescription = 50000,
                PriceDescriptionBlack = 10000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal magazine shahitto shamoyiki kaler kheya last cover page advertisement, samakal magazine shahitto shamoyiki kaler kheya last cover page color advertisement, samakal magazine shahitto shamoyiki kaler kheya last cover page advertisement, publish advertisement at samakal magazine shahitto shamoyiki kaler kheya last cover page, advertisement cost at samakal magazine shahitto shamoyiki kaler kheya last cover page, samakal magazine shahitto shamoyiki kaler kheya last cover page advertisement rate, color advertisement at samakal magazine shahitto shamoyiki kaler kheya last cover page")]
        //[SeoTitle("Publish color advertisement in samakal magazine shahitto shamoyiki kaler kheya last cover through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal magazine shahitto shamoyiki kaler kheya last cover page")]
        //public ActionResult MagazineShahittoShamoyikiKalerKheyaLastCoverColorAdvertisement()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal magazine shahitto shamoyiki kaler kheya last-cover color advertisement",
        //        PriceDescription = 40000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad samakal magazine shahitto shamoyiki kaler kheya second cover page advertisement, samakal magazine shahitto shamoyiki kaler kheya second cover page black and white advertisement, samakal magazine shahitto shamoyiki kaler kheya second cover page advertisement, publish advertisement at samakal magazine shahitto shamoyiki kaler kheya second cover page, advertisement cost at samakal magazine shahitto shamoyiki kaler kheya second cover page, samakal magazine shahitto shamoyiki kaler kheya second cover page advertisement rate, black and white advertisement at samakal magazine shahitto shamoyiki kaler kheya second cover page")]
        [SeoTitle("Publish black & white advertisement in samakal magazine shahitto shamoyiki kaler kheya second cover through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal magazine shahitto shamoyiki kaler kheya second cover page")]
        public ActionResult MagazineShahittoShamoyikiKalerKheyaSecondCoverBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya second cover black and white advertisement",
                PriceDescription = 30000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal magazine shahitto shamoyiki kaler kheya third cover page advertisement, samakal magazine shahitto shamoyiki kaler kheya third cover page black and white advertisement, samakal magazine shahitto shamoyiki kaler kheya third cover page advertisement, publish advertisement at samakal magazine shahitto shamoyiki kaler kheya third cover page, advertisement cost at samakal magazine shahitto shamoyiki kaler kheya third cover page, samakal magazine shahitto shamoyiki kaler kheya third cover page advertisement rate, black and white advertisement at samakal magazine shahitto shamoyiki kaler kheya third cover page")]
        [SeoTitle("Publish black & white advertisement in samakal magazine shahitto shamoyiki kaler kheya third cover through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal magazine shahitto shamoyiki kaler kheya third cover page")]
        public ActionResult MagazineShahittoshamoyikiKalerKheyaThirdCoverBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya third cover black and white advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal magazine shahitto shamoyiki kaler kheya middle two full page advertisement, samakal magazine shahitto shamoyiki kaler kheya middle two full page black and white advertisement, samakal magazine shahitto shamoyiki kaler kheya middle two full page advertisement, publish advertisement at samakal magazine shahitto shamoyiki kaler kheya middle two full page, advertisement cost at samakal magazine shahitto shamoyiki kaler kheya middle two full page, samakal magazine shahitto shamoyiki kaler kheya middle two full page advertisement rate, black and white advertisement at samakal magazine shahitto shamoyiki kaler kheya middle two full page")]
        [SeoTitle("Publish color advertisement in samakal magazine shahitto shamoyiki kaler kheya middle two full page together through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal magazine shahitto shamoyiki kaler kheya middle two full page")]
        public ActionResult MagazineShahittoShamoyikiKalerKheyaMiddleTwoFullPageTogetherColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya middle two full page together color advertisement",
                PriceDescription = 45000
            };
            return View(model);
        }
        #endregion

        #region pechal


        [SeoMetaKeywords("amader ad samakal magazine rommo shamoyiki pechal inner full page advertisement, samakal magazine rommo shamoyiki pechal inner full page color advertisement, samakal magazine rommo shamoyiki pechal inner full page advertisement, publish advertisement at samakal magazine rommo shamoyiki pechal inner full page, advertisement cost at samakal magazine rommo shamoyiki pechal inner full page, samakal magazine rommo shamoyiki pechal inner full page advertisement rate, color advertisement at samakal magazine rommo shamoyiki pechal inner full page")]
        [SeoTitle("Publish color advertisement in samakal magazine rommo shamoyiki pechal inner full page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal magazine rommo shamoyiki pechal inner full page")]
        public ActionResult MagazineRommoShamoyikiPechalInnerFullPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal inner full page color advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal magazine rommo shamoyiki pechal inner full page advertisement, samakal magazine rommo shamoyiki pechal inner full page black and white advertisement, samakal magazine rommo shamoyiki pechal inner full page advertisement, publish advertisement at samakal magazine rommo shamoyiki pechal inner full page, advertisement cost at samakal magazine rommo shamoyiki pechal inner full page, samakal magazine rommo shamoyiki pechal inner full page advertisement rate, black and white advertisement at samakal magazine rommo shamoyiki pechal inner full page")]
        //[SeoTitle("Publish black & white advertisement in samakal magazine rommo shamoyiki pechal page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal magazine rommo shamoyiki pechal inner full page")]
        //public ActionResult MagazineRommoShamoyikiPechalInnerFullPageBlackandWhiteAdvertisement()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal magazine rommo shamoyiki pechal inner full page black and white advertisement",
        //        PriceDescription = 20000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad samakal magazine rommo shamoyiki pechal inner half page advertisement, samakal magazine rommo shamoyiki pechal inner half page color advertisement, samakal magazine rommo shamoyiki pechal inner half page advertisement, publish advertisement at samakal magazine rommo shamoyiki pechal inner half page, advertisement cost at samakal magazine rommo shamoyiki pechal inner half page, samakal magazine rommo shamoyiki pechal inner half page advertisement rate, color advertisement at samakal magazine rommo shamoyiki pechal inner half page")]
        [SeoTitle("Publish color advertisement in samakal magazine rommo shamoyiki pechal inner half page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal magazine rommo shamoyiki pechal inner half page")]
        public ActionResult MagazineRommoShamoyikiPechalInnerHalfPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal inner half page color advertisement",
                PriceDescription = 15000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal magazine rommo shamoyiki pechal inner half page advertisement, samakal magazine rommo shamoyiki pechal inner half page black and white advertisement, samakal magazine rommo shamoyiki pechal inner half page advertisement, publish advertisement at samakal magazine rommo shamoyiki pechal inner half page, advertisement cost at samakal magazine rommo shamoyiki pechal inner half page, samakal magazine rommo shamoyiki pechal inner half page advertisement rate, black and white advertisement at samakal magazine rommo shamoyiki pechal inner half page")]
        [SeoTitle("Publish black & white advertisement in samakal magazine rommo shamoyiki pechal inner half page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal magazine rommo shamoyiki pechal inner half page")]
        public ActionResult MagazineRommoShamoyikiPechalInnerHalfPageBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal inner half page black and white advertisement",
                PriceDescription = 10000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal magazine rommo shamoyiki pechal first cover page advertisement, samakal magazine rommo shamoyiki pechal first cover page color advertisement, samakal magazine rommo shamoyiki pechal first cover page advertisement, publish advertisement at samakal magazine rommo shamoyiki pechal first cover page, advertisement cost at samakal magazine rommo shamoyiki pechal first cover page, samakal magazine rommo shamoyiki pechal first cover page advertisement rate, color advertisement at samakal magazine rommo shamoyiki pechal first cover page")]
        [SeoTitle("Publish color advertisement in samakal magazine rommo shamoyiki pechal first cover through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal magazine rommo shamoyiki pechal first cover page")]
        public ActionResult MagazineRommoShamoyikiPechalFirstCoverColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal first cover color advertisement",
                PriceDescription = 50000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal magazine rommo shamoyiki pechal last cover page advertisement, samakal magazine rommo shamoyiki pechal last cover page color advertisement, samakal magazine rommo shamoyiki pechal last cover page advertisement, publish advertisement at samakal magazine rommo shamoyiki pechal last cover page, advertisement cost at samakal magazine rommo shamoyiki pechal last cover page, samakal magazine rommo shamoyiki pechal last cover page advertisement rate, color advertisement at samakal magazine rommo shamoyiki pechal last cover page")]
        [SeoTitle("Publish color advertisement in samakal magazine rommo shamoyiki pechal last cover page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal magazine rommo shamoyiki pechal last cover page")]
        public ActionResult MagazineRommoShamoyikiPechalLastCoverColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal last cover color advertisement",
                PriceDescription = 40000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal magazine rommo shamoyiki pechal second cover page advertisement, samakal magazine rommo shamoyiki pechal second cover page black and white advertisement, samakal magazine rommo shamoyiki pechal second cover page advertisement, publish advertisement at samakal magazine rommo shamoyiki pechal second cover page, advertisement cost at samakal magazine rommo shamoyiki pechal second cover page, samakal magazine rommo shamoyiki pechal second cover page advertisement rate, black and white advertisement at samakal magazine rommo shamoyiki pechal second cover page")]
        [SeoTitle("Publish black & white advertisement in samakal magazine rommo shamoyiki pechal second cover through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal magazine rommo shamoyiki pechal second cover page")]
        public ActionResult MagazineRommoShamoyikiPechalSecondCoverBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki-pechal second cover black and white advertisement",
                PriceDescription = 30000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal magazine rommo shamoyiki pechal third cover page advertisement, samakal magazine rommo shamoyiki pechal third cover page black and white advertisement, samakal magazine rommo shamoyiki pechal third cover page advertisement, publish advertisement at samakal magazine rommo shamoyiki pechal third cover page, advertisement cost at samakal magazine rommo shamoyiki pechal third cover page, samakal magazine rommo shamoyiki pechal third cover page advertisement rate, black and white advertisement at samakal magazine rommo shamoyiki pechal third cover page")]
        [SeoTitle("Publish black & white advertisement in samakal magazine rommo shamoyiki pechal third cover through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal magazine rommo shamoyiki pechal third cover page")]
        public ActionResult MagazineRommoShamoyikiPechalThirdCoverBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal third cover black and white advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal magazine rommo shamoyiki pechal middle two full page advertisement, samakal magazine rommo shamoyiki pechal middle two full page color advertisement, samakal magazine rommo shamoyiki pechal middle two full page advertisement, publish advertisement at samakal magazine rommo shamoyiki pechal middle two full page, advertisement cost at samakal magazine rommo shamoyiki pechal middle two full page, samakal magazine rommo shamoyiki pechal middle two full page advertisement rate, color advertisement at samakal magazine rommo shamoyiki pechal middle two full page")]
        [SeoTitle("Publish color advertisement in samakal magazine rommo shamoyiki pechal middle two full page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal magazine rommo shamoyiki pechal middle two full page")]
        public ActionResult MagazineRommoShamoyikiPechalMiddleTwoFullPageTogetherColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal middle two full page together color advertisement",
                PriceDescription = 45000
            };
            return View(model);
        }
        #endregion

        #region Shoili

        [SeoMetaKeywords("amader ad samakal shoily first page advertisement, samakal shoily first page color advertisement, samakal shoily first page advertisement, publish advertisement at samakal shoily first page, advertisement cost at samakal shoily first page, samakal shoily first page advertisement rate, color advertisement at samakal shoily first page")]
        [SeoTitle("Publish color advertisement in shoily first page at samakal through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal shoily first page")]
        public ActionResult ShoiliFirstPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal shoili first page color advertisement",
                PriceDescription = 7500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal shoily last page advertisement, samakal shoily last page color advertisement, samakal shoily last page advertisement, publish advertisement at samakal shoily last page, advertisement cost at samakal shoily last page, samakal shoily last page advertisement rate, color advertisement at samakal shoily last page")]
        [SeoTitle("Publish color advertisement in shoily last page at samakal through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal shoily last page")]
        public ActionResult ShoiliLastPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal shoili last page color advertisement",
                PriceDescription = 6500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal shoily inner page advertisement, samakal shoily inner page color advertisement, samakal shoily inner page advertisement, publish advertisement at samakal shoily inner page, advertisement cost at samakal shoily inner page, samakal shoily inner page advertisement rate, color advertisement at samakal shoily inner page")]
        [SeoTitle("Publish color advertisement in shoily inner page at samakal through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal shoily inner page")]
        public ActionResult ShoiliInnerPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal shoili inner page color advertisement",
                PriceDescription = 5500,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal shoily inner page advertisement, samakal shoily inner page black and white advertisement, samakal shoily inner page advertisement, publish advertisement at samakal shoily inner page, advertisement cost at samakal shoily inner page, samakal shoily inner page advertisement rate, black and white advertisement at samakal shoily inner page")]
        //[SeoTitle("Publish black & white advertisement in shoily inner page at samakal through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal shoily inner page")]
        //public ActionResult ShoiliInnerPageBlackandWhiteAdvertisement()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal shoili inner page black and white advertisement",
        //        PriceDescription = 4000
        //    };
        //    return View(model);
        //}
        #endregion

        #region Nondon

        [SeoMetaKeywords("amader ad samakal nondon shonskrity o binodon shamoyiki first page advertisement, samakal nondon shonskrity o binodon shamoyiki first page color advertisement, samakal nondon shonskrity o binodon shamoyiki first page advertisement, publish advertisement at samakal nondon shonskrity o binodon shamoyiki first page, advertisement cost at samakal nondon shonskrity o binodon shamoyiki first page, samakal nondon shonskrity o binodon shamoyiki first page advertisement rate, color advertisement at samakal nondon shonskrity o binodon shamoyiki first page")]
        [SeoTitle("Publish color advertisement in nondon shonskrity o binodon shamoyiki first page at samakal through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal nondon shonskrity o binodon shamoyiki first page")]
        public ActionResult NondonShonskritiOBinodonShamoyikiFirstPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal nondon shonskriti o binodon shamoyiki first page color advertisement",
                PriceDescription = 7500
            };
            return View(model);
        }

        [SeoMetaKeywords("amader ad samakal nondon shonskrity o binodon shamoyiki last page advertisement, samakal nondon shonskrity o binodon shamoyiki last page color advertisement, samakal nondon shonskrity o binodon shamoyiki last page advertisement, publish advertisement at samakal nondon shonskrity o binodon shamoyiki last page, advertisement cost at samakal nondon shonskrity o binodon shamoyiki last page, samakal nondon shonskrity o binodon shamoyiki last page advertisement rate, color advertisement at samakal nondon shonskrity o binodon shamoyiki last page")]
        [SeoTitle("Publish color advertisement in nondon shonskrity o binodon shamoyiki last page at samakal through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal nondon shonskrity o binodon shamoyiki last page")]
        public ActionResult NondonShonskritiOBinodonShamoyikiLastPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal nondon shonskriti o binodon shamoyiki last page color advertisement",
                PriceDescription = 6500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal nondon shonskrity o binodon shamoyiki inner page advertisement, samakal nondon shonskrity o binodon shamoyiki inner page color advertisement, samakal nondon shonskrity o binodon shamoyiki inner page advertisement, publish advertisement at samakal nondon shonskrity o binodon shamoyiki inner page, advertisement cost at samakal nondon shonskrity o binodon shamoyiki inner page, samakal nondon shonskrity o binodon shamoyiki inner page advertisement rate, color advertisement at samakal nondon shonskrity o binodon shamoyiki inner page")]
        [SeoTitle("Publish color advertisement in nondon shonskrity o binodon shamoyiki inner page at samakal through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal nondon shonskrity o binodon shamoyiki inner page")]
        public ActionResult NondonShonskritiOBinodonShamoyikiInnerPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal nondon shonskriti o binodon shamoyiki inner page color advertisement",
                PriceDescription = 5500,
                PriceDescriptionBlack = 4000,
                IsColor = true,
        
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal nondon shonskrity o binodon shamoyiki inner page advertisement, samakal nondon shonskrity o binodon shamoyiki inner page black and white advertisement, samakal nondon shonskrity o binodon shamoyiki inner page advertisement, publish advertisement at samakal nondon shonskrity o binodon shamoyiki inner page, advertisement cost at samakal nondon shonskrity o binodon shamoyiki inner page, samakal nondon shonskrity o binodon shamoyiki inner page advertisement rate, black and white advertisement at samakal nondon shonskrity o binodon shamoyiki inner page")]
        //[SeoTitle("Publish black & white advertisement in nondon shonskrity o binodon shamoyiki inner page at samakal through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal nondon shonskrity o binodon shamoyiki inner page")]
        //public ActionResult NondonShonskritiOBinodonShamoyikiInnerPageBlackandWhiteAdvertisement()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal nondon shonskriti o,binodon shamoyiki inner page black and white advertisement",
        //        PriceDescription = 4000
        //    };
        //    return View(model);
        //}
        #endregion

        #region KholaHawaGhash


        [SeoMetaKeywords("amader ad samakal khola hawa ghash foring biggan boloy and dehoghori page advertisement, samakal khola hawa ghash foring biggan boloy and dehoghori page color advertisement, samakal khola hawa, ghash foring, biggan boloy and dehoghori page advertisement, publish advertisement at samakal khola hawa, ghash foring, biggan boloy and dehoghori page, advertisement cost at samakal khola hawa, ghash foring, biggan boloy and dehoghori page, samakal khola hawa ghash foring biggan boloy and dehoghori page advertisement rate, color advertisement at samakal khola hawa ghash foring biggan boloy and dehoghori page")]
        [SeoTitle("Publish color advertisement in samakal feature page khola hawa, ghash foring, biggan boloy and dehoghori through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal khola hawa, ghash foring, biggan boloy and dehoghori page")]
        public ActionResult KholaHawaGhashForingBigganBoloyDehoghoriFeaturePagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal khola hawa ghash foring biggan boloy deho ghori feature page color advertisement",
                PriceDescription = 5500,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal khola hawa ghash foring biggan boloy and dehoghori page advertisement, samakal khola hawa ghash foring biggan boloy and dehoghori page black and white advertisement, samakal khola hawa ghash foring biggan boloy and dehoghori page advertisement, publish advertisement at samakal khola hawa ghash foring biggan boloy and dehoghori page, advertisement cost at samakal khola hawa ghash foring biggan boloy and dehoghori page, samakal khola hawa ghash foring biggan boloy and dehoghori page advertisement rate, black and white advertisement at samakal khola hawa ghash foring biggan boloy and dehoghori page ")]
        //[SeoTitle("Publish black & white advertisement in samakal feature page khola hawa, ghash foring, biggan boloy and dehoghori through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal khola hawa, ghash foring, biggan boloy and dehoghori page")]
        //public ActionResult KholaHawaGhashForingBigganBoloyDehoghoriFeaturePageblackandwhiteadvertisement()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal khola hawa ghash foring biggan boloy deho ghori feature page black and white advertisement",
        //        PriceDescription = 4000
        //    };
        //    return View(model);
        //}


        #endregion

        #region AlorPothJatri

        [SeoMetaKeywords("amader ad samakal alor poth jatri page advertisement, samakal alor poth jatri page color advertisement, samakal alor poth jatri page advertisement, publish advertisement at samakal alor poth jatri page, advertisement cost at samakal alor poth jatri page, samakal alor poth jatri page advertisement rate, color advertisement at samakal alor poth jatri page")]
        [SeoTitle("Publish color advertisement in samakal feature page alor poth jatri through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal alor poth jatri page")]
        public ActionResult AlorPothJatriFeaturePageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal alor poth jatri feature page color advertisement",
                PriceDescription = 5500,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal alor poth jatri page advertisement, samakal alor poth jatri page black and white advertisement, samakal alor poth jatri page advertisement, publish advertisement at samakal alor poth jatri page, advertisement cost at samakal alor poth jatri page, samakal alor poth jatri page advertisement rate, black and white advertisement at samakal alor poth jatri page")]
        //[SeoTitle("Publish black & white advertisement in samakal feature page alor poth jatri through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal alor poth jatri page")]
        //public ActionResult AlorPothJatriFeaturePageBlackandWhiteAdvertisement()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal alor poth jatri feature page black and white advertisement",
        //        PriceDescription = 4000
        //    };
        //    return View(model);
        //}
        #endregion

        #region MoncherbaireSuhridShomabeshTech
        [SeoMetaKeywords("amader ad samakal moncher baire suhrid shomabesh and tech line page advertisement, samakal moncher baire suhrid shomabesh and tech line page color advertisement, samakal moncher baire suhrid shomabesh and tech line page advertisement, publish advertisement at samakal moncher baire suhrid shomabesh and tech line page, advertisement cost at samakal moncher baire suhrid shomabesh and tech line page, samakal moncher baire suhrid shomabesh and tech line page advertisement rate, color advertisement at samakal moncher baire suhrid shomabesh and tech line page")]
        [SeoTitle("Publish color advertisement in samakal feature page moncher baire suhrid shomabesh and tech line through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal moncher baire suhrid shomabesh and tech line page")]
        public ActionResult MoncherbaireSuhridShomabeshTechLineFeaturePageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal moncher baire suhrid shomabesh tech line feature page color advertisement",
                PriceDescription = 5500,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad samakal moncher baire suhrid shomabesh and tech line page advertisement, samakal moncher baire suhrid shomabesh and tech line page black and white advertisement, samakal moncher baire suhrid shomabesh and tech line page advertisement, publish advertisement at samakal moncher baire suhrid shomabesh and tech line page, advertisement cost at samakal moncher baire suhrid shomabesh and tech line page, samakal moncher baire suhrid shomabesh and tech line page advertisement rate, black and white advertisement at samakal moncher baire suhrid shomabesh and tech line page")]
        //[SeoTitle("Publish black & white advertisement in samakal feature page moncher baire suhrid shomabesh and tech line through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in samakal moncher baire suhrid shomabesh and tech line page")]
        //public ActionResult MoncherbaireSuhridShomabeshTechLineFeaturePageblackandwhiteadvertisement()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Samakal",
        //        AdLocation = "samakal monche -baire suhrid shomabesh tech line feature page black and white advertisement",
        //        PriceDescription = 4000
        //    };
        //    return View(model);
        //}
        #endregion


        #region DehoGhori

        [SeoMetaKeywords("amader ad samakal moncher baire suhrid shomabesh and tech line page advertisement, samakal moncher baire suhrid shomabesh and tech line page color advertisement, samakal moncher baire suhrid shomabesh and tech line page advertisement, publish advertisement at samakal moncher baire suhrid shomabesh and tech line page, advertisement cost at samakal moncher baire suhrid shomabesh and tech line page, samakal moncher baire suhrid shomabesh and tech line page advertisement rate, color advertisement at samakal moncher baire suhrid shomabesh and tech line page")]
        [SeoTitle("Publish color advertisement in samakal feature page moncher baire suhrid shomabesh and tech line through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal moncher baire suhrid shomabesh and tech line page")]
        public ActionResult DehoGhori()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal Deho Ghori",
                PriceDescription = 5500,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }

        #endregion

        #region Kichu Bolte Chai
        [SeoMetaKeywords("amader ad samakal moncher baire suhrid shomabesh and tech line page advertisement, samakal moncher baire suhrid shomabesh and tech line page color advertisement, samakal moncher baire suhrid shomabesh and tech line page advertisement, publish advertisement at samakal moncher baire suhrid shomabesh and tech line page, advertisement cost at samakal moncher baire suhrid shomabesh and tech line page, samakal moncher baire suhrid shomabesh and tech line page advertisement rate, color advertisement at samakal moncher baire suhrid shomabesh and tech line page")]
        [SeoTitle("Publish color advertisement in samakal feature page moncher baire suhrid shomabesh and tech line through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal moncher baire suhrid shomabesh and tech line page")]
        public ActionResult KichuBolteChai()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal Kichu Bolte Chai",
                PriceDescription = 5500,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }


        #endregion

        #region Surido Somabesh
        [SeoMetaKeywords("amader ad samakal moncher baire suhrid shomabesh and tech line page advertisement, samakal moncher baire suhrid shomabesh and tech line page color advertisement, samakal moncher baire suhrid shomabesh and tech line page advertisement, publish advertisement at samakal moncher baire suhrid shomabesh and tech line page, advertisement cost at samakal moncher baire suhrid shomabesh and tech line page, samakal moncher baire suhrid shomabesh and tech line page advertisement rate, color advertisement at samakal moncher baire suhrid shomabesh and tech line page")]
        [SeoTitle("Publish color advertisement in samakal feature page moncher baire suhrid shomabesh and tech line through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal moncher baire suhrid shomabesh and tech line page")]
        public ActionResult SuridoSomabesh()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal Surido Somabesh",
                PriceDescription = 5500,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }


        #endregion


        #region Priyo Campus
        [SeoMetaKeywords("amader ad samakal moncher baire suhrid shomabesh and tech line page advertisement, samakal moncher baire suhrid shomabesh and tech line page color advertisement, samakal moncher baire suhrid shomabesh and tech line page advertisement, publish advertisement at samakal moncher baire suhrid shomabesh and tech line page, advertisement cost at samakal moncher baire suhrid shomabesh and tech line page, samakal moncher baire suhrid shomabesh and tech line page advertisement rate, color advertisement at samakal moncher baire suhrid shomabesh and tech line page")]
        [SeoTitle("Publish color advertisement in samakal feature page moncher baire suhrid shomabesh and tech line through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in samakal moncher baire suhrid shomabesh and tech line page")]
        public ActionResult Campus()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal Priyo Campus",
                PriceDescription = 5500,
                PriceDescriptionBlack = 4000,
                IsColor = true,
            };
            return View(model);
        }


        #endregion


        #region Spot

        [SeoMetaKeywords("amader ad samakal first page spot advertisement, samakal first page spot advertisement, publish spot advertisement at samakal first page,spot advertisement cost at samakal first page, samakal first page spot advertisement rate, spot advertisement at samakal first page")]
        [SeoTitle("Publish Spot advertisement in samakal first page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in samakal first page")]
        public ActionResult FirstPageSpotAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal first page spot advertisement",
                PriceDescription = 35000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal last page spot advertisement, samakal last page spot advertisement, publish spot advertisement at samakal last page,spot advertisement cost at samakal last page, samakal last page spot advertisement rate, spot advertisement at samakal last page")]
        [SeoTitle("Publish Spot advertisement in samakal last page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in samakal last page")]
        public ActionResult LastPageSpotAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal last page spot advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad samakal sports page spot advertisement, samakal sports page spot advertisement, publish spot advertisement at samakal sports page,spot advertisement cost at samakal sports page, samakal sports page spot advertisement rate, spot advertisement at samakal sports page")]
        [SeoTitle("Publish Spot advertisement in samakal sports page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in samakal sports page")]
        public ActionResult SportsPageSpotAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal sports page spot advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        #endregion


    }
}