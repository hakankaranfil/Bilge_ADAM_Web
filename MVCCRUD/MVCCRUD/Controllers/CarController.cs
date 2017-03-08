using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Add()
        {
            ViewBag.Header = "Araba Ekle";
            return View();
        }
    }
}