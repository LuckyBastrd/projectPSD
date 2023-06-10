using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.UserDataPage.Profile
{
    public partial class profilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["UserData"] == null)
            {
                Response.Redirect("~/View/MainPage/Login/loginPage.aspx");
            }

            int userId = int.Parse(Application["userId"].ToString());

            if (!IsPostBack)
            {
                profileGV.DataSource = userController.getUserById(userId);
                profileGV.DataBind();
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
           
            string name = updNameTbx.Text;
            string email = updEmailTbx.Text;
            string gender = updGenderRdb.Text;
            string password = passTbx.Text;
            string confirm = Application["Confirm"].ToString();


            errLbl.Text = userController.updateUser(name, email, gender, password, confirm);

            if (errLbl.Text == "Update Profile Success")
            {
                updNameTbx.Text = string.Empty;
                updEmailTbx.Text = string.Empty;
                passTbx.Text = string.Empty;

                errLbl.Text = "Update Profile Success";
            }
        }
    }
}