using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspNetMvcForMac
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			// #BUG: Error CS1061: Type `System.Web.Routing.RouteCollection' does not contain a definition for `LowercaseUrls' and no extension method `LowercaseUrls' of type `System.Web.Routing.RouteCollection' could be found. Are you missing an assembly reference? (CS1061) (AspNetMvcForMac)
			// routes.LowercaseUrls = true;

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Pages", action = "Overview", id = UrlParameter.Optional }
            );
        }
    }
}
