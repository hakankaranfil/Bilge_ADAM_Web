using Blog_MVC_DAL.Repos;
using Blog_MVC_Entity.Models;
using Bolg_MVC_Web.Models;
using PagedList;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Bolg_MVC_Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? page)
        {

            return View(PostRepo.GetAll().ToPagedList(page ?? 1, 2));
        }
        public ActionResult PostDetail(int id)
        {
            return View(PostRepo.Get(id));
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Concant()
        {
            return View();
        }
        [HttpPost]
        
        public async Task<ActionResult> Contact(Mail mail)
        {
            var client = new SendGridClient("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");
            var from = new EmailAddress(mail.Email, mail.Name);
            var subject = "Contact Page";
            var to = new EmailAddress("bengisugultekin@gmail.com", "Bengisu Gültekin");
            var plainTextContent = "The Message from Contact Page";
            var htmlContent =
                mail.Message
                + "<strong> Telefon : " + mail.Phone + "</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);

            return View();

        }
    }
}