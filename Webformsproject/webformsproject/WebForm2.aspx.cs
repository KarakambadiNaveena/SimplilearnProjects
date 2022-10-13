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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
           




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();

            int studid = Int32.Parse(TextBox1.Text);
            Label2.Text = c.Findstudent(studid);
            
        }
    }
}