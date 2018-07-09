using AmaderAd.DAL;
using AmaderAd.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmaderAd.Controllers
{
    [Authorize(Roles = "Admin")]
    [ExceptionHandler]
    public class DashboardController : BaseController
    {
        public DashboardController()
        {
            Db = new AmaderAdDataContext();
        }
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }
        public int TotalLogs()
        {
            var doctorCount = Db.LogTbls.ToList().Count();
            return doctorCount;

        }
    }
}