using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.ServiceReference1;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertFlight f = new InsertFlight();
            f.Airline = TextBox1.Text;
            f.Plane_no = int.Parse(TextBox2.Text);
            f.Departure_location = TextBox3.Text;
            f.Arrival_location = TextBox4.Text;
            f.Departure_date = Convert.ToDateTime(TextBox5.Text);
            f.Arrival_date = Convert.ToDateTime(TextBox6.Text);
            f.Seats = int.Parse(TextBox7.Text);
            f.Price = int.Parse(TextBox8.Text);
            string result = client.insert(f);
            lblmsg.Text = result.ToString();
        }
    }
}