using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace TP3.EF.TP8.APIRQ.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult NasaRQ()
        {

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
