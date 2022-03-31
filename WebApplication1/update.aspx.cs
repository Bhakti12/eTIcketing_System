using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.ServiceReference1;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void Button1_Click(object sender, EventArgs e)
        {
            UpdateFlight f = new UpdateFlight();
            f.Flight_id = int.Parse(TextBox1.Text);
            f.Airline = TextBox2.Text;
            f.Plane_no = int.Parse(TextBox3.Text);
            f.Departure_location = TextBox4.Text;
            f.Arrival_location = TextBox5.Text;
            f.Departure_date = Convert.ToDateTime(TextBox6.Text);
            f.Arrival_date = Convert.ToDateTime(TextBox7.Text);
            f.Seats = int.Parse(TextBox8.Text);
            f.Price = int.Parse(TextBox9.Text);
            Response.Redirect("displaydata.aspx");
        }
    }
}