﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasLabAkhir.Controller;

namespace TugasLabAkhir.View.Profile
{
    public partial class profilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
           
            string name = updNameTbx.Text;
            string email = updEmailTbx.Text;
            string gender = updGenderRdb.Text;
            string password = passTbx.Text;
            string confirm = Application["Confirm"].ToString();

            errLbl.Text = userController.updateUser(name, email, gender, password, confirm);
        }
    }
}