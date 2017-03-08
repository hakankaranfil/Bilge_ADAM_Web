using MVCCRUD_Simple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD_Simple.Controllers
{
    public class MotorController : Controller
    {
        // GET: Motor
        public ActionResult Add()
        {
            ViewBag.Header = "Motor Ekle";
            return View();
        }
        [HttpPost]
        public ActionResult Add(Motor model)
        {
            if (ModelState.IsValid)
            {
                using (KaranfilDBContext db = new KaranfilDBContext())
                {
                    db.Motor.Add(model);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("List", "Motor");
        }
        public ActionResult List()
        {
            using (KaranfilDBContext db = new KaranfilDBContext())
            {
                ViewBag.Header = "Tüm Motorlar";
                var result = db.Motor.Where(c => c.IsDeleted == false).ToList();
                db.SaveChanges();
                return View(result);
            }

        }
        public ActionResult Delete(int id)
        {
            using (KaranfilDBContext db = new KaranfilDBContext())
            {
                var result = db.Motor.Find(id);
                result.IsDeleted = true;
                db.SaveChanges();
                return RedirectToAction("List", "Motor");

            }
        }
    }
}