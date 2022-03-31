using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.ServiceReference1;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void Button1_Click1(object sender, EventArgs e)
        {
            RegisterUser u = new RegisterUser();
            u.Name = TextBox1.Text;
            u.Address = TextBox2.Text;
            u.Contact = TextBox3.Text;
            u.City = TextBox4.Text;
            u.Username = TextBox5.Text;
            u.Password = TextBox6.Text;
            Response.Redirect("login.aspx");
        }
    }
}