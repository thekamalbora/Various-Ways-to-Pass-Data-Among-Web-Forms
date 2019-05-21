using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HowtoPassDatabtwPages
{
    public partial class Sessions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPage2_Click(object sender, EventArgs e)
        {
            Session["user"] = txtName.Text;
            Session["id"] = 1;

            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("green");
            colors.Add("blue");
            Session["colors"] = colors;
            colors = null;

            Response.Redirect("RetrieveData.aspx");
        }
    }
}