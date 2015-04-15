using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI; 
using System.Web.Compilation;
using System.Diagnostics;

namespace Web.Models.Routing
{
    public class ShopRouteHandler : IRouteHandler
    {
        public ShopRouteHandler(string virtualPath)
        {
            this.VirtualPath = virtualPath;
        }

        public string VirtualPath { get; set; }
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            Object obj = requestContext.RouteData.Values["action"];
            String action;
            if(obj == null)
            {
                action = "Default";
            }
            else
            {
                action = obj.ToString();
            }

            String vPath = VirtualPath.Replace("{action}", action);

            Debug.WriteLine(vPath);
            return BuildManager.CreateInstanceFromVirtualPath(vPath, typeof(System.Web.UI.Page)) as IHttpHandler;
        }
    }
}