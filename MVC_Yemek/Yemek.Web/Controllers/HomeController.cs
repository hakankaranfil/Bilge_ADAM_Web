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
            try
            {

                CustomerRepo.Add(customer);
                jmodel.IsSuccess = true;
                jmodel.UserMessage = "Kayıt Başarılı";

            }
            catch (Exception ex)
            {
                jmodel.IsSuccess = false;
                jmodel.UserMessage = "Hata: " + ex.Message;
            }
            return Json(jmodel, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Menu()
        {
            return View();
        }
    }
}
