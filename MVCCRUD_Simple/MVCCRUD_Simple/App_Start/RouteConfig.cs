using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCCRUD_Simple
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

       
           

       
            routes.MapRoute(
                name: "Default4",
                url: "panel",
                defaults: new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default3",
                url: "add-vehicle",
                defaults: new { controller = "Vehicle", action = "Add", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default2",
                url: "list-vehicle",
                defaults: new { controller = "Vehicle", action = "List", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
