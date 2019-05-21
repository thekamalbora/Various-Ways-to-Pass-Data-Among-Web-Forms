using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HowtoPassDatabtwPages
{
    public partial class Transfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem[] items = new ListItem[3];
                items[0] = new ListItem("Red", "1");
                items[1] = new ListItem("Blue", "2");
                items[2] = new ListItem("Green", "3");

                ddl1.Items.AddRange(items);
                ddl1.DataBind();
                items = null;
            }
        }

        protected void btnPage2_Click(object sender, EventArgs e)
        {
            Server.Transfer("RetrieveData.aspx", true);
        }
    }
}