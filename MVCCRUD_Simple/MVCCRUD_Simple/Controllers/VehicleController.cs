using MVCCRUD_Simple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD_Simple.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Motor
        public ActionResult Add()
        {
            ViewBag.Header = "Motor Ekle";
            return View();
        }
        [HttpPost]
        public ActionResult Add(Vehicle model)
        {
            if (ModelState.IsValid)
            {
                using (KaranfilDBContext1 db = new KaranfilDBContext1())
                {
                    db.Vehicle.Add(model);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("List", "Vehicle");
        }
        public ActionResult List()
        {
            using (KaranfilDBContext1 db = new KaranfilDBContext1())
            {
                ViewBag.Header = "Tüm Motorlar";
                var result = db.Vehicle.Where(c => c.IsDeleted == false).ToList();
                db.SaveChanges();
                return View(result);
            }

        }
        public ActionResult Delete(int id)
        {
            using (KaranfilDBContext1 db = new KaranfilDBContext1())
            {
                var result = db.Vehicle.Find(id);
                result.IsDeleted = true;
                db.SaveChanges();
                return RedirectToAction("List", "Vehicle");

            }
        }
        [HttpPost]
        public ActionResult Rent(Rent model)
        {
            using (KaranfilDBContext1 db=new KaranfilDBContext1())
            {
                db.Rent.Add(model);
                //db.Vehicle.FirstOrDefault(p => p.VehicleID == model.VehicleID).IsRented = true;
                db.SaveChanges();
            }
            return RedirectToAction("List", "Vehicle");
        }
    }
}