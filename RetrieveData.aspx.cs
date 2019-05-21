using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HowtoPassDatabtwPages
{
    public partial class RetrieveData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Cookies
                if (Request.Cookies["user"] != null)
                {
                    lbl1.Text = Request.Cookies["User"].Value;
                }

                //QueryString
                if (Request.QueryString["user"] != null)
                {
                    lbl2.Text = Request.QueryString["user"];
                }

                if (Request.QueryString["id"] != null)
                {
                    lbl2.Text = Request.QueryString["user"] + " and id =" + Request.QueryString["id"];
                }

                if (Request.QueryString["country"] != null)
                {
                    lbl2.Text = Request.QueryString["user"] + " and id =" + Request.QueryString["id"] + " and country =" + Request.QueryString["country"];
                }

                //Sessions
                if (Session["user"] != null)
                {
                    lbl3.Text = Session["user"].ToString();
                }
                if (Session["id"] != null)
                {
                    lbl3.Text = Session["user"].ToString() + " and id =" + Session["id"].ToString();
                }
                if (Session["colors"] != null)
                {
                    List<string> col = new List<string>();
                    col = (List<string>)Session["colors"];

                    foreach (var item in col)
                    {
                        lbl3.Text += " " + item + ", ";
                    }
                    col = null;
                }

                //CrossPagePosting
                if (Page.PreviousPage != null)
                {
                    DropDownList ddl = (DropDownList)Page.PreviousPage.FindControl("ddl1");
                    if (ddl != null)
                    {
                        lbl4.Text = ddl.SelectedItem.Text;
                        lbl4.ForeColor = System.Drawing.Color.FromName(lbl4.Text);
                    }
                }

                //Server.Transfer
                if (Request.Form["ddl1"] != null)
                {
                    lbl5.Text = Request.Form["ddl1"];
                }
            }
        }
    }
}