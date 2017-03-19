using Blog_MVC_DAL.Repos;
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
        public ActionResult GET(WAdmin model)
        {
            if (AdminRepo.Get(model.UserName,model.Password)!=null)
            {
                return RedirectToAction("Index", "Dashboard");
            }    
                return View();
            
        }
       
    }
}