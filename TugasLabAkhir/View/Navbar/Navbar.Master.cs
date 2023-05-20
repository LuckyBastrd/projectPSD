using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.View.Navbar
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        DatabaseEntities5 db = new DatabaseEntities5();
        protected void Page_Load(object sender, EventArgs e)
        {
            //int role = (int)Application["Role"];

            string role = Session["User"].ToString();

            if (role == "1")
            {
                roleName.Text = "Admin";

                adminNavbar.Visible = true;
                staffNavbar.Visible = false;
                customerNavbar.Visible = false;
            }

            else if (role == "2")
            {
                roleName.Text = "Staff";

                staffNavbar.Visible = true;
                adminNavbar.Visible = false;
                customerNavbar.Visible = false;
            }

            else if (role == "3")
            {
                roleName.Text = "Customer";

                customerNavbar.Visible = true;
                adminNavbar.Visible = false;
                staffNavbar.Visible = false;
            }
        }

        //Profile Button
        protected void profBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile/profilePage.aspx");
        }

        protected void proflBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile/profilePage.aspx");
        }

        protected void profileBtn_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile/profilePage.aspx");
        }

        //Log Out Button
        public void logOut()
        {
            HttpCookie cookie = Request.Cookies["UserData"];

            if (cookie == null)
            {
                Session.Clear();

                Response.Redirect("~/View/Login/loginPage.aspx");
            }

            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);

            Session.Clear();

            Response.Redirect("~/View/Login/loginPage.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            logOut();

        }

        protected void outBtn_Click(object sender, EventArgs e)
        {
            logOut();
        }

        protected void logBtn_Click(object sender, EventArgs e)
        {
            logOut();
        }

        protected void manageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageRamen/manageRamen.aspx");
        }

        protected void mngBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageRamen/manageRamen.aspx");
        }
    }
}