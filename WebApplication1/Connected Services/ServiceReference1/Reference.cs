﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegisterUser", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class RegisterUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contact {
            get {
                return this.ContactField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactField, value) != true)) {
                    this.ContactField = value;
                    this.RaisePropertyChanged("Contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginUser", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class LoginUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InsertFlight", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class InsertFlight : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AirlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Arrival_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Arrival_locationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Departure_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Departure_locationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Plane_noField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SeatsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Airline {
            get {
                return this.AirlineField;
            }
            set {
                if ((object.ReferenceEquals(this.AirlineField, value) != true)) {
                    this.AirlineField = value;
                    this.RaisePropertyChanged("Airline");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Arrival_date {
            get {
                return this.Arrival_dateField;
            }
            set {
                if ((this.Arrival_dateField.Equals(value) != true)) {
                    this.Arrival_dateField = value;
                    this.RaisePropertyChanged("Arrival_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Arrival_location {
            get {
                return this.Arrival_locationField;
            }
            set {
                if ((object.ReferenceEquals(this.Arrival_locationField, value) != true)) {
                    this.Arrival_locationField = value;
                    this.RaisePropertyChanged("Arrival_location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Departure_date {
            get {
                return this.Departure_dateField;
            }
            set {
                if ((this.Departure_dateField.Equals(value) != true)) {
                    this.Departure_dateField = value;
                    this.RaisePropertyChanged("Departure_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Departure_location {
            get {
                return this.Departure_locationField;
            }
            set {
                if ((object.ReferenceEquals(this.Departure_locationField, value) != true)) {
                    this.Departure_locationField = value;
                    this.RaisePropertyChanged("Departure_location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Plane_no {
            get {
                return this.Plane_noField;
            }
            set {
                if ((this.Plane_noField.Equals(value) != true)) {
                    this.Plane_noField = value;
                    this.RaisePropertyChanged("Plane_no");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Seats {
            get {
                return this.SeatsField;
            }
            set {
                if ((this.SeatsField.Equals(value) != true)) {
                    this.SeatsField = value;
                    this.RaisePropertyChanged("Seats");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="gettestdata", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class gettestdata : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.DataTable flightField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.DataTable flight {
            get {
                return this.flightField;
            }
            set {
                if ((object.ReferenceEquals(this.flightField, value) != true)) {
                    this.flightField = value;
                    this.RaisePropertyChanged("flight");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateFlight", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class UpdateFlight : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AirlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Arrival_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Arrival_locationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Departure_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Departure_locationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Flight_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Plane_noField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SeatsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Airline {
            get {
                return this.AirlineField;
            }
            set {
                if ((object.ReferenceEquals(this.AirlineField, value) != true)) {
                    this.AirlineField = value;
                    this.RaisePropertyChanged("Airline");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Arrival_date {
            get {
                return this.Arrival_dateField;
            }
            set {
                if ((this.Arrival_dateField.Equals(value) != true)) {
                    this.Arrival_dateField = value;
                    this.RaisePropertyChanged("Arrival_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Arrival_location {
            get {
                return this.Arrival_locationField;
            }
            set {
                if ((object.ReferenceEquals(this.Arrival_locationField, value) != true)) {
                    this.Arrival_locationField = value;
                    this.RaisePropertyChanged("Arrival_location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Departure_date {
            get {
                return this.Departure_dateField;
            }
            set {
                if ((this.Departure_dateField.Equals(value) != true)) {
                    this.Departure_dateField = value;
                    this.RaisePropertyChanged("Departure_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Departure_location {
            get {
                return this.Departure_locationField;
            }
            set {
                if ((object.ReferenceEquals(this.Departure_locationField, value) != true)) {
                    this.Departure_locationField = value;
                    this.RaisePropertyChanged("Departure_location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Flight_id {
            get {
                return this.Flight_idField;
            }
            set {
                if ((this.Flight_idField.Equals(value) != true)) {
                    this.Flight_idField = value;
                    this.RaisePropertyChanged("Flight_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Plane_no {
            get {
                return this.Plane_noField;
            }
            set {
                if ((this.Plane_noField.Equals(value) != true)) {
                    this.Plane_noField = value;
                    this.RaisePropertyChanged("Plane_no");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Seats {
            get {
                return this.SeatsField;
            }
            set {
                if ((this.SeatsField.Equals(value) != true)) {
                    this.SeatsField = value;
                    this.RaisePropertyChanged("Seats");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DeleteFlight", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class DeleteFlight : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Flight_idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Flight_id {
            get {
                return this.Flight_idField;
            }
            set {
                if ((this.Flight_idField.Equals(value) != true)) {
                    this.Flight_idField = value;
                    this.RaisePropertyChanged("Flight_id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/register", ReplyAction="http://tempuri.org/IService1/registerResponse")]
        string register(WebApplication1.ServiceReference1.RegisterUser u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/register", ReplyAction="http://tempuri.org/IService1/registerResponse")]
        System.Threading.Tasks.Task<string> registerAsync(WebApplication1.ServiceReference1.RegisterUser u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        string login(WebApplication1.ServiceReference1.LoginUser u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        System.Threading.Tasks.Task<string> loginAsync(WebApplication1.ServiceReference1.LoginUser u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insert", ReplyAction="http://tempuri.org/IService1/insertResponse")]
        string insert(WebApplication1.ServiceReference1.InsertFlight flight);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insert", ReplyAction="http://tempuri.org/IService1/insertResponse")]
        System.Threading.Tasks.Task<string> insertAsync(WebApplication1.ServiceReference1.InsertFlight flight);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Getinfo", ReplyAction="http://tempuri.org/IService1/GetinfoResponse")]
        WebApplication1.ServiceReference1.gettestdata Getinfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Getinfo", ReplyAction="http://tempuri.org/IService1/GetinfoResponse")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.gettestdata> GetinfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/update", ReplyAction="http://tempuri.org/IService1/updateResponse")]
        string update(WebApplication1.ServiceReference1.UpdateFlight f);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/update", ReplyAction="http://tempuri.org/IService1/updateResponse")]
        System.Threading.Tasks.Task<string> updateAsync(WebApplication1.ServiceReference1.UpdateFlight f);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/delete", ReplyAction="http://tempuri.org/IService1/deleteResponse")]
        string delete(WebApplication1.ServiceReference1.DeleteFlight f);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/delete", ReplyAction="http://tempuri.org/IService1/deleteResponse")]
        System.Threading.Tasks.Task<string> deleteAsync(WebApplication1.ServiceReference1.DeleteFlight f);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1.IService1>, WebApplication1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string register(WebApplication1.ServiceReference1.RegisterUser u) {
            return base.Channel.register(u);
        }
        
        public System.Threading.Tasks.Task<string> registerAsync(WebApplication1.ServiceReference1.RegisterUser u) {
            return base.Channel.registerAsync(u);
        }
        
        public string login(WebApplication1.ServiceReference1.LoginUser u) {
            return base.Channel.login(u);
        }
        
        public System.Threading.Tasks.Task<string> loginAsync(WebApplication1.ServiceReference1.LoginUser u) {
            return base.Channel.loginAsync(u);
        }
        
        public string insert(WebApplication1.ServiceReference1.InsertFlight flight) {
            return base.Channel.insert(flight);
        }
        
        public System.Threading.Tasks.Task<string> insertAsync(WebApplication1.ServiceReference1.InsertFlight flight) {
            return base.Channel.insertAsync(flight);
        }
        
        public WebApplication1.ServiceReference1.gettestdata Getinfo() {
            return base.Channel.Getinfo();
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.gettestdata> GetinfoAsync() {
            return base.Channel.GetinfoAsync();
        }
        
        public string update(WebApplication1.ServiceReference1.UpdateFlight f) {
            return base.Channel.update(f);
        }
        
        public System.Threading.Tasks.Task<string> updateAsync(WebApplication1.ServiceReference1.UpdateFlight f) {
            return base.Channel.updateAsync(f);
        }
        
        public string delete(WebApplication1.ServiceReference1.DeleteFlight f) {
            return base.Channel.delete(f);
        }
        
        public System.Threading.Tasks.Task<string> deleteAsync(WebApplication1.ServiceReference1.DeleteFlight f) {
            return base.Channel.deleteAsync(f);
        }
    }
}
