using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Dataset;
using TugasLabAkhir.Report;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.Report
{
    public partial class reportPage : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CrystalReport report = new CrystalReport();
                
                List<TransactionDetail> detail = detailRepository.getAllTransactionData();

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
                row["Sub Total Price"] = td.subTotal;
                row["Total Price"] = td.totalPrice;
                row["Grand Price"] = td.grandPrice;

                detailTable.Rows.Add(row);
            }

            return data;
        }

    }
}