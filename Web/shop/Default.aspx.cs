﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace Web.shop
{
    public partial class Default : System.Web.UI.Page
    {
        protected string shopCode;
        protected void Page_Load(object sender, EventArgs e)
        {
            shopCode = Convert.ToString(Page.RouteData.Values["shop_id"]);
        }
    }
}