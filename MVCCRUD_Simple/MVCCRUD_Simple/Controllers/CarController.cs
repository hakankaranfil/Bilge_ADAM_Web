using MVCCRUD_Simple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD_Simple.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Add()
        {
            ViewBag.Header = "Araba Ekle";
            return View();
           
        }
        // View'dan dönen Post işlemi yakalar (Araç Ekleme, Kaydetme işlemi)
        [HttpPost]
        public ActionResult Add(Car model)
        {
            if (ModelState.IsValid)
            {
                using (KaranfilDBContext db = new KaranfilDBContext())
                {
                    db.Car.Add(model);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("List", "Car");
        }
        public ActionResult List()
        {
            ViewBag.Header = "Tüm Arabalar";

            using (KaranfilDBContext db = new KaranfilDBContext())
            {
                // Silinmemiş Arabalar Listeleniyor
                var result = db.Car.Where(c => c.IsDeleted == false).ToList();

                return View(result);
            }
        }
        // Araba Silme İşlemi
        public ActionResult Delete(int id)
        {
            using (KaranfilDBContext db = new KaranfilDBContext())
            {
                // Gelen id'ye ait arabayı getirir ve IsDeleted özelliği false
                // yapıp listede görülmesini engeller
                var result = db.Car.Find(id);
                result.IsDeleted = true;
                db.SaveChanges();

                return RedirectToAction("List", "Car");
            }
        }
    }
}