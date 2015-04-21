using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sunrise;

namespace Web.Models.Page
{
    public class Shop : System.Web.UI.Page
    {
        protected String shopCode;
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (!Page.RouteData.Values.ContainsKey("shop_code"))
            {
                Response.TrySkipIisCustomErrors = true;
                Server.Transfer("/ErrorPages/Shop404.aspx");
            }

            shopCode = Page.RouteData.Values["shop_code"] as String;

            if(shopCode == "missing")
            {
                Response.TrySkipIisCustomErrors = true;
                Server.Transfer("/ErrorPages/Shop404.aspx");
            }
    
        }
    }
}