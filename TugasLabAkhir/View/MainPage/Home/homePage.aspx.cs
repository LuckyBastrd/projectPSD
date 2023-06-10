using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.MainPage.Home
{
    public partial class homePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["UserData"] == null)
            {
                Response.Redirect("~/View/MainPage/Login/loginPage.aspx");
            }

            string role = Application["roleId"].ToString();

            if (role == "1")
            {
                staffGV.DataSource = userController.getAllUser(2);
                staffGV.DataBind();
            } else if (role == "2")
            {
                customerGV.DataSource = userController.getAllUser(3);
                customerGV.DataBind();
            }

        }
    }
}