using ApiSimple.Service.Models;
using ApiSimple.Service.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiSimple.Service.Controllers
{
    public class CategoryController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();
        public List<Categori> GetAllCategories()
        {
            List<Categori> catList = db.Categories.Select(x => new Categori()
            {
                CategoriID = x.CategoryID,
                CategoriName = x.CategoryName
            }).ToList();
            return catList;
        }
        public Categori Get(int id)
        {
            return db.Categories.Where(c => c.CategoryID == id).Select(x => new Categori()
            {
                CategoriID = x.CategoryID,
                CategoriName = x.CategoryName
            }).FirstOrDefault();
           
        }
        public void Post(Categori kategori)
        {
            Category cat = new Category();
            cat.CategoryName = kategori.CategoriName;
            db.Categories.Add(cat);
            db.SaveChanges();
        }
        public void Put(Categori kategori)
        {
            var cat = db.Categories.FirstOrDefault(c => c.CategoryID == kategori.CategoriID);
            cat.CategoryName = kategori.CategoriName;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var cat = db.Categories.FirstOrDefault(c => c.CategoryID == id);
            db.Categories.Remove(cat);
            db.SaveChanges();
        }
    }
}
