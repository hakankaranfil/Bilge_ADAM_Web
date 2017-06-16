using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;
using Yemek.DAL;
using Yemek.DAL.Repo;
using Yemek.Entity.Model;
using Yemek.Entity.ViewModel;
using Yemek.Web.Attiribute;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Net.Security;

namespace Yemek.Web.Controllers
{
    [LoginControl]//Sistemde Olup olmadığı kontrolü için
    public class AdminController : Controller
    {
        // GET: Admin

        public ActionResult Admin()
        {
            ViewBag.Name = HttpContext.User.Identity.Name;
            return View();
        }
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
        public ActionResult Add()
        {
            var model = ProductRepo.GetAllForHome();
            return View(model);
        }

        [HttpPost]
        public JsonResult Add(List<Product> list)
        {
            JsonResultModel m = new JsonResultModel();
            foreach (var item in list.ToArray())
            {
                if (item.IsSelected == true)
                {
                    MenuRepo.AddMenu(item);

                }
            }
            m.IsSuccess = true;
            return Json(m, JsonRequestBehavior.AllowGet);


        }
        public ActionResult Home()
        {
            return View();
        }
        public PartialViewResult AdminMenuList(DateTime menuDate)
        {

            var model = MenuRepo.AdminMenuList(menuDate);
            return PartialView("~/views/Shared/Admin/_viewMenu.cshtml", model);
        }
        public ActionResult Delete(int id)
        {
            //var result=MenuRepo.DeleteMenu(id);
            //    var model = MenuRepo.AdminMenuList(id);
            //return RedirectToAction("Home", "Admin");

            using (YemekDBContext db = new YemekDBContext())
            {
                var result = db.Menu.FirstOrDefault(m => m.MenuID == id);
                result.IsDelete = true;
                db.SaveChanges();
                return RedirectToAction("AdminMenuList", new { menuDate = result.Datetime });
            }
        }
        public ActionResult Mail()
        {
            var model = MailRepo.Menu();
            return View(model);
        }

        //foreach ( var item in model)
        //{
        //    c.Add(item.Email);
        //}
        //    foreach (var item in maillist.ToArray())
        //    {
        //        WebMail.SmtpServer = "smtp.gmail.com";
        //        WebMail.EnableSsl = true;
        //        WebMail.UserName = "hakankaranfil123@gmail.com";
        //        WebMail.Password = "hakan123.";
        //        WebMail.SmtpPort = 587;
        //        WebMail.Send(
        //                c.ToList(),
        //                item.Konu,
        //               "hakan"
        //);                  
        //    }
        [HttpPost]
        public ActionResult Mail(List<ViewMail> maillist)
        {


            Customer cs = new Customer();
            var model = CustomerRepo.CustomerList();
            MailMessage msg = new MailMessage();//yeni bir mail nesnesi Oluşturuldu.
            msg.IsBodyHtml = true; //mail içeriğinde html etiketleri kullanılsın mı?
            foreach (var item in model)
            {
                msg.To.Add(item.Email);//Kime mail gönderilecek.
            }
            msg.From = new MailAddress("hakankaranfil123@gmail.com", "İletişim ", System.Text.Encoding.UTF8);//mail kimden geliyor, hangi ifade görünsün?
            msg.Subject = "Siteden gelen mesaj (İletişim formu)";//mailin konus 7
            foreach (var item in maillist)
            {
                     msg.Body +="<h3>" + item.GonderilecekMail + "</h3><br>";
                    /*"<center><h1 style='color:blue'>Hello</h1><h3>" + DateTime.Now.ToString("dd-MM-yyyy") + "</h3><li>"; */
            }
                   

            msg.IsBodyHtml = true;
            SmtpClient smp = new SmtpClient();
            smp.Credentials = new NetworkCredential("hakankaranfil123@gmail.com", "hakan123.");//mailin gönderileceği adres ve kullanıcı adı,şifresi
            smp.Port = 587;
            smp.Host = "smtp.gmail.com";//gmail üstrzerinden gönderiliyor.
            smp.EnableSsl = true;
            smp.Send(msg);//msg isimli mail gönderiliyor.
            return View();
        }
     
    }

}











