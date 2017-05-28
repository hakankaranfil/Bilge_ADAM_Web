using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Yemek.DAL;
using Yemek.Entity.Model;


namespace Yemek.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin model)
        {
            using (YemekDBContext db = new YemekDBContext())
            {

            var result=AdminRepo.AdminLogin(model);
                if (result!=null)
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("Add", "Admin");
                }
                return View();       
            }
        }
    }
}


