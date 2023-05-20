using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
            Response.Redirect("~/View/updateRamen/updateRamen.aspx");
        }

        protected void ramenGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}