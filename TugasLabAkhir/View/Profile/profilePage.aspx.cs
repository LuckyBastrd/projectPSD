using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;

namespace TugasLabAkhir.View.Profile
{
    public partial class profilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int user = (int)Application["User"];
            string pass = (string)Application["Pass"];

            int Id = user;
            string name = updNameTbx.Text;
            string email = updEmailTbx.Text;
            string gender = updGenderRdb.Text;
            string password = passTbx.Text;
            string confirmPass = pass;

            errLbl.Text = userController.updateUser(Id, name, email, gender, password, confirmPass);

            if (errLbl.Text == "Update Profile Success")
            {
                errLbl.Text = "Update Profile Success";
            }


        }
    }
}