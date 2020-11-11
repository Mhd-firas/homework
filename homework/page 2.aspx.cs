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

        }

        protected void btn_check_Click(object sender, EventArgs e)
        {
            if (chb_one.Checked != true)
                chb_one.Checked = true;
            else chb_one.Checked = false;
        }
    }
}