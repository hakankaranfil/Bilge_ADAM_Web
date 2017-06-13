using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Yemek.DAL;
using Yemek.DAL.Repo;
using Yemek.Entity.Model;
using Yemek.Entity.ViewModel;


namespace Yemek.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Register(Customer customer)
        {
            JsonResultModel m = new JsonResultModel();
            if (ModelState.IsValid)
            {
                var c = CustomerRepo.GetCustomer(customer);
                if (c == null)
                {
                    CustomerRepo.Add(customer);
                    m.IsSuccess = true;
                }
            }
            return Json(m, JsonRequestBehavior.AllowGet);
        }
        //}

        public ActionResult Menu()
        {
            var model = MenuRepo.MenuList();
            return View(model);
        }
        public ActionResult Contacts()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Contacts(Concent cn)
        {
            if (ModelState.IsValid)
            {
                MailRepo.Add(cn);
                //MailMessage mail = new MailMessage();
                //mail.To.Add("hakankaranfil123@gmail.com");  //mail gönderilen adres
                //mail.From = new MailAddress(cn.EMail);  //maili gönderen adres
                //mail.Subject = "İletişim Formu";
                //string Body = "İsim: " + cn.Name + " </br>E-Mail : " + cn.EMail + " </br>Message : " + cn.Message + " </br>Phone : " + cn.Phone;
                //mail.Body = Body;
                //mail.IsBodyHtml = true;
                //SmtpClient smtp = new SmtpClient();
                //smtp.Host = "smtp.gmail.com";  //mail serverının host bilgisi
                //smtp.Port = 587;  //mail serverının portu
                //smtp.UseDefaultCredentials = true;
                //smtp.Credentials = new System.Net.NetworkCredential("hakankaranfil123@gmail.com", "hakan123.");  //mail serverının kullanıcı bilgileri
                //smtp.Send(mail);
                //WebMail.SmtpServer = "smtp.gmail.com";
                //WebMail.EnableSsl = true;
                //WebMail.UserName = "hakankaranfil123@gmail.com";
                //WebMail.Password = "hakan123.";
                //WebMail.SmtpPort = 587;
                //WebMail.Send(
                //    "hakankaranfil123@gmail.com",
                //    "İletişim",
                //    "İleti",
                MailMessage msg = new MailMessage();//yeni bir mail nesnesi Oluşturuldu.
                msg.IsBodyHtml = true; //mail içeriğinde html etiketleri kullanılsın mı?
                msg.To.Add("hakankaranfil123@gmail.com");//Kime mail gönderilecek.
                msg.From = new MailAddress(cn.EMail, "Kodyazan İletişim Sayfası", System.Text.Encoding.UTF8);//mail kimden geliyor, hangi ifade görünsün?
                msg.Subject = "Siteden gelen mesaj (İletişim formu)";//mailin konusu
                msg.Body = "Ad:" + cn.Name + "<br>Email:" + cn.EMail + "Konu:" + cn.Phone + "<br>Mesajı:" + cn.Message;//mailin içeriği
                msg.IsBodyHtml = true;
                SmtpClient smp = new SmtpClient();
                smp.Credentials = new NetworkCredential("hakankaranfil123@gmail.com", "hakan123.");//mailin gönderileceği adres ve kullanıcı adı,şifresi
                smp.Port = 587;
                smp.Host = "smtp.gmail.com";//gmail üzerinden gönderiliyor.
                smp.EnableSsl = true;
                smp.Send(msg);//msg isimli mail gönderiliyor.
            };
            return View();
        }
          
        }

    }



