using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public class Student
        {
            public int id { get; set; }
            public string name { get; set; }
            public int rollno { get; set; }
        }

        static List<Student> students = new List<Student>
        {
            new Student{ id=1,name="yash",rollno = 63},
            new Student{ id=2,name="prasad",rollno = 30}
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridBind("All");
            }
        }

        protected void linq_func(object sender, EventArgs e)
        {
            string selected_name = DropDownList1.SelectedValue;
            GridBind(selected_name);
        }

        private void GridBind(String name)
        {
            var result = from Student in students
                         where name == "All" || name == Student.name
                         orderby Student.name
                         select Student;

            GridView1.DataSource = result.ToList();
            GridView1.DataBind();

        }
    }
}