using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.Queue
{
    public partial class queue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string role = Application["roleId"].ToString();

            Header h = new Header();

            string staffId = h.StaffId.ToString();

            if (!IsPostBack){

                if(staffId == null)
                {
                    unhandledGV.DataSource = transactionRepository.getTransactionByStatus(int.Parse(role), int.Parse(staffId));
                    unhandledGV.DataBind();
                }
                else
                {
                    handledGV.DataSource = transactionRepository.getTransactionByStatus(int.Parse(role), int.Parse(staffId));
                    handledGV.DataBind();
                }
            }
        }

        protected void unhandledGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex;
            if (e.CommandName == "handleItem" && int.TryParse(e.CommandArgument.ToString(), out rowIndex))
            {
                GridViewRow row = unhandledGV.Rows[rowIndex];
                int headerId = int.Parse(row.Cells[0].Text);

                int userId = int.Parse(Application["userId"].ToString());

                transactionController.updateStaff(headerId, userId);

                Response.Redirect("~/View/Queue/queue.aspx");
            }
        }
    }
}