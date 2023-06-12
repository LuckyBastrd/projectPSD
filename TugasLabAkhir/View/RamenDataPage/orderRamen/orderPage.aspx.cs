using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;


namespace TugasLabAkhir.View.RamenDataPage.orderRamen
{
    public partial class orderPage : System.Web.UI.Page
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
                if (!IsPostBack)
                {
                    ramenGV.DataSource = orderController.getRamenItem();
                    ramenGV.DataBind();

                    bindCartGV();
                }
            } else
            {
                Response.Redirect("~/View/MainPage/Home/homePage.aspx");
            }
        }

        protected void ramenGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex;
            if (e.CommandName == "orderItem" && int.TryParse(e.CommandArgument.ToString(), out rowIndex))
            {
                GridViewRow row = ramenGV.Rows[rowIndex];

                int ramenId = int.Parse(row.Cells[0].Text);
                string ramenName = row.Cells[1].Text;
                string meatName = row.Cells[2].Text;
                string broth = row.Cells[3].Text;
                int price = int.Parse(row.Cells[4].Text);

                List<RamenItem> cartItems = checkCartItem();

                RamenItem existingItem = cartItems.FirstOrDefault(item => item.RamenId == ramenId);
                if (existingItem != null)
                {
                    existingItem.Quantity++;
                }
                else
                {
                    RamenItem cartItem = new RamenItem
                    {
                        RamenId = ramenId,
                        RamenName = ramenName,
                        MeatName = meatName,
                        Broth = broth,
                        Price = price,
                        Quantity = 1,
                    };

                    cartItems.Add(cartItem);
                }

            Session["Cart"] = cartItems;

            bindCartGV();
            }
        }

        protected List<RamenItem> checkCartItem()
        {
            if (Session["Cart"] == null)
            {
                Session["Cart"] = new List<RamenItem>();
            }
                
            return (List<RamenItem>)Session["Cart"];
        }

        protected void bindCartGV()
        {
            List<RamenItem> cartItem = checkCartItem();

            cartGV.DataSource = cartItem;
            cartGV.DataBind();
        }

        protected void clearBtn_Click(object sender, EventArgs e)
        {
            Session["Cart"] = new List<RamenItem>();

            bindCartGV();
        }

        protected void btnBuyCart_Click(object sender, EventArgs e)
        {
            string userId = Application["userId"].ToString();
            string date = DateTime.Now.ToString();

            transactionController.inserTransaction(userId, date);

            int headerId = transactionRepository.getNewesttHeaderId();

            List<RamenItem> cartItems = checkCartItem();

            foreach (GridViewRow row in cartGV.Rows)
            {
                int ramenId = int.Parse(row.Cells[0].Text);
                int quantity = int.Parse(row.Cells[5].Text);

                detailController.insertDetail(headerId, ramenId, quantity);
            }

            Session["Cart"] = new List<RamenItem>();

            bindCartGV();
        }
    }
}
