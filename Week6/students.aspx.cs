using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//add two refrences to access the database
using System.Web.ModelBinding;

namespace Week6
{
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // get the students and display in the gridview
            getStudents();
        }

        protected void getStudents()
        {
            //connect to db
            var conn = new ContosoEntities();

            //run the query using LINQ
            var Students = from d in conn.Students
                           select d;

            //Display query result in gridview

            grdStudents.DataSource = Students.ToList();
            grdStudents.DataBind();
        }

        protected void grdStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}