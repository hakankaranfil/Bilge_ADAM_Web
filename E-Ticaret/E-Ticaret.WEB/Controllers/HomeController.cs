using E_Ticaret.DAL.Models;
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
         var result=BookRepo.Get(id);
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
        static List<ViewBookForHome> ShoppingList = new List<ViewBookForHome>();

        public ActionResult Sepetim(int? id) //book id 
        {
            if (id.HasValue)
            {
                ShoppingList.Add(BookRepo.GetBookForShop((int)id));

                ViewBag.Liste = ShoppingList;
                return View();
            }

            ViewBag.Liste = ShoppingList;
            return View();

        }
    }
}