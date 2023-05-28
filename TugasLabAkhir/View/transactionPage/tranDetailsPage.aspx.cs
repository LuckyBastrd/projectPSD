using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.transactionPage
{
    public partial class tranDetailsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string headerId = Request.QueryString["headerId"];

            if (!IsPostBack)
            {
                detailGV.DataSource = detailRepository.getTransactionData(int.Parse(headerId));
                detailGV.DataBind();
            }
        }
    }
}