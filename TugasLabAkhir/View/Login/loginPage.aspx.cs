﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;
using TugasLabAkhir.Model;

namespace TugasLabAkhir.View.Login
{
    public partial class loginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string name = nameTbx.Text;
            string password = passwordTbx.Text;

            User u = userController.login(name, password);

            if(u == null)
            {
                errorLbl.Text = "Invalid User";
            }

            

        }

        protected void registerLbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Register/registerPage.aspx");
        }
    }
}