using E_Ticaret.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret.WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Category = CategoryRepo.GetAllForHome();
            ViewBag.Book = BookRepo.GetAllForHome();
            return View();
        }
        public ActionResult BookDeatails(int id)
        {
         var result=BookRepo.Get(id);
            return View(result);
        }
    }
}