using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataBoundControls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
                BindDropDown();
            }
        }

        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        private void BindDropDown()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT StudentID, Name FROM Students", con);
                con.Open();
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "StudentID";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new System.Web.UI.WebControls.ListItem("-- Select --", "0"));
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(DropDownList1.SelectedValue);
            if (id != 0)
            {
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students WHERE StudentID = @ID", con);
                    da.SelectCommand.Parameters.AddWithValue("@ID", id);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DetailsView1.DataSource = dt;
                    DetailsView1.DataBind();
                }
            }
        }
    }
}