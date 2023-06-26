using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationWithDB
{
    public partial class RedirectPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //QueryString
            Label1.Text = "Welcome" + Request.QueryString["myname"];
            //Session
            if (Session["username"] == null)
            {
                Response.Redirect("ViewState.aspx");
            }
            else
            {
                LoginRedirect.Text = Session["username"].ToString();
            }

        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewState.aspx");
        }
    }
}