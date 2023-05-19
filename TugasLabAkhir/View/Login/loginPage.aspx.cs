using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.View.Login
{
    public partial class loginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string name = nameTbx.Text;
            string password = passwordTbx.Text;

            User u = userController.login(name, password);

            if (u == null)
            {
                errorLbl.Text = "Invalid User";
            }

            else
            {
                Session["User"] = u;


                if (rememberChb.Checked)
                {
                    HttpCookie cookie = new HttpCookie("UserData");
                    cookie["UserName"] = u.UserName;
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }

                int roleId = u.RoleId;
                Application["Role"] = roleId;
                Response.Redirect("~/View/Home/homePage.aspx");
            }

            

        }

        protected void registerLbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Register/registerPage.aspx");
        }
    }
}