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

            if (role == "1")
            {
                Response.Redirect("~/View/Admin/adminHome.aspx");
            }

            else if (role == "2")
            {
                Response.Redirect("~/View/Staff/staffHome.aspx");
            }

            else
            {
                Response.Redirect("~/View/Customer/customerHome.aspx");
            }

        }

        protected void loginLbtn_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/View/Login/guestLogin.aspx");

        }
    }
}