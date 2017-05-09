using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Yemek.DAL;
using Yemek.Entity.Model;
using Yemek.Web.Models;

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
        public ActionResult Login(ViewLoginType model)
        {
            using (YemekDBContext db = new YemekDBContext())
            {
                var staff = db.Staffs.FirstOrDefault(s => s.StaffEmail == model.Email && s.StaffPassword == model.Password);
                if (staff != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("Admin", "Admin");
                }
                return RedirectToAction("Login", "Login");
            }
        }
    }
}


