using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVV_SİMPLE2.Controllers
{
    public class HomeController : Controller
    {
        // ActionResult Controller ile Wiew arasındaki ilişkileri  sağlayan metoddur.Olmak zorundadır.
        public ActionResult Index()
        {
            ViewData["Mesasage1"] = "Bu bir View data mesajıdır.";
            ViewBag.Message2="Bu bir ViewBag Mesajıdır.";
            TempData["Message3"] = "Bu bir Tempdata mesajıdır";//Farklı vir view e veri göndermek için
            return RedirectToAction("TempData");
            //return View();
        }
        public ActionResult Tempdata()
        {
            return View();
        }
    }
}