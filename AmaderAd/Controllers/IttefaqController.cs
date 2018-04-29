using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class IttefaqController : BaseController
    {
        // GET: Ittefaq
        public ActionResult Index()
        {
            return View();
        }

        #region classified

        

     
        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        #endregion

        #region main page

        


        public ActionResult FirstPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq First Page Color",
                PriceDescription = 14000
            };
            return View(model);
        }

        public ActionResult LastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Last Page Color",
                PriceDescription = 12000
            };
            return View(model);
        }

        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Third Page Color",
                PriceDescription = 9000
            };
            return View(model);
        }

        public ActionResult FifthPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Fifth Page Color",
                PriceDescription = 7500
            };
            return View(model);
        }


        public ActionResult FifthPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Fifth Page Black & White",
                PriceDescription = 5000
            };
            return View(model);
        }


        public ActionResult SecondPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Second Page Color",
                PriceDescription = 6500
            };
            return View(model);
        }

        public ActionResult SecondPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Second Page Black & White",
                PriceDescription = 6500 //check the price
            };
            return View(model);
        }


        public ActionResult Nineteenth_TweentythirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Nineteenth & Tweentythird Page Color",
                PriceDescription = 6000
            };
            return View(model);
        }



        public ActionResult Nineteenth_TweentythirdPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Nineteenth & Tweentythird Page Black & White",
                PriceDescription = 4500
            };
            return View(model);
        }



        public ActionResult SportsPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Sports Page Color",
                PriceDescription = 5000
            };
            return View(model);
        }

        public ActionResult SportsPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Sports Page Black & White",
                PriceDescription = 4000 //check the price
            };
            return View(model);
        }

        public ActionResult MiddleTwoPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Middle Two Page Color",
                PriceDescription = 4500
            };
            return View(model);
        }

        public ActionResult InnerPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Sports Page Black & White",
                PriceDescription = 3000 //check the price
            };
            return View(model);
        }



        public ActionResult InnerPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Sports Page Color",
                PriceDescription = 4000
            };
            return View(model);
        }
        #endregion


        #region  Thatta

        public ActionResult LastCoverPageColorAdvertisement_Thatta()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Thatta Last cover page(full page) Advertisement",
                PriceDescription = 40000
            };
            return View(model);
        }

        public ActionResult SecondCoverPageColorAdvertisement_Thatta()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Thatta Second cover page(full page) Advertisement",
                PriceDescription = 30000
            };
            return View(model);
        }

        public ActionResult ThirdCoverPageColorAdvertisement_Thatta()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Thatta Third cover page(full page) Advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }

        public ActionResult InnerPageColorAdvertisement_Thatta()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Thatta Inner Page(full page) Advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }



        public ActionResult InnerTwoPageColorAdvertisement_Thatta()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Thatta Inner Two Page(full page) Advertisement",
                PriceDescription = 35000
            };
            return View(model);
        }



        #endregion

        #region projonmo
        public ActionResult FirstPageColorAdvertisement_Projonmo()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Projonmo First Page Advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }

        public ActionResult LastPageColorAdvertisement_Projonmo()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Projonmo Last Page Advertisement( kochi kachar ashor)",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult InnerPageColorAdvertisement_Projonmo()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Projonmo Inner Page Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }

        #endregion

        #region korcha
        public ActionResult FirstPageColorAdvertisement_Korcha()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Korcha First Page Advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult LastPageColorAdvertisement_Korcha()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Korcha Last Page Advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult InnerPageColorAdvertisement_Korcha()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Korcha Inner Page Advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        public ActionResult InnerPageBlackWhiteAdvertisement_Korcha()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Korcha InnerPage Black & White Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }

        #endregion

        #region Campus
        public ActionResult FirstPageColorAdvertisement_Campus()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Campus First Page Advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }

    

        public ActionResult InnerPageColorAdvertisement_Campus()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Campus Inner Color Page Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }

        public ActionResult ITPageColorAdvertisement_Campus()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Campus IT Color Page Advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }

        public ActionResult CareerPageColorAdvertisement_Campus()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Campus Career Color Page Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        #endregion

        #region Anondo binodon

        public ActionResult FirstPageColorAdvertisement_AnondoBinodon()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Anondo Binodon Color First Page Advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }

        public ActionResult InnerPageColorAdvertisement_AnondoBinodon()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Anondo Binodon Color Inner Page Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }

        public ActionResult LastPageColorAdvertisement_AnondoBinodon()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Anondo Binodon Color Last Page Advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }

        #endregion

        #region Shaitto shamoiki

        public ActionResult FirstPageColorAdvertisement_Shaitto()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Shaitto shamoik Color First Page Advertisement",
                PriceDescription = 2500
            };
            return View(model);
        }
        public ActionResult LastPageColorAdvertisement_Shaitto()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Shaitto shamoik Color Last Page Advertisement",
                PriceDescription = 2000
            };
            return View(model);
        }
        public ActionResult InnerPageColorAdvertisement_Shaitto()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Shaitto shamoik Inner Page Advertisement",
                PriceDescription = 1600
            };
            return View(model);
        }
        #endregion

        #region spot panel ad

        public ActionResult FirstPageColorAdvertisement_SpotPanel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq First Page Spot Advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }

        public ActionResult LastPageColorAdvertisement_SpotPanel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Last Page Spot Advertisement",
                PriceDescription = 15000
            };
            return View(model);
        }



        public ActionResult LastPageColorAdvertisement_Panel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Last Page Panel Advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }

        public ActionResult InnerPageColorAdvertisement_Panel()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Ittefaq",
                AdLocation = "Ittefaq Inner Page Panel Advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }


        #endregion


    }
}