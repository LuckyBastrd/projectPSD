using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;

namespace TugasLabAkhir.View.Register
{
    public partial class registerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registBtn_Click(object sender, EventArgs e)
        {

            string name = userTbx.Text;
            string email = emailTbx.Text;
            string gender = genderRdb.Text;
            string password = passTbx.Text;
            string confirm = confirmTbx.Text;
            string role = roleDDL.Text;

            errorLbl.Text = userController.registUser(name, email, gender, password, role, confirm);

            if(errorLbl.Text == "Registration success")
            {
                string roleId = role;
                Application["roleId"] = roleId;

                Response.Redirect("~/View/Home/homePage.aspx");
            }
        }

        protected void loginLbtn_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/View/Login/loginPage.aspx");

        }
    }
}