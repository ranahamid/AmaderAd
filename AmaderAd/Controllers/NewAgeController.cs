using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class NewAgeController : BaseController
    {
        // GET: NewAge
        public ActionResult Index()
        {
            return View();
        }
        //classified advertisement
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

        #endregion


        #region Xtra

        #endregion


        #region Culture & Living Weekly

        #endregion


    }
}