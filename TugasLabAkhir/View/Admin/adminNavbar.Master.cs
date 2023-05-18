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
            HttpCookie cookie = Request.Cookies["UserData"];
        }

        protected void profBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/adminProfilePage.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserData"];

            if (cookie == null)
            {
                Response.Redirect("~/View/Login/loginPage.aspx");
            }

            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);

            Session.Clear();

            Response.Redirect("~/View/Login/loginPage.aspx");

        }
    }
}