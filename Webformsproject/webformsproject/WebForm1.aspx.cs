using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webformsproject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void Button1_Click(object sender, EventArgs e)
        {

            

            Response.Redirect("~/Webform2.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Webform3.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/Webform4.aspx");
        }
    }
}