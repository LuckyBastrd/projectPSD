using System;
using System.Collections.Generic;
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

                  //  insertQuantity();
                    tranGV.DataSource = transactionRepository.getHeaderById(userId);

                    //insertQuantity();

                    tranGV.DataBind();
                } else if(role == "1")
                {
                   // insertQuantity();

                    tranGV.DataSource = transactionRepository.getAllHeader();


                    tranGV.DataBind();
                }
            }  
        }

        protected void insertQuantity()
        {

            if (tranGV.Rows.Count > 0)
            {
                GridViewRow row = tranGV.Rows[0];

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    int headerId = int.Parse(row.Cells[0].Text);

                    DatabaseEntities db = new DatabaseEntities();

                    List<Detail> detail = detailRepository.sumQuantity(headerId);

                    int columnCount = tranGV.Columns.Count;

                    int lastRowIndex = tranGV.Rows.Count - 1;
                    if (lastRowIndex >= 0)
                    {
                        for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
                        {
       
                            TableCell cell = tranGV.Rows[lastRowIndex].Cells[columnIndex];
                            cell.Text = detail.Sum(x => x.Quantity).ToString(); 
                        }
                    }
                }
            }
        }

    }
}