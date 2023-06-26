using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationWithDB
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_Click(object sender, EventArgs e)
        {

        }
        protected void submit_Click(object sender, EventArgs e)
        {
            ViewState["myValue"] = TextBox1.Text.ToString();
            //myValue = TextBox1.Text.ToString();
            TextBox1.Text = string.Empty;
        }
        protected void restore_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["myValue"].ToString();
        }
        protected void submitQuery_Click(object sender, EventArgs e)
        {
            Response.Redirect("RedirectPage.aspx?myname=" + TextBox2.Text.ToString());
        }
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserName.Text.ToString() == "ram")
            {
                //create session
                Session["username"] = UserName.Text.ToString();
                Response.Redirect("RedirectPage.aspx");
            }
        }
    }
}