using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
using Web.Models.Routing;

namespace Web
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add(new Route("shop/{shop_code}/{*action}", new ShopRouteHandler("~/shop/{action}.aspx")));
            routes.EnableFriendlyUrls();
        }
    }
}
