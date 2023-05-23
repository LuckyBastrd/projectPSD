using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.View.orderRamen
{
    public partial class orderPage : System.Web.UI.Page
    {
        private List<Ramen> Cart
        {
            get
            {
                if (Session["Cart"] == null)
                    Session["Cart"] = new List<Product>();

                return (List<Ramen>)Session["Cart"];
            }
            set
            {
                Session["ShoppingCart"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProductGrid();
            }
        }

        protected void ramenGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Order")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = ramenGV.Rows[rowIndex];

                Ramen ramen = new Ramen
                {
                    RamenName = row.Cells[0].Text,
                    Broth = row.Cells[1].Text,
                    MeatName = row.Cells[2].Text,
                    Price = Convert.ToDecimal(row.Cells[3].Text)
                };

                AddProductToCart(ramen);
                BindCartGrid();
            }
        }

        private void BindProductGrid()
        {
            // Replace this with your actual data source and retrieval logic
            Ramen ramen = GetRamensFromDataSource();

            ramenGV.DataSource = ramenRepository.getAllRamen();
            ramenGV.DataBind();
        }

        private void BindCartGrid()
        {
            cartGV.DataSource = Cart;
            cartGV.DataBind();
        }

        private void AddProductToCart(Product product)
        {
            // Check if the product already exists in the cart
            Product existingProduct = Cart.FirstOrDefault(p =>
                p.RamenName == product.RamenName &&
                p.Broth == product.Broth &&
                p.MeatName == product.MeatName &&
                p.Price == product.Price);

            if (existingProduct != null)
            {
                // Increment the quantity if the product already exists
                existingProduct.Quantity++;
            }
            else
            {
                // Add the product to the cart with quantity = 1
                product.Quantity = 1;
                Cart.Add(ramen);
            }
        }

        private DataTable GetRamensFromDataSource()
        {
            
            // Replace this with your actual data retrieval logic
            Raman ramenData = new Raman();
            // Retrieve the products from your data source and populate the DataTable
            // ...

            return ramenData;
        }
    }

    public class Ramen
    {
        public string RamenName { get; set; }
        public string Broth { get; set; }
        public string MeatName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
