using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Car model)
        {
            if (ModelState.IsValid)
            {
                using (KaranfilCar db = new KaranfilCar())
                {
                    db.Car.Add(model);
                    db.SaveChanges();
                }
            }
          
                return View();
        }
        public ActionResult list()
        {
            using (KaranfilCar db=new KaranfilCar())
            {
                var result = db.Car.ToList();
                return View(result);
            }
           
        }
    }
}