using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;
using AspNetSeo.Mvc;

namespace AmaderAd.Controllers
{
    [SeoBaseTitle("Publish advertisement in New Age through amader ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/NewAge")]
    public class NewAgeController : BaseController
    {
        // GET: NewAge
        public ActionResult Index()
        {
            return View();
        }
        //classified advertisement
        [SeoMetaKeywords("amader ad new age birthday, book, magazine, good luck, scholarship, affedevit, good wishes, tolet, purchase, sale, tution,  lost, theatre page advertisement, new age birthday, book, magazine, good luck, scholarship, affedevit, good wishes, tolet, purchase, sale, tution,  lost, theatre page color advertisement, new age birthday, book, magazine, good luck, scholarship, affedevit, good wishes, tolet, purchase, sale, tution,  lost, theatre page advertisement, publish advertisement at new age birthday, book, magazine, good luck, scholarship, affedevit, good wishes, tolet, purchase, sale, tution,  lost, theatre page, advertisement cost at new age birthday, book, magazine, good luck, scholarship, affedevit, good wishes, tolet, purchase, sale, tution,  lost, theatre page, new age birthday, book, magazine, good luck, scholarship, affedevit, good wishes, tolet, purchase, sale, tution,  lost, theatre page advertisement rate, color advertisement at new age birthday, book, magazine, good luck, scholarship, affedevit, good wishes, tolet, purchase, sale, tution,  lost, theatre page")]
        [SeoTitle("Publish your classified advertisement in new age through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your classified advertisement in new age")]
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Classified Advertisement",
        

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,
                PriceDescription = 800,
                ExtraWordPrice = 40,
                WordLimit = 60,

                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age first page advertisement, new age first page color advertisement, new age 1st page advertisement,  new age 1st page color advbertisement, new age 1 number page advertisement, new age one number page color advertisement, publish advertisement at new age first page, advertisement cost at new age first page, new age first page advertisement rate, color advertisement at new age first page, new age front page color advertisement")]
        [SeoTitle("Publish color advertisement in New Age  front page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in new age first page")]
        public ActionResult FrontPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age front page color advertisement",
                PriceDescription = 10000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age first page advertisement, new age first page black and white advertisement, new age 1st page advertisement,  new age 1st page black and white advbertisement, new age 1 number page advertisement, new age one number page black and white advertisement, publish advertisement at new age first page, advertisement cost at new age first page, new age first page advertisement rate, black and white advertisement at new age first page, new age front page black and white advertisement")]
        [SeoTitle("Publish black and white advertisement in New Age  front page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in new age first page")]
        public ActionResult FrontPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age front page black and white advertisement",
                PriceDescription = 7000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age backpage advertisement, new age backpage color advertisement, new age backpage advertisement,  new age backpage color advbertisement,  publish advertisement at new age backpage, advertisement cost at new age backpage, new age backpage advertisement rate, color advertisement at new age backpage, new age back page color advertisement")]
        [SeoTitle("Publish color advertisement in New Age  back page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in new age back page")]
        public ActionResult BackPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age back page color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age back page advertisement, new age back page black and white advertisement, new age back page advertisement,  new age back page black and white advbertisement,  publish advertisement at new age back page, advertisement cost at new age back page, new age back page advertisement rate, black and white advertisement at new age back page, new age back page black and white advertisement")]
        [SeoTitle("Publish black and white advertisement in New Age  back page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in new age back page")]
        public ActionResult BackPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age back page black and white advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age third page advertisement, new age third page color advertisement, new age 3rd page advertisement,  new age 3rd page color advbertisement, new age 3 number page advertisement, new age three number page color advertisement, publish advertisement at new age third page, advertisement cost at new age third page, new age third page advertisement rate, color advertisement at new age third page")]
        [SeoTitle("Publish color advertisement in New Age  third  page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in new age third page")]
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age Third page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age third page advertisement, new age third page black and white advertisement, new age 3rd page advertisement,  new age 3rd page black and white advbertisement, new age 3 number page advertisement, new age three number page black and white advertisement, publish advertisement at new age third page, advertisement cost at new age third page, new age third page black and white advertisement rate, black and white advertisement at new age third page")]
        [SeoTitle("Publish black and white advertisement in New Age  third  page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in new age third page")]
        public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age Third page black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age business front page advertisement, new age business front page color advertisement, new age business front page advertisement, publish advertisement at new age business front page, advertisement cost at new age business front page, new age business front page advertisement rate, color advertisement at new age business front page ")]
        [SeoTitle("Publish color advertisement in New Age business front page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in new age business front page")]
        public ActionResult BusinessFrontPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age business front page color advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age business front page advertisement, new age business front page black and white advertisement, new age business front page advertisement, publish advertisement at new age business front page, advertisement cost at new age business front page, new age business front page black and white advertisement rate, black and white advertisement at new age business front page")]
        [SeoTitle("Publish black and white  advertisement in New Age business front page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in new age business front page")]
        public ActionResult BusinessFrontPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age business front page black and white advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age business back page advertisement, new age business back page color advertisement, new age business back page advertisement, publish advertisement at new age business back page, advertisement cost at new age business back page, new age business back page advertisement rate, color advertisement at new age business back page")]
        [SeoTitle("Publish color advertisement in New Age business back page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in new age business back page")]
        public ActionResult BusinessBackPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age business back page color advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age business back page advertisement, new age business back page black and white advertisement, new age business back page advertisement, publish advertisement at new age business back page, advertisement cost at new age business back page, new age business back page advertisement rate, black and white advertisement at new age business back page")]
        [SeoTitle("Publish black and white  advertisement in New Age business back page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in new age business back page")]
        public ActionResult BusinessBackPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age business back page black and white advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age inner other page advertisement, new age inner other page color advertisement, new age inner other page advertisement, publish advertisement at new age inner other page, advertisement cost at new age inner other page, new age inner other page advertisement rate, color advertisement at new age inner other page,new age inner other page color advertisement")]
        [SeoTitle("Publish color advertisement in New Age  other inner page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in new age other inner page")]
        public ActionResult OtherInnerPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age other Inner page color advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age inner other page advertisement, new age inner other page black and white advertisement, new age inner other page advertisement, publish advertisement at new age inner other page, advertisement cost at new age inner other page, new age inner other page black and white advertisement rate, black and white advertisement at new age inner other page,new age inner other page black and white advertisement")]
        [SeoTitle("Publish black and white advertisement in New Age  other inner page through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in new age other inner page")]
        public ActionResult OtherInnerPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age other Inner page black and white advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age notice legal public appeal tender auction trademark announcement confidence meeting and attention page advertisement, new age notice legal public appeal tender auction trademark announcement confidence meeting and attention page color advertisement, new age notice legal public appeal tender auction trademark announcement confidence meeting and attention page advertisement, publish advertisement at new age notice legal public appeal tender auction trademark announcement confidence meeting and attention page, advertisement cost at new age notice legal public appeal tender auction trademark announcement confidence meeting and attention page, new age notice legal public appeal tender auction trademark announcement confidence meeting and attention page advertisement rate, black and white advertisement at new age notice legal public appeal tender auction trademark announcement confidence meeting and attention page ")]
        [SeoTitle("Publish notice, legal, public, appeal, tender, auction, trademark, announcement, confidence, meeting and attention related black and white advertisement  in New Age through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in new age notice, legal, public, appeal, tender, auction, trademark, announcement, confidence, meeting and attention page")]
        public ActionResult InnerPageNoticeLegalPublicAppealTenderActionTrademarkAnnouncementConferenceMeetingAttentionBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age Inner page Notice Legal Public Appeal Tender Trademark Announcement Conference Meeting Attention black and white advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age AGM EGM and financial statement page advertisement, new age AGM EGM and financial statement page black and white advertisement, new age AGM EGM and financial statement page advertisement, publish advertisement at new age AGM EGM and financial statement page, advertisement cost at new age AGM, EGM and financial statement page, new age AGM EGM and financial statement page advertisement rate, black and white advertisement at new age AGM EGM and financial statement page")]
        [SeoTitle("Publish AGM, EGM and financial statement related black and white advertisement  in New Age through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in new age inner page AGM, EGM and financial statement related advertisement")]
        public ActionResult InnerPageAGMEGMFinancialStatementBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age Inner page AGM EGM financial Statement black and white advertisement",
                PriceDescription = 2200
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age career, vacancy announcement page advertisement, new age career, vacancy announcement page color advertisement, new age career, vacancy announcement page advertisement, publish advertisement at new age career, vacancy announcement page, advertisement cost at new age career, vacancy announcement page, new age career, vacancy announcement page advertisement rate, color advertisement at new age career, vacancy announcement page")]
        [SeoTitle("Publish career oppurtunity vacancy announcement related black and white advertisement  in New Age through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish your black and white career oppurtunity and vacancy announcement related advertisement in new age")]
        public ActionResult InnerPageCareerOpportumityVacancyBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "New Age Inner page Career Oppurtunity/Vacancy black and white advertisement",
                PriceDescription = 1500
            };
            return View(model);
        }


        #region Panel
        [SeoMetaKeywords("amader ad new age front page panel advertisement, new age  front page panel advertisement, publish panel advertisement at new age front page,front page panel advertisement cost at new age, new age  front page panel advertisement rate, advertisement at new age front page side panel")]
        [SeoTitle("Publish front page panel advertisement in new age  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish front page panel advertisement in new age")]
        public ActionResult FrontPage_Panel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Front Page- Panel",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 12000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat= "2.25",
                InchFloat= "2.30",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age back page panel advertisement, new age  back page panel advertisement, publish panel advertisement at new age back page,back page panel advertisement cost at new age , new age back page panel advertisement rate, advertisement at new age back page side panel")]
        [SeoTitle("Publish back page panel advertisement in new age  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish back page panel advertisement in new age")]
        public ActionResult BackPage_Panel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Back Page- Panel",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 8000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "0.75",
                InchFloat = "3.00",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age inner page panel advertisement, new age inner page panel advertisement, publish panel advertisement at new age inner page,inner page panel advertisement cost at new age, new age inner page panel advertisement rate, advertisement at new age inner page side panel")]
        [SeoTitle("Publish inner page panel advertisement in new age  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish inner page panel advertisement in new age")]
        public ActionResult InnerPage_Panel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Inner Page- Panel",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 3000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "3.00",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age business front  page panel advertisement, new age  business front page panel advertisement, publish panel advertisement at new age business front page,business front page panel advertisement cost at new age, new age business front page panel advertisement rate, advertisement at new age business front page side panel")]
        [SeoTitle("Publish business front page panel advertisement in new age  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish business front page panel advertisement in new age")]
        public ActionResult BusinessFrontPage_Panel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Business Front Page- Panel",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 5000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "3.00",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age sports front page panel advertisement, new age sports front page panel advertisement, publish panel advertisement at new age sports front  page,sports front page panel advertisement cost at new age, new age sports front page panel advertisement rate, advertisement at new age sports front page side panel")]
        [SeoTitle("Publish sports front  page panel advertisement in new age  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish sports front  page panel advertisement in new age")]
        public ActionResult SportsFrontPage_Panel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Sports Front Page- Panel",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 4000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "3.00",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }


        #endregion



        #region Liner/ Band
        [SeoMetaKeywords("amader ad new age front page liner/band advertisement, new age front page liner/band advertisement, publish liner/band advertisement at new age front page, front page liner/band advertisement cost at new age, new age front page liner/band advertisement rate, advertisement at new age front page linear/band")]
        [SeoTitle("Publish front page liner/band advertisement in new age  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish front page liner/band advertisement in new age")]
        public ActionResult FrontPage_Liner()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Front Page- Liner/ Band",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 20000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "8/c",
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age back page liner/band advertisement, new age back page liner/band advertisement, publish liner/band advertisement at new age back page,back page liner/band advertisement cost at new age, new age back page liner/band advertisement rate, advertisement at new age back page linear/band")]
        [SeoTitle("Publish back page liner/band advertisement in new age through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish back page liner/band advertisement in new age")]
        public ActionResult BackPage_Liner()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Back Page- Liner/ Band",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 15000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "8/c",
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age metro page liner/band advertisement, new age metro page liner/band advertisement, publish liner/band advertisement at new age metro page, metro page liner/band advertisement cost at new age, new age  metro page liner/band advertisement rate, advertisement at new age metro page side panel")]
        [SeoTitle("Publish metro page liner/band advertisement in new age through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish metro page liner/band advertisement in new age")]
        public ActionResult MetroPage_Liner()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Metro Page- Liner/ Band",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 14000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "8/c",
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age business page liner/band advertisement, new age business page liner/band advertisement, publish liner/band advertisement at new age business page,business page liner/band advertisement cost at new age, new age business page liner/band advertisement rate, advertisement at new age business page side panel")]
        [SeoTitle("Publish business page liner/band advertisement in new age through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish business page liner/band advertisement in new age")]
        public ActionResult BusinessPage_Liner()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Business Page- Liner/ Band",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 15000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "8/c",
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age sports page liner/band advertisement, new age sports page liner/band advertisement, publish liner/band advertisement at new age sports page,sports page liner/band advertisement cost at new age, new age sports page liner/band advertisement rate, advertisement at new age sports page side panel")]
        [SeoTitle("Publish sports page liner/band advertisement in new age  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish sports page liner/band advertisement in new age")]
        public ActionResult SportsPage_Liner()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Sports Page- Liner/ Band",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 12000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "1.50",
                InchFloat = "8/c",
            };
            return View(model);
        }

        #endregion

        #region Spot
        [SeoMetaKeywords("amader ad new age front page spot advertisement, new age front page spot advertisement, publish spot advertisement at new age front page,front page spot advertisement cost at new age, new age front page spot advertisement rate, advertisement at new age front page side panel")]
        [SeoTitle("Publish front page spot advertisement in new age through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish front page spot advertisement in new age")]
        public ActionResult FrontPage_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Front Page- Spot",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 10000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "2",
                InchFloat = "2/c",
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age  back page spot advertisement, new age back page spot advertisement, publish spot advertisement at new age back page,back page spot advertisement cost at new age , new age  back page spot advertisement rate, advertisement at new age back page side panel")]
        [SeoTitle("Publish back page spot advertisement in new age  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish back page spot advertisement in new age")]
        public ActionResult BackPage_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Back Page- Spot",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 8000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "2",
                InchFloat = "2/c",
            };
            return View(model);
        }

        [SeoMetaKeywords("amader ad new age  metro page spot advertisement, new age  metro page spot advertisement, publish spot advertisement at new age metro page,metro page spot advertisement cost at new age, new age metro page spot advertisement rate")]
        [SeoTitle("Publish metro page spot advertisement in new age  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish metro page spot advertisement in new age")]
        public ActionResult MetroPage_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Metro Page- Spot",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 2000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "2",
                InchFloat = "2/c",
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age  business page spot advertisement, new age business page spot advertisement, publish spot advertisement at new age business page,business page spot advertisement cost at new age, new age business page spot advertisement rate")]
        [SeoTitle("Publish business page spot advertisement in new age  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish business page spot advertisement in new age")]
        public ActionResult BusinessPage_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Business Page- Spot",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 6000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "2",
                InchFloat = "2/c",
            };
            return View(model);
        }
        [SeoMetaKeywords("amader ad new age  sports  page spot advertisement, new age sports  page spot advertisement, publish spot advertisement at new age sports page, sports page spot advertisement cost at new age, new age sports page spot advertisement rate")]
        [SeoTitle("Publish sports  page spot advertisement in new age  through amader ad")]
        [SeoMetaDescription("Through Amader Ad publish sports  page spot advertisement in new age")]
        public ActionResult SportsPage_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Sports Page- Spot",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 4000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "2",
                InchFloat = "2/c",
            };
            return View(model);
        }

        #endregion

        #region online ad
        public ActionResult MiddleBannerType1_Online()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Middle Banner (HomePage) Type 1 - Online Advertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 45000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "648 pixel",
                InchFloat = "60 pixel",
            };
            return View(model);
        }

        public ActionResult MiddleBannerType2_Online()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Middle Banner (HomePage) Type 2 - Online Advertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 30000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "273 pixel",
                InchFloat = "60 pixel",
            };
            return View(model);
        }


        public ActionResult LeftHandSideType1_Online()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Left Hand Side Panel (HomePage) Type 1 - Online Advertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 25000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "273 pixel",
                InchFloat = "60 pixel",
            };
            return View(model);
        }


        public ActionResult LeftHandSideFront_Online()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Left Hand Side Panel Front Page - Online Advertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 12000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "140 pixel",
                InchFloat = "94 pixel",
            };
            return View(model);
        }


        public ActionResult LeftHandSideBusiness_Online()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Left Hand Side Panel Business Page - Online Advertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 12000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "140 pixel",
                InchFloat = "94 pixel",
            };
            return View(model);
        }


        public ActionResult LeftHandSideOtherLink_Online()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Left Hand Side Panel Other Link Page - Online Advertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 10000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "140 pixel",
                InchFloat = "94 pixel",
            };
            return View(model);
        }

        #endregion


        #region Trends

        public ActionResult BackCover_Trends()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Back Cover - TRENDS",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 35000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "7.00",
                InchFloat = "9.50",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }


        public ActionResult SecondCover_Trends()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Second Cover - TRENDS",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 30000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "7.00",
                InchFloat = "9.50",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult ThirdCover_Trends()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Third Cover - TRENDS",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 25000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "7.00",
                InchFloat = "9.50",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        public ActionResult InnerFullPage_Trends()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Inner Full Page - TRENDS",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 20000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "7.00",
                InchFloat = "9.50",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        public ActionResult CenterSpread_Trends()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Center Spread - TRENDS",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 45000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "15.00",
                InchFloat = "9.50",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        #endregion


        #region Xtra
        public ActionResult BackCover_Xtra()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Back Cover - Xtra",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 35000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "7.00",
                InchFloat = "9.50",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }


        public ActionResult SecondCover_Xtra()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Second Cover - Xtra",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 30000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "7.00",
                InchFloat = "9.50",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult ThirdCover_Xtra()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Third Cover - Xtra",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 25000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "7.00",
                InchFloat = "9.50",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        public ActionResult InnerFullPage_Xtra()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Inner Full Page - Xtra",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 20000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "7.00",
                InchFloat = "9.50",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        public ActionResult CenterSpread_Xtra()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Center Spread - Xtra",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 45000,
                ExtraWordPrice = 0,
                WordLimit = 0,
                ColumnSizeFloat = "15.00",
                InchFloat = "9.50",
                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        #endregion


        #region Culture & Living Weekly

        public ActionResult FrontPage_Life()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Front Page- Life",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 3500,
                ExtraWordPrice = 0,
                WordLimit = 0,

                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        public ActionResult BackPage_Life()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Back Page- Life",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 2500,
                ExtraWordPrice = 0,
                WordLimit = 0,

                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult InnerPage_Life()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "New Age",
                AdLocation = "Inner Page- Life",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 0,
                PriceDescription = 2000,
                ExtraWordPrice = 0,
                WordLimit = 0,

                // AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        #endregion


    }
}