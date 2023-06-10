using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.TransactionPage.History
{
    public partial class history : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User"] == null && Request.Cookies["UserData"] == null)
            {
                Response.Redirect("~/View/MainPage/Login/loginPage.aspx");
            }

            int userId = int.Parse(Request["userId"]);
            string role = Application["roleId"].ToString();

            if(role == "2")
            {
                Response.Redirect("~/View/MainPage/Home/homePage.aspx");
            } 

            if (!IsPostBack)
            {
                if (role == "3")
                {
                    (List<Transaction> transactionUnhandled,
                    List<Transaction> transactionHandled) = transactionController.getTransactionData(userId);

                    List<Transaction> mergeList = new List<Transaction>();
                    mergeList.AddRange(transactionHandled);
                    mergeList.AddRange(transactionUnhandled);

                    tranGV.DataSource = mergeList;
                    tranGV.DataBind();

                }
                else if (role == "1")
                {
                    (List<Transaction> transactionUnhandled,
                    List<Transaction> transactionHandled) = transactionController.getTransactionData(int.Parse(role));

                    List<Transaction> mergeList = new List<Transaction>();
                    mergeList.AddRange(transactionHandled);
                    mergeList.AddRange(transactionUnhandled);

                    tranGV.DataSource = mergeList;
                    tranGV.DataBind();
                }
            }
            
        }

        protected void tranGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex;
            if (e.CommandName == "tranDetail" && int.TryParse(e.CommandArgument.ToString(), out rowIndex))
            {
                GridViewRow row = tranGV.Rows[rowIndex];

                int headerId = int.Parse(row.Cells[0].Text);

                string URL = $"~/View/TransactionPage/Detail/detailPage.aspx?headerId={headerId}";

                Response.Redirect(URL);
            }
        }
    }
}