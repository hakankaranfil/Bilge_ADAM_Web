using E_Ticaret.DAL.Models;
using E_Ticaret.Entity.Model;
using E_Ticaret.Entity.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret.WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Category = CategoryRepo.GetAllForHome();
            ViewBag.Book = BookRepo.GetAllForHome();
            return View();
        }
        public ActionResult BookDeatails(int id)
        {
            var result = BookRepo.Get(id);
            return View(result);
        }
        public ActionResult Category(int id)
        {
            ViewBag.Category = CategoryRepo.GetAllForHome();
            ViewBag.Book = BookRepo.GetAllBook(id);
            ViewBag.Message = CategoryRepo.GetCategoryName(id);

            return View();
        }
        public ActionResult Writer(int id)
        {
            return View(BookRepo.GetAllForWriter(id));
        }


        static List<Product> ShoppingList = new List<Product>();

        [HttpPost]
        public ActionResult BookDeatails(ViewBookForDetails model, int BookCount) //book id 
        {
            if (ShoppingList.Count == 0)
            {
                Product p = new Product()
                {
                    BookID = model.BookID,
                    BookName = model.BookName,
                    BookCount = BookCount,
                    Price = model.Price,
                    BookPhotoURL = model.BookPhotoURL,
                };
                ShoppingList.Add(p);
            }
            else
            {
                foreach (var item in ShoppingList)
                {
                    if (item.BookID == model.BookID)
                    {
                        item.BookCount++;
                        ViewBag.Liste = ShoppingList;
                        return RedirectToAction("Sepetim", "Home");
                    }
                }
                Product p = new Product()
                {
                    BookID = model.BookID,
                    BookName = model.BookName,
                    BookCount = BookCount,
                    Price = model.Price,
                    BookPhotoURL = model.BookPhotoURL,
                };
                ShoppingList.Add(p);
                ViewBag.Liste = ShoppingList;
                return RedirectToAction("Sepetim", "Home");

            }

            ViewBag.Liste = ShoppingList;
            return RedirectToAction("Sepetim", "Home");
        }
            
        
        public ActionResult Sepetim()
        {
            ViewBag.Liste = ShoppingList;
            return View();

        }
        [HttpPost]
        public ActionResult Sepetim(decimal Total)
        {
            //ViewBag.Total = Total;
            ViewBag.Liste = ShoppingList;
            return RedirectToAction("Ödeme", "Home");

        }
        public ActionResult Ödeme()
        {
            ViewBag.Liste = ShoppingList;
            return View();
        }
        [HttpPost]
        public ActionResult Ödeme(Customer model)
        {
            Customer c = new Customer();
            c.NameSurname = model.NameSurname;
            c.BookCount = model.BookCount;
            c.Address = model.Address;
            c.Total = model.Total;
            return View();
        }
    }
}