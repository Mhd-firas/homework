using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace homework
{
    public partial class page_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Application test = "+Application["appone"]+"<br>");
            Response.Write("session test = " + Session["Sone"] + "<br>");
            HttpCookie cookie = Request.Cookies["cook"];
            HiddenField1.Value = cookie["name"];
            Response.Write("Cookie and hidden field test = "+HiddenField1.Value + "<br>");
            string test = Request.QueryString.Get("name");
            Response.Write("querystring test = " + test + "<br>");
        }
    }
}