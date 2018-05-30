using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;
using AspNetSeo.Mvc;

namespace AmaderAd.Controllers
{
    [SeoBaseTitle("Publish advertisement in Janakantha through amader ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/Janakantha")]
    public class JanakanthaController : BaseController
    {
        // GET: Janakantha
        public ActionResult Index()
        {
            return View();
        }
        //classified advertisement
        [SeoBaseTitle("Publish advertisement in janakantha through amader ad")]
        [SeoMetaKeywords("amader ad জনকণ্ঠ, amader ad janakantha advertisement, আমাদের এড  জনকণ্ঠ , জনকণ্ঠ  বিজ্ঞাপন,   newspaper janakantha ad, janakantha newspaper advertisement, janakantha ad, janakantha advertisement, advertisement at janakantha, ad at janakantha, publish advertisement at janakantha, pubish janakantha advertisement, advertisment at janakantha,janakantha adverts, janakantha advertisement rate, janakantha ad cost,advertise in janakantha, janakantha ad cost, janakantha print ad, janakantha advertisement cost, advertisement for janakantha, advetise on janakantha, janakantha advertisement agency, janakantha ad price, color ad at janakantha, color advertisement at janakantha, janakantha color advertisement, janakantha color ad price, janakantha color ad cost, black and white ad at janakantha, black and white advertisement at janakantha, janakantha black and white advertisement, janakantha black and white advertisement price, janakantha black and white advertisement cost, publish advertisement on janakantha main paper, advertise on janakantha main paper,publish advertisement on janakantha feature paper, advertise on janakantha feature paper, janakantha normal page, janakantha normal page advertisement, janakantha column inch advertisement,")]
        [SeoMetaDescription("Publish your advertisement in janakantha from any where through amader ad")]
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
           
                AdLocation = "JanakanthaClassifiedAdvertisement",

                //মূল্য প্রথম ১৬ শব্দের জন্য মোট ৬০০ টাকা এবং পরবর্তী প্রতি শব্দের জন্য ৪০ টাকা । শ্রেণিভুক্ত বিজ্ঞাপন সর্বোচ্চ ৫০ শব্দের মধ্যে হতে হবে
                FirstWordLimitBase = 16,
                PriceDescription = 300,
                ExtraWordPrice = 40,
                WordLimit = 50,
                VAT = 0.15,
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }

