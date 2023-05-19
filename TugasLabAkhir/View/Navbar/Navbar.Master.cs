using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.View.Navbar
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        DatabaseEntities4 db = new DatabaseEntities4();
        protected void Page_Load(object sender, EventArgs e)
        {
            string role = Application["Role"].ToString();

            roleName.Text = role;
        }
    }
}