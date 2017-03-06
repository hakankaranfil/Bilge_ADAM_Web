using MVC_Rent_A_Car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Rent_A_Car.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Car Brand)
        {
            return View();
        }
    }
}