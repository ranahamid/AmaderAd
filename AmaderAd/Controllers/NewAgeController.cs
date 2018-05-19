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

    }
}