using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.TransactionPage.Queue
{
    public partial class queue : System.Web.UI.Page
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

            Header h = new Header();

            string staffId = h.StaffId.ToString();

            if (!IsPostBack){

                (List<Transaction> transactionUnhandled, 
                List<Transaction> transactionHandled) = transactionController.getTransactionData(int.Parse(role));

                unhandledGV.DataSource = transactionUnhandled;
                unhandledGV.DataBind();

                handledGV.DataSource = transactionHandled;
                handledGV.DataBind();
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

                Response.Redirect("~/View/TransactionPage/Queue/queue.aspx");
            }
        }
    }
}