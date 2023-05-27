using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.History
{
    public partial class history : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = int.Parse(Request["userId"]);

            if (!IsPostBack)
            {
                tranGV.DataSource = transactionRepository.getAllHeader(userId);
                tranGV.DataBind();
            }
            
        }
    }
}