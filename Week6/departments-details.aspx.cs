﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week6
{
    public partial class departments_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
protected void btnSave_Click(object sender, EventArgs e)
        {
            //connect
            var conn = new ContosoEntities();

            //use the department class to creat a new department object
            Department d = new Department();

            //fill the properties of the new department object
            d.Name = txtName.Text;
            d.Budget = Convert.ToDecimal(txtBudget.Text);

            //Save the new object to the database
            conn.Departments.Add(d);
            conn.SaveChanges();

            //redirect to the departments page
            Response.Redirect("departments.aspx");

        }
    }
}