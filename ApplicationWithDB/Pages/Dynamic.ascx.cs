using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationWithDB
{
    public partial class Dynamic : System.Web.UI.UserControl
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
           

        }
    }
}