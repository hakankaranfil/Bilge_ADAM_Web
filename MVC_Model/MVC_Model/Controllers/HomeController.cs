using MVC_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Student> Ogrenciler = new List<Student>();
            Student ogrenci = new Student();
            ogrenci.StudentID = 1;
            ogrenci.Name =" Hakan";
            ogrenci.Surname = "Karanfil";
            ogrenci.Number = 123;
            Ogrenciler.Add(ogrenci);
            Student ogrenci2 = new Student();
            ogrenci2.StudentID = 2;
            ogrenci2.Name = " Emre";
            ogrenci2.Surname = "Karanfil";
            ogrenci.Number = 123;
            Ogrenciler.Add(ogrenci2);
            ViewBag.ogrenciList = Ogrenciler;
            return View();
        }
    }
}