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

        #region Classified
        //classified advertisement
        [SeoMetaKeywords("amader ad manab zamin classified advertisement,manab zamin classified ad, manab zamin classified advertisement,  publish classied advertisement at manab zamin , classified advertisement cost at manab zamin, manab zamin classified advertisement rate, classified advertisement at manab zamin, মানবজমিনে  শ্রেণীভুক্ত বিজ্ঞাপন দিন,  rent at manab zamin,  house rent at manab zamin, publish rent advertisement at manab zamin, manab zamin rent advertisement, ইত্তেফাক বাড়ি ভাড়া বিজ্ঞাপন,  land slae advertisement at manab zamin, manab zamin land sale advertisement, manab zamin land sale ad cost, মানবজমিনে জমি বিক্রয়ের বিজ্ঞাপন দিন,  miscellaneous sales advertisement at manab zamin, manab zamin miscellaneous slaes advetisement,  miscellaneous sales cost at manab zamin, publish miscellaneous advertisement at manab zamin, miscellaneous at manab zamin, মানবজমিনে বিবিধ বিক্রয়ের বিজ্ঞাপন দিন, house sale advertisement at manab zamin, manab zamin alo house sales advertisement, house sales advertisement cost at manab zamin, publish house sale advertisement at manab zamin, house sale advertisement at manab zamin, মানবজমিনে বাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  shop sale advertisement at manab zamin, manab zamin shop sales advertisement, shop sales advertisement cost at manab zamin, publish shop sale advertisement at manab zamin, house shop advertisement at manab zamin, মানবজমিনে দোকান বিক্রয়ের বিজ্ঞাপন দিন,    car sale advertisement at manab zamin, manab zamin car sales advertisement, car sales advertisement cost at manab zamin, publish car sale advertisement at manab zamin, car sale advertisement at manab zamin, মানবজমিনে গাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  plot purchase advertisement at manab zamin, manab zamin plot purchase advertisement, plot purchase advertisement cost at manab zamin, publish plot purchase advertisement at manab zamin, plot purchase advertisement at manab zamin, মানবজমিনে প্লট ক্রয়ের  বিজ্ঞাপন দিন, 	 wanted advertisement at manab zamin, manab zamin wanted advertisement, wanted advertisement cost at manab zamin, publish wanted advertisement at manab zamin, wanted advertisement at manab zamin, 	 tution wanted advertisement at manab zamin, manab zamin tution wante advertisement, tution wanted advertisement cost at manab zamin, publish tution wanted advertisement at manab zamin, tuiton wanted advertisement at manab zamin, মানবজমিনে  পড়াতে চাই   বিজ্ঞাপন দিন,  groom wanted advertisement at manab zamin, manab zamin groom wanted advertisement, groom wanted advertisement cost at manab zamin, publish groom wanted advertisement at manab zamin, groom wnated advertisement at manab zamin, মানবজমিনে  পাত্র চাই  বিজ্ঞাপন দিন,  bride wanted advertisement at manab zamin, manab zamin plot bride wanted advertisement, bride wanted  advertisement cost at manab zamin, bride wanted purchase advertisement at manab zamin, bride wanted  advertisement at manab zamin, মানবজমিনে  পাত্রী চাই  বিজ্ঞাপন দিন")]
        [SeoTitle("Publish classified advertisement in manab zamin through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your classified advertisement in manab zamin")]
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
                VAT = 0.15,
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }


        #endregion

        #region SpecialDisplay

        [SeoMetaKeywords("amader ad manab zamin special display advertisement, manab zamin special display advertisement, manab zamin special display page advertisement, manab zamin one number page color advertisement, publish advertisement at manab zamin last page, advertisement cost at manab zamin special display advertisement, manab zamin special display advertisement rate")]
        [SeoTitle("Publish special display advertisement in manab zamin through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your special display advertisement in manab zamin")]
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

        #endregion

        #region GeneralDisplay

        [SeoMetaKeywords("amader ad manab zamin general display advertisement, manab zamin general display advertisement, publish general display advertisement in manab zamin, general display advertisement cost at manab zamin, manab zamin general display  advertisement rate, general display advertisement at manab zamin")]
        [SeoTitle("Publish general display advertisement in manab zamin through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your general display advertisement in manab zamin")]
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

        #endregion

        #region Film

        [SeoMetaKeywords("amader ad manab zamin general display advertisement, manab zamin general display advertisement, publish general display advertisement in manab zamin, general display advertisement cost at manab zamin, manab zamin general display  advertisement rate, general display advertisement at manab zamin")]
        [SeoTitle("Publish general display advertisement in manab zamin through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your general display advertisement in manab zamin")]
        public ActionResult Film_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin general display advertisement",
                PriceDescription = 1500
            };
            return View(model);
        }

        #endregion

        #region  EducativeReligiousAffair
        [SeoMetaKeywords("amader ad manab zamin educative religious affair advertisement, manab zamin educative religious affair advertisement, publish educative religious affair advertisement in manab zamin, educative religious affair advertisement cost at manab zamin, manab zamin educative religious affair  advertisement rate, educative religious affair advertisement at manab zamin")]
        [SeoTitle("Publish educative religious affair advertisement in manab zamin through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your educative religious affair advertisement in manab zamin")]
        public ActionResult EduReliAffai_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin educative religious affair advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        #endregion
        
        #region main page

        [SeoMetaKeywords("amader ad manab zamin first page advertisement, manab zamin first page color advertisement, manab zamin 1st page advertisement,  manab zamin 1st page color advbertisement, manab zamin 1 number page advertisement, manab zamin one number page color advertisement, publish advertisement at manab zamin first page, advertisement cost at manab zamin first page, manab zamin first page advertisement rate, color advertisement at manab zamin first page")]
        [SeoTitle("Publish color advertisement in manab zamin first page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in manab zamin first page")]
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
        [SeoMetaKeywords("amader ad manab zamin last page advertisement, manab zamin last page color advertisement, manab zamin 1st page advertisement,  manab zamin 1st page color advbertisement, manab zamin 1 number page advertisement, manab zamin one number page color advertisement, publish advertisement at manab zamin last page, advertisement cost at manab zamin last page, manab zamin last page advertisement rate, color advertisement at manab zamin last page")]
        [SeoTitle("Publish color advertisement in manab zamin last page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in manab zamin last page")]
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
       
        [SeoMetaKeywords("amader ad manab zamin third page advertisement, manab zamin third page color advertisement, manab zamin 3rd page advertisement,  manab zamin 3rd page color advbertisement, manab zamin 3 number page advertisement, manab zamin three number page color advertisement, publish advertisement at manab zamin third page, advertisement cost at manab zamin third page, manab zamin third page advertisement rate, color advertisement at manab zamin third page")]
        [SeoTitle("Publish color advertisement in manab zamin third page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in manab zamin third page")]
        public ActionResult ThirdPageAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Manabzamin third page advertisement",
                PriceDescription = 6000,
                PriceDescriptionBlack = 3500,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad manab zamin third page advertisement, manab zamin third page black and white advertisement, manab zamin 3rd page advertisement,  manab zamin 3rd page black and white advbertisement, manab zamin 3 number page advertisement, manab zamin three number page black and white advertisement, publish advertisement at manab zamin third page, advertisement cost at manab zamin third page, manab zamin third page advertisement rate, black and white advertisement at manab zamin third page")]
        //[SeoTitle("Publish black and white advertisement in manab zamin third page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in manab zamin third page")]
        //public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Manabzamin",
        //        AdLocation = "Manabzamin third page black and white advertisement",
        //        PriceDescription = 3500
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad manab zamin entertainment page advertisement, manab zamin entertainment page color advertisement, manab zamin entertainment page advertisement, publish advertisement at manab zamin entertainment page, advertisement cost at manab zamin entertainment page, manab zamin entertainment page advertisement rate, color advertisement at manab zamin entertainment page")]
        [SeoTitle("Publish color advertisement in manab zamin entertainment page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in manab zamin entertainment page")]
        public ActionResult Entertainment_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Entertainment page advertisement",
                PriceDescription = 5000,
                PriceDescriptionBlack = 3000,
                IsColor = true,
            };
            return View(model);
        }
        //[SeoMetaKeywords("amader ad manab zamin entertainment page advertisement, manab zamin entertainment page black and white advertisement, manab zamin 3rd page black and white advbertisement, publish black and white advertisement at manab zamin entertainment page, black and white advertisement cost at manab zamin entertainment page, manab zamin entertainment page black and white advertisement rate, black and white advertisement at manab zamin entertainment page")]
        //[SeoTitle("Publish black and white advertisement in manab zamin entertainment page through amader ad")]
        //[SeoMetaDescription("Through Amader Ad publish your black and white advertisement in manab zamin entertainment page")]
        //public ActionResult EntertainmentPageBlackWhiteAdvertisement_MainPage()
        //{
        //    Newspaper model = new Newspaper
        //    {
        //        NewspaperName = "Manabzamin",
        //        AdLocation = "Manabzamin entertainment page black and white advertisement",
        //        PriceDescription = 3000
        //    };
        //    return View(model);
        //}
        [SeoMetaKeywords("amader ad manab zamin sport page advertisement, manab zamin sport page color advertisement, publish advertisement at manab zamin sport page, advertisement cost at manab zamin sport page, manab zamin sport page advertisement rate, color advertisement at manab zamin sport page")]
        [SeoTitle("Publish color advertisement in manab zamin sport page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in manab zamin sport page")]
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
        [SeoMetaKeywords("amader ad manab zamin other page advertisement, manab zamin other page color advertisement, publish advertisement at manab zamin other page, advertisement cost at manab zamin other page, manab zamin other page advertisement rate, color advertisement at manab zamin other page")]
        [SeoTitle("Publish color advertisement in manab zamin other page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in manab zamin other page")]
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
    


        #endregion


        #region spot advertisement

        [SeoMetaKeywords("amader ad manab zamin first page spot advertisement, manab zamin first page spot advertisement, publish spot advertisement at manab zamin first page,spot advertisement cost at manab zamin first page, manab zamin first page spot advertisement rate, spot advertisement at manab zamin first page")]
        [SeoTitle("Publish spot advertisement in manab zamin first page thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in manab zamin first page")]
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
        [SeoMetaKeywords("amader ad manab zamin last page spot advertisement, manab zamin last page spot advertisement, publish spot advertisement at manab zamin last page,spot advertisement cost at manab zamin last page, manab zamin last page spot advertisement rate, spot advertisement at manab zamin last page")]
        [SeoTitle("Publish spot advertisement in manab zamin last page thourgh amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in manab zamin last page")]
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


        #endregion

        #region  Panel

        [SeoMetaKeywords("amader ad manab zamin classified advertisement,manab zamin classified ad, manab zamin classified advertisement,  publish classied advertisement at manab zamin , classified advertisement cost at manab zamin, manab zamin classified advertisement rate, classified advertisement at manab zamin, মানবজমিনে  শ্রেণীভুক্ত বিজ্ঞাপন দিন,  rent at manab zamin,  house rent at manab zamin, publish rent advertisement at manab zamin, manab zamin rent advertisement, ইত্তেফাক বাড়ি ভাড়া বিজ্ঞাপন,  land slae advertisement at manab zamin, manab zamin land sale advertisement, manab zamin land sale ad cost, মানবজমিনে জমি বিক্রয়ের বিজ্ঞাপন দিন,  miscellaneous sales advertisement at manab zamin, manab zamin miscellaneous slaes advetisement,  miscellaneous sales cost at manab zamin, publish miscellaneous advertisement at manab zamin, miscellaneous at manab zamin, মানবজমিনে বিবিধ বিক্রয়ের বিজ্ঞাপন দিন, house sale advertisement at manab zamin, manab zamin alo house sales advertisement, house sales advertisement cost at manab zamin, publish house sale advertisement at manab zamin, house sale advertisement at manab zamin, মানবজমিনে বাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  shop sale advertisement at manab zamin, manab zamin shop sales advertisement, shop sales advertisement cost at manab zamin, publish shop sale advertisement at manab zamin, house shop advertisement at manab zamin, মানবজমিনে দোকান বিক্রয়ের বিজ্ঞাপন দিন,    car sale advertisement at manab zamin, manab zamin car sales advertisement, car sales advertisement cost at manab zamin, publish car sale advertisement at manab zamin, car sale advertisement at manab zamin, মানবজমিনে গাড়ি বিক্রয়ের বিজ্ঞাপন দিন,  plot purchase advertisement at manab zamin, manab zamin plot purchase advertisement, plot purchase advertisement cost at manab zamin, publish plot purchase advertisement at manab zamin, plot purchase advertisement at manab zamin, মানবজমিনে প্লট ক্রয়ের  বিজ্ঞাপন দিন, 	 wanted advertisement at manab zamin, manab zamin wanted advertisement, wanted advertisement cost at manab zamin, publish wanted advertisement at manab zamin, wanted advertisement at manab zamin, 	 tution wanted advertisement at manab zamin, manab zamin tution wante advertisement, tution wanted advertisement cost at manab zamin, publish tution wanted advertisement at manab zamin, tuiton wanted advertisement at manab zamin, মানবজমিনে  পড়াতে চাই   বিজ্ঞাপন দিন,  groom wanted advertisement at manab zamin, manab zamin groom wanted advertisement, groom wanted advertisement cost at manab zamin, publish groom wanted advertisement at manab zamin, groom wnated advertisement at manab zamin, মানবজমিনে  পাত্র চাই  বিজ্ঞাপন দিন,  bride wanted advertisement at manab zamin, manab zamin plot bride wanted advertisement, bride wanted  advertisement cost at manab zamin, bride wanted purchase advertisement at manab zamin, bride wanted  advertisement at manab zamin, মানবজমিনে  পাত্রী চাই  বিজ্ঞাপন দিন")]
        [SeoTitle("Publish first page panel advertisement in manab zamin through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish first page panel advertisement in manab zamin")]
        public ActionResult FirstPage_pannel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "First page pannel",
                PriceDescription = 7000,


                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে

                ColumnSizeFloat = "2.00",
                InchFloat = "3.00",
            };
            return View(model);
        }

        public ActionResult LastPage1St_pannel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Last page pannel",
                PriceDescription = 5800,


                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে

                ColumnSizeFloat = "2.00",
                InchFloat = "3.00",
            };
            return View(model);
        }


        public ActionResult LastPage2nd_pannel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Last page pannel",
                PriceDescription = 18750,

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে

                ColumnSizeFloat = "2.00",
                InchFloat = "6.00ক",
            };
            return View(model);
        }

        public ActionResult LastPage3rd_pannel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Last page pannel",
                PriceDescription = 15000,

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে

                ColumnSizeFloat = "2.00",
                InchFloat = "6.00ক",
            };
            return View(model);
        }

        public ActionResult InnerPage1st_pannel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Inner page pannel",
                PriceDescription = 10400,

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে

                ColumnSizeFloat = "2.00",
                InchFloat = "6.00ক",
            };
            return View(model);
        }
        public ActionResult InnerPage2nd_pannel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "Inner page pannel",
                PriceDescription = 7500,

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে

                ColumnSizeFloat = "2.00",
                InchFloat = "6.00ক",
            };
            return View(model);
        }
        #endregion


        #region student
        public ActionResult Student_OneByOne()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "হারিয়েছে, এফিডেভিট, টিউশন, শিখুন ইত্যাদি ",
                PriceDescription = 600,

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে

                ColumnSizeFloat = "1.00",
                InchFloat = "1.00ক",
            };
            return View(model);
        }

        public ActionResult Student_OneByTwoHalf()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Manabzamin",
                AdLocation = "জন্মদিন, কৃতি ছাত্রছাত্রী, নিখোঁজ (ছবিসহ) ইত্যাদি ",
                PriceDescription = 1000,

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে

                ColumnSizeFloat = "1.00",
                InchFloat = "2.50ক",
            };
            return View(model);
        }
        #endregion


    }
}