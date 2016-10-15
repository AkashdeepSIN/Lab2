using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week6
{
    public partial class students_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            //connect
            var conn = new ContosoEntities();

            //use the department class to creat a new department object
            Student s = new Student();

            //fill the properties of the new department object
            s.FirstMidName = txtLastName.Text;
            s.LastName = txtFirstName.Text;
            s.EnrollmentDate = Convert.ToDateTime(txtEnrollemntDate.Text);


            //Save the new object to the database
            conn.Students.Add(s);
            conn.SaveChanges();

            //redirect to the departments page
            Response.Redirect("students.aspx");




        }
    }
}