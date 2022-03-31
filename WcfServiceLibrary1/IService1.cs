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
        string name = string.Empty;
		string address = string.Empty;
		string contact = string.Empty;
		string city = string.Empty;
		string username = string.Empty;
		string password = string.Empty;
		
		[DataMember]
		public string Name
		{
				get {return name;}
				set {name=value;}
		}
		[DataMember]
		public string Address
		{
				get {return address;}
				set {address=value;}
		}
		[DataMember]
		public string Contact
		{
				get {return contact;}
				set {contact=value;}
		}
		[DataMember]
		public string City
		{
				get {return city;}
				set {city=value;}
		}
		[DataMember]
		public string Username
		{
				get {return username;}
				set {username=value;}
		}
		[DataMember]
		public string Password
		{
				get {return password;}
				set {password=value;}
		}
    }
    [DataContract]
    public class LoginUser
    {
        string username;
		string password;
		[DataMember]
		public string Username
		{
			get {return username;}
			set {username=value;}
		}
		[DataMember]
		public string Password
		{
			get {return password;}
			set {password=value;}
		}
    }
    [DataContract]
    public class InsertFlight
    {
        string airline = string.Empty;
        int plane_no;
        string departure_location = string.Empty;
        string arrival_location = string.Empty;
        DateTime departure_date;
        DateTime arrival_date;
        int seats;
        int price;

        [DataMember]
        public string Airline
        {
            get { return airline; }
            set { airline = value; }
        }

        [DataMember]
        public int Plane_no
        {
            get { return plane_no; }
            set { plane_no = value; }
        }
        [DataMember]
        public string Departure_location
        {
            get { return departure_location; }
            set { departure_location = value; }
        }
        [DataMember]
        public string Arrival_location
        {
            get { return arrival_location; }
            set { arrival_location = value; }
        }
        [DataMember]
        public DateTime Departure_date
        {
            get { return departure_date; }
            set { departure_date = value; }
        }
        [DataMember]
        public DateTime Arrival_date
        {
            get { return arrival_date;  }
            set { arrival_date = value; }
        }
        [DataMember]
        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }
        [DataMember]
		public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
    [DataContract]
    public class UpdateFlight
    {
        int flight_id;
		string airline;
		int plane_no;
		string departure_location;
		string arrival_location;
		DateTime departure_date;
		DateTime arrival_date;
		int seats;
		int price;
		[DataMember]
		public int Flight_id
		{
			get{
				return flight_id;
			}
			set{ flight_id = value;}
		}
		[DataMember]
		public string Airline
		{
			get{
				return airline;
			}
			set{ airline = value;}
		}
		[DataMember]
		public int Plane_no
		{
			get{ return plane_no;}
			set{ plane_no = value;}
		}
		[DataMember]
		public string Departure_location
		{
			get{
				return departure_location;
			}
			set{ departure_location = value;}
		}
				[DataMember]
		public string Arrival_location
		{
			get{
				return arrival_location;
			}
			set{ arrival_location = value;}
		}
				[DataMember]
		public DateTime Departure_date
		{
			get{
				return departure_date;
			}
			set{ departure_date = value;}
		}
				[DataMember]
		public DateTime Arrival_date
		{
			get{
				return arrival_date;
			}
			set{ arrival_date = value;}
		}
				[DataMember]
		public int Seats
		{
			get{
				return seats;
			}
			set{ seats = value;}
		}
				[DataMember]
		public int Price
		{
			get{
				return price;
			}
			set{ price = value;}
		}
    }
	[DataContract]
    public class DeleteFlight
    {
        int flight_id;
		[DataMember]
		public int Flight_id
		{
			get{ return flight_id; }
			set{ flight_id = value; }
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
