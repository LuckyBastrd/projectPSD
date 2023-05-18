using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TugasLabAkhir.View.Admin
{
    public partial class adminNavbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void profBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/adminProfilePage.aspx");
        }
    }
}