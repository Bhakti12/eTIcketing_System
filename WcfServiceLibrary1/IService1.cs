using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string register(RegisterUser u);

        [OperationContract]
        string login(LoginUser u);

        [OperationContract]
        string insert(InsertFlight flight);

        [OperationContract]
        gettestdata Getinfo();

        [OperationContract]
        string update(UpdateFlight f);

        [OperationContract]
        string delete(DeleteFlight f);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary1.ContractType".
    [DataContract]
    public class RegisterUser
    {
        string Name = string.Empty;
		string Address = string.Empty;
		string Contact = string.Empty;
		string City = string.Empty;
		string Username = string.Empty;
		string Password = string.Empty;
		
		[DataMember]
		public string name
		{
				get {return Name;}
				set {Name=value;}
		}
		[DataMember]
		public string address
		{
				get {return Address;}
				set {Address=value;}
		}
		[DataMember]
		public string contact
		{
				get {return Contact;}
				set {Contact=value;}
		}
		[DataMember]
		public string city
		{
				get {return City;}
				set {City=value;}
		}
		[DataMember]
		public string username
		{
				get {return Username;}
				set {Username=value;}
		}
		[DataMember]
		public string password
		{
				get {return Password;}
				set {Password=value;}
		}
    }
    [DataContract]
    public class LoginUser
    {
        string Username;
		string Password;
		[DataMember]
		public string username
		{
			get {return Username;}
			set {Username=value;}
		}
		[DataMember]
		public string password
		{
			get {return Password;}
			set {Password=value;}
		}
    }
    [DataContract]
    public class InsertFlight
    {
        string Airline = string.Empty;
        int Plane_no;
        string Departure_location = string.Empty;
        string Arrival_location = string.Empty;
        DateTime Departure_date;
        DateTime Arrival_date;
        int Seats;
        int Price;

        [DataMember]
        public string airline
        {
            get { return Airline; }
            set { Airline = value; }
        }

        [DataMember]
        public int plane_no
        {
            get { return Plane_no; }
            set { Plane_no = value; }
        }
        [DataMember]
        public string departure_location
        {
            get { return Departure_location; }
            set { Departure_location = value; }
        }
        [DataMember]
        public string arrival_location
        {
            get { return Arrival_location; }
            set { Arrival_location = value; }
        }
        [DataMember]
        public DateTime departure_date
        {
            get { return Departure_date; }
            set { Departure_date = value; }
        }
        [DataMember]
        public DateTime arrival_date
        {
            get { return Arrival_date;  }
            set { Arrival_date = value; }
        }
        [DataMember]
        public int seats
        {
            get { return Seats; }
            set { Seats = value; }
        }
        [DataMember]
		public int price
        {
            get { return Price; }
            set { Price = value; }
        }
    }
    [DataContract]
    public class UpdateFlight
    {
        int Flight_id;
		string Airline;
		int Plane_no;
		string Departure_location;
		string Arrival_location;
		DateTime Departure_date;
		DateTime Arrival_date;
		int Seats;
		int Price;
		[DataMember]
		public int flight_id
		{
			get{
				return Flight_id;
			}
			set{ Flight_id = value;}
		}
		[DataMember]
		public string airline
		{
			get{
				return Airline;
			}
			set{ Airline = value;}
		}
		[DataMember]
		public int plane_no
		{
			get{ return Plane_no;}
			set{ Plane_no = value;}
		}
		[DataMember]
		public string departure_location
		{
			get{
				return Departure_location;
			}
			set{ Departure_location = value;}
		}
				[DataMember]
		public string arrival_location
		{
			get{
				return Arrival_location;
			}
			set{ Arrival_location = value;}
		}
				[DataMember]
		public DateTime departure_date
		{
			get{
				return Departure_date;
			}
			set{ Departure_date = value;}
		}
				[DataMember]
		public DateTime arrival_date
		{
			get{
				return Arrival_date;
			}
			set{ Arrival_date = value;}
		}
				[DataMember]
		public int seats
		{
			get{
				return Seats;
			}
			set{ Seats = value;}
		}
				[DataMember]
		public int price
		{
			get{
				return Price;
			}
			set{ Price = value;}
		}
    }
	[DataContract]
    public class DeleteFlight
    {
        int Flight_id;
		[DataMember]
		public int flight_id
		{
			get{ return Flight_id; }
			set{ Flight_id = value; }
		}
    }
	[DataContract]
    public class gettestdata
    {
        [DataMember]
		public DataTable flight
		{
			get;
			set;
		}
    }
}
