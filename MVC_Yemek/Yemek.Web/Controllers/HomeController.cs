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
            JsonResultModel jmodel = new JsonResultModel();
            if (customer.Email != null)
            {
                var c = CustomerRepo.GetCustomer(customer);
                if (c == null)
                {
                    CustomerRepo.Add(customer);
                    jmodel.IsSuccess = true;
                }
                else
                {
                    jmodel.IsSuccess = false;
                }
            }
            else
            {
                return null;
            }
            return Json(jmodel, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Menu()
        {
            var model = MenuRepo.MenuList();
            return View(model);
        }
    }
}
