using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.History
{
    public partial class history : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = int.Parse(Request["userId"]);
            string role = Application["roleId"].ToString();

            if (!IsPostBack)
            {
                if(role == "3")
                {
                    tranGV.DataSource = transactionRepository.getTransactionData(userId);
                    tranGV.DataBind();

                } else if(role == "1")
                {
                    tranGV.DataSource = transactionRepository.getTransactionData(int.Parse(role));
                    tranGV.DataBind();
                }
            }  
        }
    }
}