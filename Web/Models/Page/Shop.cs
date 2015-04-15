using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models.Page
{
    public class Shop : System.Web.UI.Page
    {
        protected String shopCode;
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            shopCode = Convert.ToString(Page.RouteData.Values["shop_code"]);
        }
    }
}