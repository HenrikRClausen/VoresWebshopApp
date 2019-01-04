using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VoresWebshop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "KurvMedID",
                url: "Kurv/{id}",
                defaults: new { controller = "Ordrer", action = "Kurv" },
                constraints: new {id = "[0-9]+"}
            );

            routes.MapRoute(
                name: "Kurv",
                url: "Kurv",
                defaults: new { controller = "Ordrer", action = "Kurv" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Produkt", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
