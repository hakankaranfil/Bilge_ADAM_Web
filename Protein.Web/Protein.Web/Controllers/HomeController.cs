using PagedList;
using Protein.DAL;
using Protein.DAL.Repo;
using Protein.Entity.Model;
using Protein.Entity.View;
using Protein.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Protein.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? page)
        {
            ViewBag.Category = CategoryRepo.GetAllForHome();
            return View(ProductRepo.GetAllForHome().ToPagedList(page ?? 1, 6));

        }
        public ActionResult ProductCategory(int id)
        {
            var result = ProductRepo.ProductCategory(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Search(string search)
        {
            if (!String.IsNullOrEmpty(search))
            {
                return View(ProductRepo.ProductSearch(search));
            }
            return View();
        }
        public ActionResult ProductDetails(int id)
        {
            var result = ProductRepo.Get(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult ProductDetails(ViewProductForDetails model, int ProductCount)
        {
            if (Chart.ShoppingList.Count == 0)
            {
                ShoppingCart s = new ShoppingCart()
                {
                    ProductID = model.ProductID,
                    ProductName = model.ProductName,
                    ProductCount = ProductCount,
                    Price = model.Price,
                    ProductPhoto = model.ProductPhoto,
                };
                Chart.ShoppingList.Add(s);
            }
            else
            {
                foreach (var item in Chart.ShoppingList)
                {
                    if (item.ProductID == model.ProductID)
                    {

                        item.ProductCount++;
                        ViewBag.Liste = Chart.ShoppingList;
                        return RedirectToAction("Sepetim", "Home");
                    }
                }
                ShoppingCart s = new ShoppingCart()
                {
                    ProductID = model.ProductID,
                    ProductName = model.ProductName,
                    ProductCount = ProductCount,
                    Price = model.Price,
                    ProductPhoto = model.ProductPhoto,
                };
                Chart.ShoppingList.Add(s);
                ViewBag.Liste = Chart.ShoppingList;
                return RedirectToAction("Sepetim", "Home");

            }

            ViewBag.Liste = Chart.ShoppingList;
            return RedirectToAction("Sepetim", "Home");
        }
        public ActionResult Sepetim()
        {
            ViewBag.Liste = Chart.ShoppingList;
            return View();
        }
        [HttpPost]
        public ActionResult Sepetim(decimal Total)
        {
            ViewBag.Total = Total;
            return RedirectToAction("Payment", "Home");
        }
        public ActionResult DeleteProduct(int id)
        {
            var ls = Chart.ShoppingList.Find(c=>c.ProductID==id);
            Chart.ShoppingList.Remove(ls);
            return RedirectToAction("Sepetim", "Home");
        }
        public ActionResult Payment()
        {
            if (Session["email"] != null)
            {
                var logedCustomer = Session["Customer"] as Customer;

                ViewPayment model = new ViewPayment()
                {
                    Address = logedCustomer.Address,
                    Phone = logedCustomer.Phone,
                    ShoppingList = Chart.ShoppingList
                };

                return View(model);
            }
            else
            {
                return RedirectToAction("Login", "Customer");
            }

        }
    }
    }


