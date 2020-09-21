﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace IdentitySample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "FrontEnd", action = "Index", id = UrlParameter.Optional }
            );

            // ALL THE FRONTEND PAGES
            routes.MapRoute(
                name: "FrontEnd",
                url: "FrontEnd/{action}/{id}",
                defaults: new
                {
                    controller = "FrontEnd",
                    action = "All",
                    id = UrlParameter.Optional
                }
            );

        }
    }
}