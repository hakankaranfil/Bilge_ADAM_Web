using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemek.DAL;
using Yemek.Entity.Model;
using Yemek.Entity.ViewModel;


namespace Yemek.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Register(Customer customer)
        {
            JsonResultModel m = new JsonResultModel();
            if (ModelState.IsValid)
            {
                var c = CustomerRepo.GetCustomer(customer);
                if (c == null)
                {
                    CustomerRepo.Add(customer);
                    m.IsSuccess = true;
                }
            }
         return Json(m, JsonRequestBehavior.AllowGet);
        }
        //}

        public ActionResult Menu()
        {
            var model = MenuRepo.MenuList();
            return View(model);
        }
    }
}
