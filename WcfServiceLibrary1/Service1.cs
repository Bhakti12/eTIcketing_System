using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
		public string register(RegisterUser u)
		{
			string msg;
            string connectionString = @"Data Source=DESKTOP-O04GNHV\SQLEXPRESS01;Initial Catalog=Airline_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
			SqlCommand cmd = new SqlCommand("Insert into users(name,address,contact,city,username,password) value(@name,@address,@contact,@city,@username,@password)", con);
			cmd.Parameters.AddWithValue("@name", u.name);
			cmd.Parameters.AddWithValue("@address", u.address);
			cmd.Parameters.AddWithValue("@contact", u.contact);
			cmd.Parameters.AddWithValue("@city", u.city);
			cmd.Parameters.AddWithValue("@username", u.username);
			cmd.Parameters.AddWithValue("@password", u.password);
			int g = cmd.ExecuteNonQuery();
			if(g==1)
			{
				msg = "successfully registered";
			}
			else{
				    msg = "sorry!!!";
				}
			return msg;
		}
		public string login(LoginUser u)
		{
			string msg;
            string connectionString = @"Data Source=DESKTOP-O04GNHV\SQLEXPRESS01;Initial Catalog=Airline_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
			SqlCommand cmd = new SqlCommand("select * from users where username = @username and password = @password", con);
			cmd.CommandType = CommandType.Text;
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                  return sdr["id"].ToString();
            }
            else
            {
                  return "false";
            } 
            sdr.Close();
		}
        public string insert(InsertFlight flight)
        {
				string msg;
            string connectionString = @"Data Source=DESKTOP-O04GNHV\SQLEXPRESS01;Initial Catalog=Airline_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
				SqlCommand cmd = new SqlCommand("Insert into Flight(airline,plane_no,departure_location,arrival_location,departure_date,arrival_date,seats,price) values(@airline,@plane_no,@departure_location,@arrival_location,@departure_date,@arrival_date,@seats,@price)", con);
				cmd.Parameters.AddWithValue("@airline", flight.airline);
				cmd.Parameters.AddWithValue("@plane_no", flight.plane_no);
				cmd.Parameters.AddWithValue("@departure_location", flight.departure_location);
				cmd.Parameters.AddWithValue("@arrival_location", flight.arrival_location);
				cmd.Parameters.AddWithValue("@departure_date", flight.departure_date);
                cmd.Parameters.AddWithValue("@arrival_date", flight.arrival_date);
                cmd.Parameters.AddWithValue("@seats", flight.seats);
				cmd.Parameters.AddWithValue("@price", flight.price);
                int g = cmd.ExecuteNonQuery();
				if(g==1)
				{
					msg = "successfully inserted";
				}
				else{
					msg = "failed to insert";
				}
				return msg;
        }
		public gettestdata Getinfo()
		{
			gettestdata g = new gettestdata();
            string connectionString = @"Data Source=DESKTOP-O04GNHV\SQLEXPRESS01;Initial Catalog=Airline_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
			SqlCommand cmd = new SqlCommand("select * from flight", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			g.flight = dt;
			return g;
		}
		public string update(UpdateFlight f)
		{
				string msg = "";
            string connectionString = @"Data Source=DESKTOP-O04GNHV\SQLEXPRESS01;Initial Catalog=Airline_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            
                con.Open();
				SqlCommand cmd = new SqlCommand("update flight set airline=@airline, plane_no=@plane_no, departure_location=@departure_location, arrival_location=@arrival_location, departure_Date=@departure_date, arrival_date=@arrival_date, seats=@seats, price=@price where Flight_id=@flight_id", con);
				cmd.Parameters.AddWithValue("@flight_id",f.flight_id);
				cmd.Parameters.AddWithValue("@airline",f.airline);
				cmd.Parameters.AddWithValue("@plane_no",f.plane_no);
				cmd.Parameters.AddWithValue("@departure_location",f.departure_location);
				cmd.Parameters.AddWithValue("@arrival_location",f.arrival_location);
				cmd.Parameters.AddWithValue("@departure_date",f.departure_date);
				cmd.Parameters.AddWithValue("@arrival_date",f.arrival_date);
				cmd.Parameters.AddWithValue("@seats",f.seats);
				cmd.Parameters.AddWithValue("@price",f.price);
				int res = cmd.ExecuteNonQuery();
				if(res == 1)
				{
					msg = "successfully updated";
				}
				else{
					msg = "failed to update";
				}
				return msg;
		}
		public string delete(DeleteFlight f)
		{
			string msg="";
            string connectionString = @"Data Source=DESKTOP-O04GNHV\SQLEXPRESS01;Initial Catalog=Airline_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            
            con.Open();
			SqlCommand cmd = new SqlCommand("delete flight where flight_id = @flight_id", con);
			cmd.Parameters.AddWithValue("@flight_id",f.flight_id);
			int res = cmd.ExecuteNonQuery();
			if(res == 1)
			{
				msg = "Deleted successfully";
			}
			else
			{
				msg = "failed to delete";
			}
			return msg;
		}
    }
}
