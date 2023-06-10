using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.RamenDataPage.ManageRamen
{
    public partial class manageRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["UserData"] == null)
            {
                Response.Redirect("~/View/MainPage/Login/loginPage.aspx");
            }

            string role = Application["roleId"].ToString();

            if(role == "3")
            {
                Response.Redirect("~/View/MainPage/Home/homePage.aspx");
            }

            ramenGV.DataSource = ramenController.getAllRamen();
            ramenGV.DataBind();
        }

        protected void insertRamenBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RamenDataPage/insertRamen/insertRamen.aspx");
        }

        protected void ramenGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = ramenGV.Rows[e.NewEditIndex];
            string ramenId = row.Cells[0].Text.ToString();

            Response.Redirect("~/View/RamenDataPage/updateRamen/updateRamen.aspx?ramenId=" + ramenId);
        }

        protected void ramenGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = ramenGV.Rows[e.RowIndex];
            string ramenId = row.Cells[0].Text.ToString();

            ramenController.deleteRamen(ramenId);

            Response.Redirect("~/View/RamenDataPage/ManageRamen/manageRamen.aspx");
        }
    }
}