using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HowtoPassDatabtwPages
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPage2_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("RetrieveData.aspx?user={0}&id={1}&country={2}", txtName.Text, 1,TextBox1.Text));
        }
    }
}