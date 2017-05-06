using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Yemek.DAL;
using Yemek.Entity.Model;
using Yemek.Web.Attiribute;

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
            return View();
        }
        [HttpPost]
        public ActionResult Add(Student model)
        {
            StudentRepo.Add(model);
            return View();
            //Student st = new Student();
            //st.StudentName = model.StudentName;
            //st.StudentSurName = model.StudentSurName;
            //st.StudentPassword = model.StudentPassword;
            //st.StudentNumber = model.StudentNumber;
            //st.StudentEmail = model.StudentEmail;
            //st.StartingDate = model.DueDate;
            //st.Balance = model.Balance;
            //st.StartingDate = model.StartingDate;
            //return View(model);
        }
    }
}