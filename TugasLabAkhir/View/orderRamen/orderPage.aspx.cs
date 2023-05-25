using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Model;
using TugasLabAkhir.Repository;


namespace TugasLabAkhir.View.orderRamen
{
    public partial class orderPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ramenGV.DataSource = orderRepository.getRamenItem();
                ramenGV.DataBind();

                bindCartGV();
            }
        }

        protected void ramenGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex;
            if (e.CommandName == "orderItem" && int.TryParse(e.CommandArgument.ToString(), out rowIndex))
            {
                GridViewRow row = ramenGV.Rows[rowIndex];
                string ramenName = row.Cells[0].Text;
                string meatName = row.Cells[1].Text;
                string broth = row.Cells[2].Text;
                decimal price = Convert.ToDecimal(row.Cells[3].Text);

                // Create a new cart item
                RamenItem cartItem = new RamenItem
                {
                    RamenName = ramenName,
                    MeatName = meatName,
                    Broth = broth,
                    Price = price
                };

                // Add the cart item to the session
                List<RamenItem> item = checkCartItem();
                item.Add(cartItem);
                Session["Cart"] = item;

                // Rebind the cart GridView
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
            // Clear the cart items in the session
            Session["Cart"] = new List<RamenItem>();


            // Rebind the cart GridView to reflect the empty cart
            bindCartGV();
        }

    }
}
