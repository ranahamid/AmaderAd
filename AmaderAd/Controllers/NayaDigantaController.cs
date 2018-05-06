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
        public ActionResult Nayadigantageneraldisplayadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta general display advertisement.",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult nayadigantafirstpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta first page color advertisement.",
                PriceDescription = 15000
            };
            return View(model);
        }
        public ActionResult Nayadigantasecondpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta second page black and white advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult Nayadigantalastpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta last page color advertisement.",
                PriceDescription = 12500
            };
            return View(model);
        }
        public ActionResult Nayadigantalastpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta last page black and white advertisement.",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult Nayadigantathirdpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "naya Diganta third page color advertisement.",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult Nayadigantathirdpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta third page black and white advertisement.",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult Nayadigantafifthpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta fifth page color advertisement.",
                PriceDescription = 7000
            };
            return View(model);
        }
        public ActionResult Nayadigantafifthpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta fifth page black and white advertisement.",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantabusinesspagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta business page color advertisement.",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantabusinesspageblacandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta business page black and white advertisement.",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult Nayadigantaentertainmentpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta entertainment page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantaentertainmentpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta entertainment page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult Nayadigantasportspagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta sports page color advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult Nayadigantasportspageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta sports page black and white advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantainnerpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta inner page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantainnerpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta inner page black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantabackinnerpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta back inner page black and white advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult nayadigantafinanacecourtadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta Finanace Court related advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult nayadigantabirthdaymeritoriousstudentmissingcoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta birthday meritorious student missing color advertisement",
                PriceDescription = 1500
            };
            return View(model);
        }
        public ActionResult Nayadigantabirthdaymeritoriousstudentmissingblackandwhiteadvertiement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta birthday meritorious student missing black and white advertisement",
                PriceDescription = 800
            };
            return View(model);
        }
        public ActionResult NayaDigantaFirstPageColorAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta First Page Spot Advertisement",
                PriceDescription = 16000
            };
            return View(model);
        }
        public ActionResult NayaDigantaLastPageColorAdvertisement_Spot()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta Last Page Spot Advertisement",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult Nayadigantaobokashcoloradvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta obokash color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantaobokashblackandwhiteadvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta obokash black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantaweeklytherapycoloradvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta weekly therapy color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantaweeklytherapyblackandwhiteadvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta weekly therapy black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantaweeklyshatrongcoloradvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta weekly shatrong color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantaweeklyshatrongblackandwhiteadvertisement_WeeklyPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta weekly shatrong black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantaanondolokcoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta anondolok color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantaanondolokblackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta anondolok black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantabinodonsharadincoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta binodon sharadin color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantabinodonsharadinblackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta binodon sharadin black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantadigantashahittocoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya diganta diganta shahitto color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantadigantashahittoblackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya diganta diganta shahitto black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantanittodincoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta nittodin color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantanittodinblackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta nittodin black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantasyllabuscoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta syllabus color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantasyllabusblackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta syllabus black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantanaricoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta nari color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantanariblacandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta nari black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantaagdumbagdumcoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta agdum bagdum color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantaagdumbagdumblackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta agdum bagdum black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantascienceandtechnologycoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta science and technology color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantascienceandtechnologyblackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta science and technology black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantamuktobazarcoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta muktobazar color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantamuktobazarblackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta muktobazar black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantapriyojoncoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya-Diganta priyojon color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantapriyojonblackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya-Diganta priyojon black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantaniramoycoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta niramoy color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantaniramoyblackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta niramoy black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantaislamidigantacoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta islami diganta color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantaislamidigantablackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta islami diganta black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantadeshmohadeshcoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta desh mohadesh color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantadeshmohadeshblackandwhiteadvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta desh mohadesh black and white advertisement",
                PriceDescription = 3500
            };
            return View(model);
        }
        public ActionResult Nayadigantaajkercomputercoloradvertisement_RegularPublication()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Naya Diganta",
                AdLocation = "Naya Diganta ajker computer color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult Nayadigantaajkercomputerblackandwhiteadvertisement_RegularPublication()
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