using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Web.Models.Page
{
    public class Base404 : System.Web.UI.Page
    {
        protected override void Render(HtmlTextWriter writer)
        {
            base.Render(writer);
            Response.StatusCode = 404;
        }
    }
}