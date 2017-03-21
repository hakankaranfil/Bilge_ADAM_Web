using Blog_MVC_DAL.Repos;
using Blog_MVC_Entity.Models;
using Bolg_MVC_Web.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bolg_MVC_Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult GET(Admin model)
        {
            var admin = AdminRepo.Get(model);
            if (admin != null)
            {
                Session["ID"] = admin.AdminID;
                Session["UserName"] = admin.UserName;
                Session["Password"] = admin.Password;
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                Response.Write("Kullanıcı Bulunamadı!");
                return View();
            }

        }
       
    }
}