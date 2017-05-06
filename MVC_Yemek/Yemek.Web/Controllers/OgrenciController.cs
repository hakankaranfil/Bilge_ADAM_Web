using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemek.Web.Attiribute;

namespace Yemek.Web.Controllers
{
    [LoginControl]
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Index()
        {
            return View();
        }
    }
}