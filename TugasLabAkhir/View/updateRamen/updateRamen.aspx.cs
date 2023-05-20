using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.updateRamen
{
    public partial class updateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ramenGV.DataSource = ramenRepository.getAllRamen();
            ramenGV.DataBind();
        }

        protected void returnBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageRamen/manageRamen.aspx");
        }

        protected void updateRamenBtn_Click(object sender, EventArgs e)
        {
            string ramenName = updRamenNameTbx.Text;
            string meat = updMeatDdl.Text;
            string broth = updBrothTbx.Text;
            string price = updPriceTbx.Text;


        }
    }
}