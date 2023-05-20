using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.ManageRamen
{
    public partial class manageRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ramenGV.DataSource = ramenRepository.getAllRamen();
            ramenGV.DataBind();
        }

        protected void insertRamenBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/insertRamen/insertRamen.aspx");
        }

        protected void ramenGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = ramenGV.Rows[e.NewEditIndex];
            string ramenId = row.Cells[0].Text.ToString();

            Response.Redirect("~/View/updateRamen/updateRamen.aspx?ramenId=" + ramenId);
        }

        protected void ramenGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = ramenGV.Rows[e.RowIndex];
            string ramenId = row.Cells[0].Text.ToString();

            ramenController.deleteRamen(ramenId);

            Response.Redirect("~/View/ManageRamen/manageRamen.aspx");
        }
    }
}