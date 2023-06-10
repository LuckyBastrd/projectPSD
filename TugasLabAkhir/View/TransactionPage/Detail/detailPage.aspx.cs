using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Repository;

namespace TugasLabAkhir.View.TransactionPage.Detail
{
    public partial class detailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null && Request.Cookies["UserData"] == null)
            {
                Response.Redirect("~/View/MainPage/Login/loginPage.aspx");
            }

            string role = Application["roleId"].ToString();
            string headerId = Request.QueryString["headerId"];

            if(role == "2")
            {
                Response.Redirect("~/View/MainPage/Home/homePage.aspx");
            } 
            else
            {
                if (!IsPostBack)
                {
                    detailGV.DataSource = detailController.getTransactionData(int.Parse(headerId));
                    detailGV.DataBind();
                }
            }
        }
    }
}