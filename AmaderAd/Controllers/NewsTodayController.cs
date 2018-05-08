using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;


namespace AmaderAd.Controllers
{
    public class NewsTodayController : BaseController
    {
        // GET: NewsToday
        public ActionResult Index()
        {
            return View();
        }
        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult FrontPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today front page color advertisement",
                PriceDescription = 9500
            };
            return View(model);
        }
        public ActionResult FrontPageBlackWhitAadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today front page black and white advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult BackPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today back page color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult BackPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today back page black and white advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today third page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult ThirdPageBlacWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today third page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult InnerPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today inner page color advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult InnerPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today inner page black and white advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        public ActionResult DifferentCategoriesPageAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today different categories page advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult CareerOpportunityVacancyBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News today career opportunity vacancy black and white advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        public ActionResult BirthdayToletPurchaseSaleTutionQulkhaniLostAndFoundWantedScholarshipCoachingCenterReunionExibitionAcademicFeatFashionShowCulturalProgramme_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today birthday tolet purchase sale tution qulkhani lost and found wanted scholarship coaching center reunion exibition academic feat fashion show cultural programme",
                PriceDescription = 1000
            };
            return View(model);
        }
    }
}