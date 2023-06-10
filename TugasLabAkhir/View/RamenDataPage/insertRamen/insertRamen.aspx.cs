using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;

namespace TugasLabAkhir.View.RamenDataPage.insertRamen
{
    public partial class insertRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["UserData"] == null)
            {
                Response.Redirect("~/View/MainPage/Login/loginPage.aspx");
            }

            string role = Application["roleId"].ToString();

            if (role == "3")
            {
                Response.Redirect("~/View/MainPage/Home/homePage.aspx");
            }
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RamenDataPage/ManageRamen/manageRamen.aspx");
        }

        protected void addRamenBtn_Click(object sender, EventArgs e)
        {

            string ramenName = ramenNameTbx.Text;
            string meat = meatDdl.Text;
            string broth = brothTbx.Text;
            string price = priceTbx.Text;

            errorLbl.Text = ramenController.insertRamen(ramenName, meat, broth, price);

        }
    }
}