using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult newstodayfrontpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today front page color advertisement",
                PriceDescription = 9500
            };
            return View(model);
        }
        public ActionResult Newstodayfrontpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today front page black and white advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult Newstodaybackpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today back page color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult Newstodaybackpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today back page black and white advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Newstodaythirdpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today third page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Newstodaythirdpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today third page black and white advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult Newstodayinnerpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today inner page color advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Newstodayinnerpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today inner page black and white advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        public ActionResult Newstodaydifferentcategoriespageadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News Today different categories page advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult Newstodaycareeropportunityvacancyblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "News Today",
                AdLocation = "News today career opportunity vacancy black and white advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        public ActionResult Newstodaybirthdaytoletpurchasesaletutionqulkhanilostandfoundwantedscholarshipcoachingcenterreunionexibitionacademicfeatfashionshowculturalprogramme_MainPage()
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