using Blog_MVC_DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bolg_MVC_Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PostDetail(int id)
        {

            return View(PostRepo);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Concant()
        {
            return View();
        }
    }
}