using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AmaderAd.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using AmaderAd.DAL;
using System.Configuration;
using AmaderAd.Filters;
using AspNetSeo.Mvc;

namespace AmaderAd.Controllers
{
    [ExceptionHandler]
    [SeoBaseTitle("Amader Ad")]
    [SeoBaseLinkCanonical("http://www.amaderad.net/")]
    public class HomeController : BaseController
    {
        [SeoTitle("Homepage")]
        public ActionResult Index()
        {
            Log.Info("App started...");
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
