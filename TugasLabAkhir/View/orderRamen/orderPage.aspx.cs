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
            //ramenGV.Columns[0].Visible = false;
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

                int ramenId = int.Parse(row.Cells[0].Text);
                string ramenName = row.Cells[1].Text;
                string meatName = row.Cells[2].Text;
                string broth = row.Cells[3].Text;
                int price = int.Parse(row.Cells[4].Text);

                List<RamenItem> cartItems = checkCartItem();

                // Check if the selected product already exists in the cart
                RamenItem existingItem = cartItems.FirstOrDefault(item => item.RamenId == ramenId);
                if (existingItem != null)
                {
                    // If the item already exists, increment the quantity
                    existingItem.Quantity++;
                }
                else
                {
                    // If the item does not exist, create a new cart item
                    RamenItem cartItem = new RamenItem
                    {
                        RamenId = ramenId,
                        RamenName = ramenName,
                        MeatName = meatName,
                        Broth = broth,
                        Price = price,
                        Quantity = 1,
                        
                    };

                    // Add the new cart item to the cart
                    cartItems.Add(cartItem);
                }

            // Update the cart items in the session
            Session["Cart"] = cartItems;

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
