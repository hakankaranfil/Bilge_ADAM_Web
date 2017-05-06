using Protein.DAL.Repo;
using Protein.Entity;
using Protein.Entity.Model;
using Protein.Entity.View;
using Protein.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Protein.Web.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var result = CustomerRepo.Get(customer);

                if (result != null)
                {
                    //FormsAuthentication.SetAuthCookie(customer.Email, true);
                    
                    Session["email"] = customer.Email;
                    Session["Name"] = customer.Name;
                    //Session["password"] = customer.Password;
                    Session["Customer"] = result;
                    Chart.ShoppingList.Clear();
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ViewBag.Message = "Hata";
            }
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                CustomerRepo.Add(customer);
                Session["Email"] = customer.Email;
                Session["Customer"] = customer;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Hata";
            }
            return View();

        }
        public ActionResult Logout()
        {
            Session.Abandon();
            Chart.ShoppingList.Clear();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Account(Customer newcustomer)
        {
            {
                if (newcustomer.CustomerID == 0)
                {
                    var customer = Session["Customer"] as Customer;
                    return View(customer);
                }
                else
                {
                    return View(newcustomer);
                }
            }

        }
        [HttpPost]
        public ActionResult UpdatedInfo(Customer customer)
        {
            var updated = CustomerRepo.UpdateCustomerInfo(customer);
            return RedirectToAction("Account", "Customer", updated);
        }
    }
}
