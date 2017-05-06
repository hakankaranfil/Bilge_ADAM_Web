using Mvc_Jquery_VeriCekme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Jquery_VeriCekme.Controllers
{
    public class HomeController : Controller
    {
        KutuphaneDBEntities db = new KutuphaneDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetProducts()
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Book> book = db.Books.ToList();
            return Json(book, JsonRequestBehavior.AllowGet);


           
        }
    }
}