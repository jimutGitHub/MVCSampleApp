using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "India",
                "US",
                "Austrelia"
            };
            return View();
        }
    }
}