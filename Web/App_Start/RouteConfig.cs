using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace Web
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "Shop",
                "shop/{shop_id}/",
                "~/shop/Default.aspx"
            );
            routes.EnableFriendlyUrls();
        }
    }
}
