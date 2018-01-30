using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCJan2018
{
    public class CustomRouteConfig
    {
        public static void LoadRoutes(RouteCollection routes)
        {
          //  routes.IgnoreRoute("product/showname");
            routes.MapRoute(
                "firstroute",
                "{controller}/{action}/{id}",                
                new { id=UrlParameter.Optional ,action ="ShowName",controller="product" }
                //,new { id="^r.*" }
                );

            //routes.MapRoute(
            //   "secondroute",
            //   "{controller}/{action}/{id}/{id1}",
            //   new { id = UrlParameter.Optional, id1 = UrlParameter.Optional, }
            //   );


        }
    }
}