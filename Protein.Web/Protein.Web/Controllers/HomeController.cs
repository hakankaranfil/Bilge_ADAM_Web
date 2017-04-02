using Protein.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Protein.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Category = CategoryRepo.GetAllForHome();
            ViewBag.Product = ProductRepo.GetAllForHome();
            return View();
        }
        public ActionResult ProductDetails(int id)
        {
            var result = ProductRepo.Get(id);
            return View(result);
        }
    }
}