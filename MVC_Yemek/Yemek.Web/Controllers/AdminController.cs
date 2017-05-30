using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Yemek.DAL;
using Yemek.Entity.Model;
using Yemek.Entity.ViewModel;
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
            var model = ProductRepo.GetAllForHome();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(List<Product> list)
        {

            foreach (var item in list.ToArray())
            {
                if (item.IsSelected == true)
                {
                    MenuRepo.AddMenu(item);

                }
            }
            return RedirectToAction("Menu", "Home");


        }
        public ActionResult Home()
        {
            return View();
        }
        public PartialViewResult AdminMenuList(DateTime menuDate)
        {
            
            var model = MenuRepo.AdminMenuList(menuDate);
            return PartialView("~/views/Shared/Admin/_viewMenu.cshtml", model);
        }
        public ActionResult Delete(int id)
        {
            MenuRepo.DeleteMenu(id);
            return RedirectToAction("Home", "Admin");
        }

    }
}