        [SeoBaseTitle("Publish color advertisement in janakantha first page through amader ad")]
        [SeoMetaKeywords("amader ad janakantha first page advertisement, janakantha first page color advertisement, janakantha 1st page advertisement,  janakantha 1st page color advbertisement, janakantha 1 number page advertisement, janakantha one number page color advertisement, publish advertisement at janakantha first page, advertisement cost at janakantha first page, janakantha first page advertisement rate, color advertisement at janakantha first page,")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in janakantha first page")]
        public ActionResult FirstPage_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "Janakantha First Page Color",
                PriceDescription = 14000
            };
            return View(model);
        }
        [SeoBaseTitle("Publish general display advertisement in janakantha through amader ad")]
        [SeoMetaKeywords("amader ad janakantha general display advertisement, janakantha general display advertisement, publish general display advertisement in janakantha , general display advertisement cost at janakantha , janakantha general display  advertisement rate, general display advertisement at janakantha,")]
        [SeoMetaDescription("Through Amader Ad publish your general  advertisement in janakantha")]
        public ActionResult GeneralDisplayAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "Janakantha General Display Advertisement",
                PriceDescription = 3000
            };
            return View(model);
        }
        [SeoBaseTitle("Publish black and white advertisement in janakntha second page through amader ad")]
        [SeoMetaKeywords("amader ad janakantha second page advertisement, janakantha second page black and white advertisement, janakantha 2nd page advertisement,  janakantha 2nd page black and white advbertisement, janakantha 2 number page advertisement, janakantha second number page black and white advertisement, publish advertisement at janakantha second page, advertisement cost at janakantha second page, janakantha second page advertisement rate, black and white advertisement at janakantha second page")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in janakantha second page")]
        public ActionResult SecondpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "Janakantha Secondpage black and white Advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        [SeoBaseTitle("Puhblish color advertisement in janakantha third page through amader ad")]
        [SeoMetaKeywords("amader ad janakantha third page advertisement, janakantha third page color advertisement, janakantha 3rd page advertisement,  janakantha 3rd page color advbertisement, janakantha 3 number page advertisement, janakantha three number page color advertisement, publish advertisement at janakantha third page, advertisement cost at janakantha third page, janakantha third page advertisement rate, color advertisement at janakantha third page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in janakantha third page")]
        public ActionResult thirdpagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "Janakantha third page color Advertisement",
                PriceDescription = 9000
            };
            return View(model);
        }
        [SeoBaseTitle("Publish black and white advertisement in janakantha third page through amader ad")]
        [SeoMetaKeywords("amader ad janakantha third page advertisement, janakantha third page black and white advertisement, janakantha 3rd page advertisement,  janakantha 3rd page black and white advbertisement, janakantha 3 number page advertisement, janakantha three number page black and white advertisement, publish advertisement at janakantha third page, advertisement cost at janakantha third page, janakantha third page advertisement rate, black and white advertisement at janakantha third page,")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in janakantha third page")]
        public ActionResult thirdpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha third page black and white advertisement",
                PriceDescription = 7000
            };
            return View(model);
        }
        [SeoBaseTitle("Publish color advertisement in janakantha fifth page through amader ad")]
        [SeoMetaKeywords("amader ad janakantha fifth page advertisement, janakantha fifth page color advertisement, janakantha 5th page advertisement,  janakantha 5th page color advbertisement, janakantha 5 number page advertisement, janakantha five number page color advertisement, publish advertisement at janakantha fifth page, advertisement cost at janakantha fifth page, janakantha fifth page advertisement rate, color advertisement at janakantha fifth page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in janakantha fifth page")]
        public ActionResult fifthpagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha fifth page color advertisement",
                PriceDescription = 7500
            };
            return View(model);
        }
        [SeoBaseTitle("Publish black and white advertisement in janakantha fifth page through amader ad")]
        [SeoMetaKeywords("amader ad janakantha fifth page advertisement, janakantha fifth page black and white advertisement, janakantha 5th page advertisement,  janakantha 5th page black and white advbertisement, janakantha 5 number page advertisement, janakantha five number page black and white advertisement, publish advertisement at janakantha fifth page, advertisement cost at janakantha fifth page, janakantha fifth page advertisement rate, black and white advertisement at janakantha fifth page")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in janakantha third page")]
        public ActionResult fifthpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha fifth page black and white advertisement",
                PriceDescription = 5000
            };
            return View(model);
        }
        [SeoBaseTitle("Publish color advertisement in janakantha sports page through amader ad")]
        [SeoMetaKeywords("amader ad janakantha sports page advertisement, janakantha sports page color advertisement, janakantha sports page advertisement, publish advertisement at janakantha sports page, advertisement cost at janakantha sports page, janakantha sports page advertisement rate, color advertisement at janakantha sports page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in janakantha sports page")]
        public ActionResult sportspagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha sports page color advertisement",
                PriceDescription = 5500
            };
            return View(model);
        }
        [SeoBaseTitle("Publish black and white advertisement in janakantha sports page throgh amader ad")]
        [SeoMetaKeywords("amader ad janakantha sports page advertisement, janakantha sports page black and white advertisement, janakantha sports page advertisement, publish advertisement at janakantha sports page, advertisement cost at janakantha sports page, janakantha sports page advertisement rate, black and white advertisement at janakantha sports page")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in janakantha sports page")]
        public ActionResult sportspageblackandwhiteadvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha sports page black and white Advertisement",
                PriceDescription = 4000
            };
            return View(model);
        }
        [SeoBaseTitle("Publish black and white advertisement in page befor page befor last page of janakantha through amader ad")]
        [SeoMetaKeywords("amader ad janakantha page befor last page black and white page advertisement, janakantha page befor last page black and white page color advertisement, janakantha page befor last page black and white page advertisement, publish advertisement at janakantha page befor last page black and white  page, advertisement cost at janakantha page befor last page black and white page, janakantha page befor last page black and white page advertisement rate, black and white advertisement at janakantha page befor last page")]
        [SeoMetaDescription("Through Amader Ad publish your black and white advertisement in janakantha page befor last page")]
        public ActionResult pagebeforlastpageblackandwhiteAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha page befor last page black and white advertisement",
                PriceDescription = 4500
            };
            return View(model);
        }
        [SeoBaseTitle("Publish color advertisement in jankantha last page through amader ad")]
        [SeoMetaKeywords("amader ad janakantha last page advertisement, janakantha last page color advertisement, janakantha last page advertisement, publish advertisement at janakantha last  page, advertisement cost at janakantha last page, janakantha last page advertisement rate, color advertisement at janakantha last page")]
        [SeoMetaDescription("Through Amader Ad publish your color advertisement in janakantha last page")]
        public ActionResult lastpagecolorAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha last page color advertisement",
                PriceDescription = 12000
            };
            return View(model);
        }
        [SeoBaseTitle("Publish spot advertisement in janakantha first page through amader ad")]
        [SeoMetaKeywords("amader ad janakantha first page spot advertisement, janakantha first page spot advertisement, publish spot advertisement at janakantha first page,spot advertisement cost at janakantha first page, janakantha first page spot advertisement rate, spot advertisement at janakantha first page")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in janakantha first page")]
        public ActionResult firstpagespotAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "janakantha first page spot advertisement",
                PriceDescription = 20000
            };
            return View(model);
        }
        [SeoBaseTitle("Publish spot advertisement in janakantha last page through amader ad")]
        [SeoMetaKeywords("amader ad janakantha last page spot advertisement, janakantha last page spot advertisement, publish spot advertisement at janakantha last page,spot advertisement cost at janakantha last page, janakantha last page spot advertisement rate, spot advertisement at janakantha last page")]
        [SeoMetaDescription("Through Amader Ad publish your spot advertisement in janakantha last page")]
        public ActionResult lastpagespotAdvertisement_MainPage()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "jankantha last page spot advertisement",
                PriceDescription = 15000
            };
            return View(model);
        }
    }
}