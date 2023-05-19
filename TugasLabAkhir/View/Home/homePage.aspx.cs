using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TugasLabAkhir.View.Home
{
    public partial class homePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["UserData"] == null)
            {
                Response.Redirect("~/View/Login/loginPage.aspx");
            }
        }
    }
}