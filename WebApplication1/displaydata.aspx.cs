using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.ServiceReference1;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteFlight f = new DeleteFlight();
            string connectionString = @"Data Source=DESKTOP-O04GNHV\SQLEXPRESS01;Initial Catalog=Airline_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete flight_id,airline,plane_no,departure_location,arrival_location,departure_date,arrival_date,seats,price where flight_id = @flight_id", con);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.gettestdata g = new ServiceReference1.gettestdata();
            string connectionString = @"Data Source=DESKTOP-O04GNHV\SQLEXPRESS01;Initial Catalog=Airline_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from flight", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
		

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("add.aspx");
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Response.Redirect("update.aspx");
        }
    }
}