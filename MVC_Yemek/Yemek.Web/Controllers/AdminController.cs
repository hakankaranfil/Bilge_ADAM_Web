using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Yemek.DAL;
using Yemek.Entity.Model;
using Yemek.Web.Attiribute;
using Yemek.Web.Models;

namespace Yemek.Web.Controllers
{
    [LoginControl]//Sistemde Olup olmadığı kontrolü için
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Admin()
        {
            ViewBag.Name = HttpContext.User.Identity.Name;
            return View();
        }
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
        public ActionResult Add()
        {
            ViewBag.Soup = new SelectList(SoupRepo.GetAllSoup(), "ID", "Name");
            return View();
        }

    }
}