using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ICodePretty
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // /Blog/friendly-name

            routes.MapRoute(
                name: "Blog", // route name
                url: "blog/{name}", // URL with params
                defaults: new { controller = "Blog", action = "Search", name = UrlParameter.Optional } // param defaults
            );


            // /Home

            routes.MapRoute(
                name: "Default", // route name
                url: "{controller}/{action}/{id}", // URL with params
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } // param defaults
            );
        }
    }
}