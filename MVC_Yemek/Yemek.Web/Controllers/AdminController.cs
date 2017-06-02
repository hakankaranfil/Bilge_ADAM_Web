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
        public JsonResult Add(List<Product> list)
        {
            JsonResultModel m = new JsonResultModel();
            foreach (var item in list.ToArray())
            {
                if (item.IsSelected == true)
                {
                    MenuRepo.AddMenu(item);

                }
            }
            m.IsSuccess = true;
            return Json(m, JsonRequestBehavior.AllowGet);


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
            //var result=MenuRepo.DeleteMenu(id);
            //    var model = MenuRepo.AdminMenuList(id);
            //return RedirectToAction("Home", "Admin");

            using (YemekDBContext db = new YemekDBContext())
            {
                var result = db.Menu.FirstOrDefault(m => m.MenuID == id);
                result.IsDelete = true;
                db.SaveChanges();
                return  RedirectToAction("AdminMenuList", new { menuDate= result.Datetime });
                //var model = MenuRepo.AdminMenuList(result.Datetime); ;
                //return PartialView("~/views/Shared/Admin/_viewMenu.cshtml", model);
            }
        }
    }
}




