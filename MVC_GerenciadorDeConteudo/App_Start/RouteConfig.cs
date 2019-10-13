using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_GerenciadorDeConteudo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             "sobre_fernando_parametro",
             "sobre/{id}/fernando",
              new { controller = "Home", action = "about", id = 0 }
                );

            routes.MapRoute(
               "sobre",
               "sobre",
               new
               {
                   controller = "Home",
                   action = "sobre" +
               ""
               }
               );

            routes.MapRoute(
                "contato",
                "contato",
                new { controller = "Home", action = "contact" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
