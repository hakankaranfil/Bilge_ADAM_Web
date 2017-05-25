using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Yemek.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "GununMenusu",
                url: "Menu/GununMenusu",
                defaults: new { controller = "Home", action = "Menu" }
                );
            routes.MapRoute(
                name: "MenuEkle",
                url: "Menu/MenuEkle",
                defaults: new { controller = "Admin", action = "Add" }
                );
            routes.MapRoute(
           name: "Anasayfa",
           url: "AnaSayfa",
           defaults: new { controller = "Home", action = "Index" }
           );
            routes.MapRoute(
   name: "Uye",
   url: "UyeOl",
   defaults: new { controller = "Home", action = "Register" }
   );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
