using Blog_MVC_DAL.Models;
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

        public ActionResult AddPost(int? id)//patametrenin null geldiğini gösterebilmek için ? koyuyoruz
        {
            if (id.HasValue)
            {
                ViewBag.Header = "Yazı Güncelle";
                var post = PostRepo.Get((int)id);
                var cat = CatagoryRepo.Get(post.CategoryID);

                WPost vmpost = new WPost();
                vmpost.Title = post.Title;
                vmpost.Content = post.Concent;
                vmpost.Category = cat.Name;
                vmpost.PostID = post.PostID;
                foreach (var item in post.Tags)
                {
                    vmpost.Tags += item.Name + ",";
                }

                return View(vmpost);
            }
            else
            {
                ViewBag.Header = "Yazı Ekle";
                return View();
            }

        }
        [ValidateInput(false)]//İçerik düzgün gelmemesi halinde bile o veriyi alabiliyoruz
        [HttpPost]
        public ActionResult AddPost(WPost model)
        {
            string[] etiketler = model.Tags.Split(',');//Her virgülden sonrasını Obje olarak alıyor.
            List<Tag> tags = new List<Tag>();
            foreach (var item in etiketler)
            {
                tags.Add(new Tag { Name = item.Trim() });//Trim baştaki ve sondaki boşlıkları siler.
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
            pst.Concent = model.Content;
            pst.Tags = tags;
            pst.CategoryID = catID;
            pst.AdminID = 1;
           
            if (model.PostID == 0)
            {
                PostRepo.Add(pst);
            }
            else
            {
                pst.PostID = model.PostID;
                PostRepo.Uptade(pst);
            }
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
            return RedirectToAction("List", "DashBoard");
        }
      
    }
}