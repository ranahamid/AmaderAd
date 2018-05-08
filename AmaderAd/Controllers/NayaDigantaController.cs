using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class NayaDigantaController : BaseController
    {
        // GET: NayaDiganta
        public ActionResult Index()
        {
            return View();
        }
        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult GeneralDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta general display advertisement.",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult FirstPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta first page color advertisement.",
                PriceDescription = 15000
            };
            return View(model);
        }
        public ActionResult SecondPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta second page black and white advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult LastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta last page color advertisement.",
                PriceDescription = 12500
            };
            return View(model);
        }
        public ActionResult LastPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta last page black and white advertisement.",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "naya Diganta third page color advertisement.",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult ThirdPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta third page black and white advertisement.",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult FifthPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta fifth page color advertisement.",
                PriceDescription = 7000
            };
            return View(model);
        }
        public ActionResult FifthPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta fifth page black and white advertisement.",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult BusinessPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta business page color advertisement.",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult BusinessPageBlacWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta business page black and white advertisement.",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult EntertainmentPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta entertainment page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult EntertainmentPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta entertainment page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult SportsPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta sports page color advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult SportsPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta sports page black and white advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult InnerPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta inner page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult InnerPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta inner page black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult BackInnerPageBlackWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta back inner page black and white advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult FinanceCourtAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta Finance Court related advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult BirthdayMeritoriousStudentMissingColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta birthday meritorious student missing color advertisement",
                PriceDescription = 1500
            };
            return View(model);
        }
        public ActionResult BirthdayMeritoriousStudentMissingBlackWhiteAdvertiement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta birthday meritorious student missing black and white advertisement",
                PriceDescription = 800
            };
            return View(model);
        }
        public ActionResult FirstPageColorAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta First Page Spot Advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }
        public ActionResult LastPageColorAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta Last Page Spot Advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult ObokashColorAdvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta obokash color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult ObokashBlackWhiteAdvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta obokash black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult WeeklyTherapyColoradvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta weekly therapy color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult WeeklyTherapyBlackWhiteAdvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta weekly therapy black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult WeeklyShatrongColorAdvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta weekly shatrong color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult WeeklyShatrongBlackWhiteAdvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta weekly shatrong black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult AnondolokColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta anondolok color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult AnondolokBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta anondolok black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult BinodonSharadinColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta binodon sharadin color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult BinodonSharadinBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta binodon sharadin black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult DigantaShahittoColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya diganta diganta shahitto color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult DigantaShahittoBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya diganta diganta shahitto black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult NittodinColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta nittodin color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult NittodinBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta nittodin black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult SyllabusColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta syllabus color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult SyllabusBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta syllabus black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult NariColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta nari color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult NariBlacWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta nari black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult AgdumBagdumColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta agdum bagdum color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult AgdumBagdumBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta agdum bagdum black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult ScienceAndTechnologyColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta science and technology color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult ScienceAndTechnologyBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta science and technology black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult MuktoBazarColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta muktobazar color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult MuktoBazarBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta muktobazar black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult PriyoJonColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta Priyojon color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult PriyoJonBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta priyojon black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult NiramoyColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta niramoy color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult NiramoyBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta niramoy black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult IslamiDigantaColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta islami diganta color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult IslamiDigantaBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta islami diganta black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult DeshMohadeshColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta desh mohadesh color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult DeshMohadeshBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta desh mohadesh black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult AjkerComputerColorAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta ajker computer color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult AjkerComputerBlackWhiteAdvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta ajker computer black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
    }
}