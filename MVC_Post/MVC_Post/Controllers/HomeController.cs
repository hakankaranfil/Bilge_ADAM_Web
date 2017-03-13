using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Post.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            //YÖNTEM1
            //if (Request.HttpMethod=="POST")
            //{
            //    string username = Request.Form.Get("txtusername");
            //    string password = Request.Form.Get("txtPassword");
            //    ViewBag.Ad = username;
            //}
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection frm)
        {
            string name = frm.Get("txtusername");
            string pass = frm.Get("txtPassword");
            if (name == "yavuz" && pass == "123")
            {

                Session["name"] = "yavuz";
                Session["pass"] = "123";
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.message = "hatalı giriş";
                return View();
            }
        }
        public ActionResult LoginAjax(string name, string pass)
        {
            if (name == "yavuz" && pass == "123")
            {
                Session["name"] = "yavuz";
                Session["pass"] = "123";
                return Json(new
                {
                    success = true,
                    message = "GirişBaşarılı"
                });
            }

            else
            {
                return Json(new
                {
                    success = false,
                    message = "GirişBaşarısız"
                });

            }


            }
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index","Home");
        }

        }
    }

