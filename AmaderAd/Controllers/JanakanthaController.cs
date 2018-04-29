﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;

namespace AmaderAd.Controllers
{
    public class JanakanthaController : BaseController
    {
        // GET: Janakantha
        public ActionResult Index()
        {
            return View();
        }
        //classified advertisement
        public ActionResult ClassifiedAdvertisement()
        {
            Newspaper model = new Newspaper
            {
                NewspaperName = "Janakantha",
                AdLocation = "JanakanthaClassifiedAdvertisement",
                AllAdCategory = GetAllAdCategory()
            };
            return View(model);
        }
    }
}