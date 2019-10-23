using GeoKatastasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeoKatastasi.Controllers
{
    public class HomeController : Controller
    {
        LocationContext context = new LocationContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpPost]
        public ActionResult Location(decimal lat, decimal lng)
        {
            return Json(new AppService().AddLocation(lat,lng));
        }

        [HttpGet]
        public JsonResult GetLocation()
        {
            var locations = context.Locations.ToList();

            return Json(locations, JsonRequestBehavior.AllowGet);
        }
    }
}
