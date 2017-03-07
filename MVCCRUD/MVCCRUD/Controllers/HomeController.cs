using MVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Car car)
        {
            if (ModelState.IsValid)
            {
                using (CarContext db = new CarContext())
                {
                    db.Car.Add(car);
                    db.SaveChanges();
                }
            }
            return View();
        }
        public ActionResult CarList()
        {
            using (CarContext db=new CarContext())
            {
                var result = db.Car.ToList();
                return View(result);
       }

        }
    }
}