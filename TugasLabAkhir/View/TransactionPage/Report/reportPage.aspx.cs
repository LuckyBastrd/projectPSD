using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Dataset;
using TugasLabAkhir.Report;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.TransactionPage.Report
{
    public partial class reportPage : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {

            if (Session["User"] == null && Request.Cookies["UserData"] == null)
            {
                Response.Redirect("~/View/MainPage/Login/loginPage.aspx");
            }

            string role = Application["roleId"].ToString();

            if(role == "2" || role == "3")
            {
                Response.Redirect("~/View/MainPage/Home/homePage.aspx");
            }

            if (!IsPostBack)
            {
                CrystalReport report = new CrystalReport();
                
                List<TransactionDetail> detail = detailController.getTransactionData();

                DataSet data = getAllData(detail);

                report.SetDataSource(data);

                CrystalReportViewer.ReportSource = report;

                Session["ReportData"] = report;
            }

            else
            {
                CrystalReport report = (CrystalReport)Session["ReportData"];

                CrystalReportViewer.ReportSource = report;
            }
        }

        private DataSet getAllData(List<TransactionDetail> details)
        {
            DataSet data = new DataSet();

            var detailTable = data.TransactionDetails;

            foreach (TransactionDetail td in details)
            {
                var row = detailTable.NewRow();

                row["Transaction Id"] = td.HeaderId;
                row["Transaction Date"] = td.Date;
                row["Customer Name"] = td.userName;
                row["Staff Id"] = td.staffId;
                row["Staff Name"] = td.staffName;
                row["Ramen Name"] = td.ramenName;
                row["Ramen Broth"] = td.Broth;
                row["Total Ramen"] = td.Quantity;
                row["Sub Total Price"] = td.subTotalPrice;

                detailTable.Rows.Add(row);
            }

            return data;
        }

    }
}