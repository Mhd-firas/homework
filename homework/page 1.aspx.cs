using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace homework
{
    public partial class page_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_send_Click(object sender, EventArgs e)
        {
            ViewState["name"] = txt_one.Text;
            txt_two.Text = ViewState["name"].ToString();
            txt_one.Text = null;
            Session["Sone"]=ViewState["name"];
            Application["appone"] = ViewState["name"];
            HttpCookie cookie = new HttpCookie("cook");
            cookie["name"] = ViewState["name"].ToString();
            Response.Cookies.Add(cookie);
        }

        protected void btn_response_Click(object sender, EventArgs e)
        {
            Response.Redirect("page 2.aspx?name=" + ViewState["name"].ToString());
        }
    }
}