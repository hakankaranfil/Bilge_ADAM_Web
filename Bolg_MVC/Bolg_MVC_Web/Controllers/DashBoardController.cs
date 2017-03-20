using Blog_MVC_DAL.Repos;
using Blog_MVC_Entity.Models;
using Bolg_MVC_Web.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bolg_MVC_Web.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Index()
        {
            ViewBag.Header = "Panel";
            return View();
        }
        public ActionResult AddPost()
        {
            ViewBag.Header = "Yazı Ekle";
            return View();
        }
        public ActionResult AddPost(int id)
        {
            ViewBag.Header = "Yazı Güncelle";
            var result = PostRepo.Get(id);
            return View(result);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult AddPost(WPost model)
        {
            string[] etiketler = model.Tags.Split(',');//Her virgülden sonrasını Obje olarak alıyor.
            List<Tag> tags = new List<Tag>();
            foreach (var item in etiketler)
            {
                tags.Add(new Tag { Name = item });
            }
            int catID;
            if (CatagoryRepo.Get(model.Category) == null)
            {
                CatagoryRepo.Add(new Category { Name = model.Category });
                catID = CatagoryRepo.Get(model.Category).CategoryID;
            }
            else
            {
                catID = CatagoryRepo.Get(model.Category).CategoryID;
            }
            Post pst = new Post();
            pst.Title = model.Title;
            pst.PostDate = DateTime.Now;
            pst.Concent = model.Concent;
            pst.Tags = tags;
            pst.CategoryID = catID;
            pst.AdminID = 1;
            PostRepo.Add(pst);

            return RedirectToAction("List", "Dashboard");
        }
        public ActionResult List()
        {
            ViewBag.Header = "Tüm Yazılar";

            var result = PostRepo.GetALLRating();
            return View(result);
        }
        public ActionResult Delete(int id)
        {
            PostRepo.Delete(id);
            return RedirectToAction("List","DashBoard");
        }
    }
}