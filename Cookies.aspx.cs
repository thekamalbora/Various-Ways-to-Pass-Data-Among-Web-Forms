using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HowtoPassDatabtwPages
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            HttpCookie UserCookie = new HttpCookie("User");
            UserCookie.Value = txtName.Text;
            UserCookie.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(UserCookie);
            lblMsg.Text = "Cookie created !";
        }
    }
}