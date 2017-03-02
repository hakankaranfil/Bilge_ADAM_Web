using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Layer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Ana Sayfa";
            return View();
        }
        public ActionResult Video()
        {
            ViewBag.Title = "Video";
            return View();
        }
        public ActionResult Mail()
        {
            return View();
        }
    }
}