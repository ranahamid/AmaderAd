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


namespace AmaderAd.Controllers
{
    [ExceptionHandler]
    public class HomeController : BaseController
    {
        
        public ActionResult Index()
        {
            Log.Info("App started...");
            return View();
        }
    }
}
