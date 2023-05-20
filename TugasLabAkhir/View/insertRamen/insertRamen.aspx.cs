using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;

namespace TugasLabAkhir.View.insertRamen
{
    public partial class insertRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageRamen/manageRamen.aspx");
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