﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using car_sharing_system.Models;

namespace car_sharing_system.Admin_Theme.pages
{
    public partial class profile : System.Web.UI.Page
    {
        protected User newUser;

        protected void Page_Load(object sender, EventArgs e)
        {

             newUser = DatabaseReader.userQuerySingle("accountID = '" + User.Identity.Name + "';");
			

            if (IsPostBack)
            {
                updateform.Visible = false;
                Label1.Text = firstname.Text;
                Label1.Style.Add("font-weight", "bold");


            }
            TimeLabel.Text = DateTime.Now.ToString();


        }
    }
}