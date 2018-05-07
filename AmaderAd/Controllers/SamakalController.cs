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
        public ActionResult FirstPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal First Page Color",
                PriceDescription = 16000
            };
            return View(model);
        }
        public ActionResult LastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal Last Page Color",
                PriceDescription = 14000
            };
            return View(model);
        }
        public ActionResult ThirdPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal third Page Color",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult ThirdPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal third Page black and white",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult FifthPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal fifth Page Color",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult FifthPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal fifth Page black and white",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult EntertainmentPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal entertainment Page color",
                PriceDescription = 7000
            };
            return View(model);
        }
        public ActionResult EntertainmentPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal entertainment Page black an white",
                PriceDescription = 4500
            };
            return View(model);
        }
        public ActionResult SportsPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal sports Page color",
                PriceDescription = 6500
            };
            return View(model);
        }
        public ActionResult SportsPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "Samakal sports Page black and white",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult SecondPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal second page color advertisement",
                PriceDescription = 8000
            };
            return View(model);
        }
        public ActionResult SecondPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal second page black and white advertisement",
                PriceDescription = 6000
            };
            return View(model);
        }
        public ActionResult PageBeforeLastPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal page befor last page color advertisement",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult PageBeforeLastPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal page befor last page black and white advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult InnerOtherPageColorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal inner other page color advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        public ActionResult InnerOtherPageBlackandWhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal inner other page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult MagazineShahittoShamoyikikalerkheyaInnerFullPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya inner full page color advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        
        public ActionResult MagazineShahittoShamoyikiKalerkheyaInnerFullPageBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kalerkheya inner full page black and white advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }
        public ActionResult MagazineshahittoShamoyikikalerkheyaInnerHalfPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya inner half page color advertisement",
                PriceDescription = 15000
            };
            return View(model);
        }
        public ActionResult MagazineShahittoShamoyikiKalerkheyaInnerHalfPageBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya inner half page black and white advertisement",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult MagazineShahittoShamoyikiKalerKheyaFirstCoverColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya first cover color advertisement",
                PriceDescription = 50000
            };
            return View(model);
        }
        public ActionResult MagazineShahittoShamoyikiKalerKheyaLastCoverColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya last-cover color advertisement",
                PriceDescription = 40000
            };
            return View(model);
        }
        public ActionResult MagazineShahittoShamoyikiKalerKheyaSecondCoverBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya second cover black and white advertisement",
                PriceDescription = 30000
            };
            return View(model);
        }
        public ActionResult MagazineShahittoshamoyikiKalerKheyaThirdCoverBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya third cover black and white advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        public ActionResult MagazineShahittoShamoyikiKalerKheyaMiddleTwoFullPageTogetherColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine shahitto shamoyiki kaler kheya middle two full page together color advertisement",
                PriceDescription = 45000
            };
            return View(model);
        }
        public ActionResult MagazineRommoShamoyikiPechalInnerFullPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal inner full page color advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        public ActionResult MagazineRommoShamoyikiPechalInnerFullPageBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal inner full page black and white advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }
        public ActionResult MagazineRommoShamoyikiPechalInnerHalfPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal inner half page color advertisement",
                PriceDescription = 15000
            };
            return View(model);
        }
        public ActionResult MagazineRommoShamoyikiPechalInnerHalfPageBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal inner half page black and white advertisement",
                PriceDescription = 10000
            };
            return View(model);
        }
        public ActionResult MagazineRommoShamoyikiPechalFirstCoverColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal first cover color advertisement",
                PriceDescription = 50000
            };
            return View(model);
        }
        public ActionResult MagazineRommoShamoyikiPechalLastCoverColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal last cover color advertisement",
                PriceDescription = 40000
            };
            return View(model);
        }
        public ActionResult MagazineRommoShamoyikiPechalSecondCoverBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki-pechal second cover black and white advertisement",
                PriceDescription = 30000
            };
            return View(model);
        }
        public ActionResult MagazineRommoShamoyikiPechalThirdCoverBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal third cover black and white advertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        public ActionResult MagazineRommoShamoyikiPechalMiddleTwoFullPageTogetherColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal magazine rommo shamoyiki pechal middle two full page together color advertisement",
                PriceDescription = 45000
            };
            return View(model);
        }
        public ActionResult ShoiliFirstPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal shoili first page color advertisement",
                PriceDescription = 7500
            };
            return View(model);
        }
        public ActionResult ShoiliLastPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal shoili last page color advertisement",
                PriceDescription = 6500
            };
            return View(model);
        }
        public ActionResult ShoiliInnerPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal shoili inner page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult ShoiliInnerPageBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal shoili inner page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult NondonShonskritiOBinodonShamoyikiFirstPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal nondon shonskriti o binodon shamoyiki first page color advertisement",
                PriceDescription = 7500
            };
            return View(model);
        }
        
        public ActionResult NondonShonskritiOBinodonShamoyikiLastPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal nondon shonskriti o binodon shamoyiki last page color advertisement",
                PriceDescription = 6500
            };
            return View(model);
        }
        public ActionResult NondonShonskritiOBinodonShamoyikiInnerPageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal nondon shonskriti o binodon shamoyiki inner page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult NondonShonskritiOBinodonShamoyikiInnerPageBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal nondon shonskriti o,binodon shamoyiki inner page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult KholaHawaGhashForingBigganBoloyDehoghoriFeaturePagecoloradvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal khola hawa ghash foring biggan boloy deho ghori feature page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult KholaHawaGhashForingBigganBoloyDehoghoriFeaturePageblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal khola hawa ghash foring biggan boloy deho ghori nfeature page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult AlorPothJatriFeaturePageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal alor poth jatri feature page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult AlorPothJatriFeaturePageBlackandWhiteAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal alor poth jatri feature page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult MoncherbaireSuhridShomabeshTechLineFeaturePageColorAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal moncher baire suhrid shomabesh tech line feature page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        public ActionResult MoncherbaireSuhridShomabeshTechLineFeaturePageblackandwhiteadvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal monche -baire suhrid shomabesh tech line feature page black and white advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        public ActionResult FirstPageSpotAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakal first page spot advertisement",
                PriceDescription = 35000
            };
            return View(model);
        }
        public ActionResult LastPageSpotAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Samakal",
                AdLocation = "samakallastpagespotadvertisement",
                PriceDescription = 25000
            };
            return View(model);
        }
        public ActionResult SportsPageSpotAdvertisement()
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