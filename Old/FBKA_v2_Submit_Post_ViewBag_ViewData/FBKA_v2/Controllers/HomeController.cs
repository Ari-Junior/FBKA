using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FBKA_v2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Results()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sobre a FBKA...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contatos FBKA...";

            return View();
        }
    }
}