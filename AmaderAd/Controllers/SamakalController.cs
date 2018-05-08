using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;


namespace AmaderAd.Controllers
{
    public class SamakalController : BaseController
    {
        // GET: Samakal
        public ActionResult Index()
        {
            return View();
        }
        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "samakal",
                AdLocation = "Classified Advertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
        public ActionResult Samakalfirstpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal First Page Color",
                PriceDescription = 16000
            };
            return View(model);
        }
        public ActionResult samakallastpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal Last Page Color",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult samakalthirdpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal third Page Color",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult samakalthirdpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal third Page black and white",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult samakalfifthpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal fifth Page Color",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult samakalfifthpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal fifth Page black and white",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult samakalentertainmentpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal entertainment Page color",
                PriceDescription = 7000
            };
            return View(model);
        }
        public ActionResult samakalentertainmentpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal entertainment Page black an white",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult samakalsportspagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal sports Page color",
                PriceDescription = 6500
            };
            return View(model);
        }
        public ActionResult samakalsportspageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal sports Page black and white",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult samakalsecondpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal second page color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult samakalsecondpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal second page black and white advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult samakalpagebeforelastpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal page befor last page color advertisement",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult samakalpagebeforelastpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal page befor last page black and white advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult samakalinnerotherpagecoloradvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal inner other page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult samakalinnerotherpageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal inner other page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult samakalmagazineshahittoshamoyikikalerkheyainnerfullpagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya inner full page color advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
    
        public ActionResult samakalmagazineshahittoshamoyikikalerkheyainnerfullpageblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kalerkheya inner full page black and white advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }
        public ActionResult samakalmagazineshahittoshamoyikikalerkheyainnerhalfpagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya inner half page color advertisement",
                PriceDescription = 15000
            };
            return View(model);
        }
        public ActionResult samakalmagazineshahittoshamoyikikalerkheyainnerhalfpageblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya inner half page black and white advertisement",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult samakalmagazineshahittoshamoyikikalerkheyafirstcovercoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya first cover color advertisement",
                PriceDescription = 50000
            };
            return View(model);
        }
        public ActionResult samakalmagazineshahittoshamoyikikalerkheyalastcovercoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya last-cover color advertisement",
                PriceDescription = 40000
            };
            return View(model);
        }
        public ActionResult samakalmagazineshahittoshamoyikikalerkheyasecondcoverblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya second cover black and white advertisement",
                PriceDescription = 30000
            };
            return View(model);
        }
        public ActionResult samakalmagazineshahittoshamoyikikalerkheyathirdcoverblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya third cover black and white advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        public ActionResult samakalmagazineshahittoshamoyikikalerkheyamiddletwofullpagetogethercoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya middle two full page together color advertisement",
                PriceDescription = 45000
            };
            return View(model);
        }
        public ActionResult samakalmagazinerommoshamoyikipechalinnerfullpagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal inner full page color advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        public ActionResult samakalmagazinerommoshamoyikipechalinnerfullpageblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal inner full page black and white advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }
        public ActionResult samakalmagazinerommoshamoyikipechalinnerhalfpagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal inner half page color advertisement",
                PriceDescription = 15000
            };
            return View(model);
        }
        public ActionResult samakalmagazinerommoshamoyikipechalinnerhalfpageblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal inner half page black and white advertisement",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult samakalmagazinerommoshamoyikipechalfirstcovercoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal first cover color advertisement",
                PriceDescription = 50000
            };
            return View(model);
        }
        public ActionResult samakalmagazinerommoshamoyikipechallastcovercoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal last cover color advertisement",
                PriceDescription = 40000
            };
            return View(model);
        }
        public ActionResult samakalmagazinerommoshamoyikipechalsecondcoverblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki-pechal second cover black and white advertisement",
                PriceDescription = 30000
            };
            return View(model);
        }
        public ActionResult samakalmagazinerommoshamoyikipechalthirdcoverblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal third cover black and white advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        public ActionResult samakalmagazinerommoshamoyikipechalmiddletwofullpagetogethercoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal middle two full page together color advertisement",
                PriceDescription = 45000
            };
            return View(model);
        }
        public ActionResult samakalshoilifirstpagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal shoili first page color advertisement",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult samakalshoililastpagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal shoili last page color advertisement",
                PriceDescription = 6500
            };
            return View(model);
        }
        public ActionResult samakalshoiliinnerpagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal shoili inner page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult samakalshoiliinnerpageblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal shoili inner page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult samakalnondonshonskritiobinodonshamoyikifirstpagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal nondon shonskriti o binodon shamoyiki first page color advertisement",
                PriceDescription = 7500
            };
            return View(model);
        }
      
        public ActionResult samakalnondonshonskritiobinodonshamoyikilastpagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal nondon shonskriti o binodon shamoyiki last page color advertisement",
                PriceDescription = 6500
            };
            return View(model);
        }
        public ActionResult samakalnondonshonskritiobinodonshamoyikiinnerpagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal nondon shonskriti o binodon shamoyiki inner page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult samakalnondonshonskritiobinodonshamoyikiinnerpageblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal nondon shonskriti o,binodon shamoyiki inner page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult samakalkholahawaghashforingbigganboloydehoghorifeaturepagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal khola hawa ghash foring biggan boloy deho ghori feature page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult samakalkholahawaghashforingbigganboloydehoghorifeaturepageblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal khola hawa ghash foring biggan boloy deho ghori nfeature page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult samakalalorpothjatrifeaturepagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal alor poth jatri feature page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult samakalalorpothjatrifeaturepageblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal alor poth jatri feature page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult samakalmoncherbairesuhridshomabeshtechlinefeaturepagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal moncher baire suhrid shomabesh tech line feature page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult samakalmoncherbairesuhridshomabeshtechlinefeaturepageblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal monche -baire suhrid shomabesh tech line feature page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult samakalfirstpagespotadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal first page spot advertisement",
                PriceDescription = 35000
            };
            return View(model);
        }
        public ActionResult samakallastpagespotadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakallastpagespotadvertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        public ActionResult samakalsportspagespotadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal sports page spot advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
    }
}