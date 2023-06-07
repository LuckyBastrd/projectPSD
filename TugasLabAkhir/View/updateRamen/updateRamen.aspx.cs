using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.updateRamen
{
    public partial class updateRamen : System.Web.UI.Page
    {
        DatabaseEntities db = new DatabaseEntities(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["UserData"] == null)
            {
                Response.Redirect("~/View/Login/loginPage.aspx");
            }

            string role = Application["roleId"].ToString();

            if (role == "3")
            {
                Response.Redirect("~/View/Home/homePage.aspx");
            }

            //int ramenId = Convert.ToInt32(Request.QueryString["ramenId"]);
            //label.Text = ramenId.ToString();
            int ramenId = int.Parse(Request["ramenId"]);

            ramenGV.DataSource = ramenRepository.getRamenById(ramenId);
            ramenGV.DataBind();
        }

        protected void returnBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageRamen/manageRamen.aspx");
        }

        protected void updateRamenBtn_Click(object sender, EventArgs e)
        {
            string id = Request["ramenId"];

            string ramenName = updRamenNameTbx.Text;
            string meat = updMeatDdl.Text;
            string broth = updBrothTbx.Text;
            string price = updPriceTbx.Text;

            statusLbl.Text = ramenController.updateRamen(id, ramenName, meat, broth, price);

            Response.Redirect("~/View/ManageRamen/manageRamen.aspx");
        }
    }
}