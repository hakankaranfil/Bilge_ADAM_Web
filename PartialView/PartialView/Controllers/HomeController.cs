using PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CustomerInformation model = new CustomerInformation();
            return View(model);
        }
        public PartialViewResult UserList()
        {
            CustomerEntities db = new CustomerEntities();
            List<CustomerInformation> user = db.CustomerInformations.ToList();
            return PartialView(user);
        }
        [HttpPost]
        public string Add (CustomerInformation model)
        {
            CustomerEntities db = new CustomerEntities();
            CustomerInformation cs = new CustomerInformation();
            cs.Name = model.Name;
            cs.Surname = model.Surname;
                db.CustomerInformations.Add(cs);
                db.SaveChanges();
                return "1";
            
         
        }
    }
}