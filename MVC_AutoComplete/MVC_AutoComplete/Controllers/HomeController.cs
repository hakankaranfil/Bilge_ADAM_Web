using MVC_AutoComplete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_AutoComplete.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Search(string tem)
        {
            KutuphaneDBEntities db = new KutuphaneDBEntities();
            IEnumerable<Book> lsit = db.Books.Where(b => b.BookName.StartsWith(tem));
            var model = from b in lsit
                        select new
                        {
                            id = b.BookID,
                            value = b.BookName,
                            Url = "/Category/Details/" + b.BookID,

                        };
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}