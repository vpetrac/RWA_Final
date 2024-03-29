﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RWA_FinalProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Proizvodi", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "PopisRacunaKupca",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "PopisRacunaKupca", action = "Show", id = UrlParameter.Optional }
           );

            

        }
    }
}
