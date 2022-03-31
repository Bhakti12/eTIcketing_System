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
			SqlCommand cmd = new SqlCommand("Insert into users(Name,Address,Contact,City,Username,Password) value(@Name,@Address,@Contact,@City,@Username,@Password)", con);
			cmd.Parameters.AddWithValue("@Name", u.Name);
			cmd.Parameters.AddWithValue("@Address", u.Address);
			cmd.Parameters.AddWithValue("@Contact", u.Contact);
			cmd.Parameters.AddWithValue("@City", u.City);
			cmd.Parameters.AddWithValue("@Username", u.Username);
			cmd.Parameters.AddWithValue("@Password", u.Password);
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
				SqlCommand cmd = new SqlCommand("Insert into Flight(Airline,Plane_no,Departure_location,Arrival_location,Departure_date,Arrival_date,Seats,Price) values(@Airline,@Plane_no,@Departure_location,@Arrival_location,@Departure_date,@Arrival_date,@Seats,@Price)", con);
				cmd.Parameters.AddWithValue("@Airline", flight.Airline);
				cmd.Parameters.AddWithValue("@Plane_no", flight.Plane_no);
				cmd.Parameters.AddWithValue("@Departure_location", flight.Departure_location);
				cmd.Parameters.AddWithValue("@Arrival_location", flight.Arrival_location);
				cmd.Parameters.AddWithValue("@Departure_date", flight.Departure_date);
                cmd.Parameters.AddWithValue("@Arrival_date", flight.Arrival_date);
                cmd.Parameters.AddWithValue("@Seats", flight.Seats);
				cmd.Parameters.AddWithValue("@Price", flight.Price);
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
				SqlCommand cmd = new SqlCommand("update flight set Airline=@airline, Plane_no=@plane_no, Departure_location=@departure_location, Arrival_location=@arrival_location, Departure_Date=@departure_date, Arrival_date=@arrival_date, Seats=@seats, Price=@price where Flight_id=@flight_id", con);
				cmd.Parameters.AddWithValue("@flight_id",f.Flight_id);
				cmd.Parameters.AddWithValue("@airline",f.Airline);
				cmd.Parameters.AddWithValue("@plane_no",f.Plane_no);
				cmd.Parameters.AddWithValue("@departure_location",f.Departure_location);
				cmd.Parameters.AddWithValue("@arrival_location",f.Arrival_location);
				cmd.Parameters.AddWithValue("@departure_date",f.Departure_date);
				cmd.Parameters.AddWithValue("@arrival_date",f.Arrival_date);
				cmd.Parameters.AddWithValue("@seats",f.Seats);
				cmd.Parameters.AddWithValue("@price",f.Price);
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
			SqlCommand cmd = new SqlCommand("delete flight where Flight_id = @flight_id", con);
			cmd.Parameters.AddWithValue("@flight_id",f.Flight_id);
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
