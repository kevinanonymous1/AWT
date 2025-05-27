using System;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;

namespace Practical_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private readonly string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chalk\source\repos\Practical_4\Practical_4\App_Data\Database1.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadData();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("Insert into yash values (@Firstname,@Lastname)",con))
                {
                    cmd.Parameters.AddWithValue("@Firstname", firstname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Lastname", Lastname.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();

                    firstname.Text = "";
                    Lastname.Text = "";
                    LoadData();



                }
            }

        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                using ( SqlDataAdapter da = new SqlDataAdapter("Select Firstname,Lastname from yash",con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }

       

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No action needed here unless you want to handle selection
        }
    }
}
