﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeltaClient.Booking {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaDBManager.CarNS")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BurnedLitersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KilometersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MakeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlateNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        public int BurnedLiters {
            get {
                return this.BurnedLitersField;
            }
            set {
                if ((this.BurnedLitersField.Equals(value) != true)) {
                    this.BurnedLitersField = value;
                    this.RaisePropertyChanged("BurnedLiters");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Kilometers {
            get {
                return this.KilometersField;
            }
            set {
                if ((this.KilometersField.Equals(value) != true)) {
                    this.KilometersField = value;
                    this.RaisePropertyChanged("Kilometers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Make {
            get {
                return this.MakeField;
            }
            set {
                if ((object.ReferenceEquals(this.MakeField, value) != true)) {
                    this.MakeField = value;
                    this.RaisePropertyChanged("Make");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlateNumber {
            get {
                return this.PlateNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PlateNumberField, value) != true)) {
                    this.PlateNumberField = value;
                    this.RaisePropertyChanged("PlateNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaManager.Utils")]
    [System.SerializableAttribute()]
    public partial class ManagerFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Booking", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaDBManager.BookingNS")]
    [System.SerializableAttribute()]
    public partial class Booking : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DeltaClient.Booking.Car BookedCarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DeltaClient.Booking.User BookerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ReturnedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartField;
        
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
        public DeltaClient.Booking.Car BookedCar {
            get {
                return this.BookedCarField;
            }
            set {
                if ((object.ReferenceEquals(this.BookedCarField, value) != true)) {
                    this.BookedCarField = value;
                    this.RaisePropertyChanged("BookedCar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DeltaClient.Booking.User Booker {
            get {
                return this.BookerField;
            }
            set {
                if ((object.ReferenceEquals(this.BookerField, value) != true)) {
                    this.BookerField = value;
                    this.RaisePropertyChanged("Booker");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime End {
            get {
                return this.EndField;
            }
            set {
                if ((this.EndField.Equals(value) != true)) {
                    this.EndField = value;
                    this.RaisePropertyChanged("End");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Returned {
            get {
                return this.ReturnedField;
            }
            set {
                if ((this.ReturnedField.Equals(value) != true)) {
                    this.ReturnedField = value;
                    this.RaisePropertyChanged("Returned");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Start {
            get {
                return this.StartField;
            }
            set {
                if ((this.StartField.Equals(value) != true)) {
                    this.StartField = value;
                    this.RaisePropertyChanged("Start");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaDBManager.UserNS")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LicenseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LicenseExpirationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short LicensePointsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordHashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isAdminField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string License {
            get {
                return this.LicenseField;
            }
            set {
                if ((object.ReferenceEquals(this.LicenseField, value) != true)) {
                    this.LicenseField = value;
                    this.RaisePropertyChanged("License");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LicenseExpiration {
            get {
                return this.LicenseExpirationField;
            }
            set {
                if ((this.LicenseExpirationField.Equals(value) != true)) {
                    this.LicenseExpirationField = value;
                    this.RaisePropertyChanged("LicenseExpiration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short LicensePoints {
            get {
                return this.LicensePointsField;
            }
            set {
                if ((this.LicensePointsField.Equals(value) != true)) {
                    this.LicensePointsField = value;
                    this.RaisePropertyChanged("LicensePoints");
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
        public string PasswordHash {
            get {
                return this.PasswordHashField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordHashField, value) != true)) {
                    this.PasswordHashField = value;
                    this.RaisePropertyChanged("PasswordHash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isAdmin {
            get {
                return this.isAdminField;
            }
            set {
                if ((this.isAdminField.Equals(value) != true)) {
                    this.isAdminField = value;
                    this.RaisePropertyChanged("isAdmin");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="Delta.DeltaManager.BookingNS", ConfigurationName="Booking.IBookingManager")]
    public interface IBookingManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/BookCar", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/BookCarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DeltaClient.Booking.ManagerFault), Action="Delta.DeltaManager.BookingNS/IBookingManager/BookCarManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaManager.Utils")]
        bool BookCar(DeltaClient.Booking.Car BookedCar, System.DateTime Start, System.DateTime End, string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/BookCar", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/BookCarResponse")]
        System.Threading.Tasks.Task<bool> BookCarAsync(DeltaClient.Booking.Car BookedCar, System.DateTime Start, System.DateTime End, string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/DeleteBooking", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/DeleteBookingResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DeltaClient.Booking.ManagerFault), Action="Delta.DeltaManager.BookingNS/IBookingManager/DeleteBookingManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaManager.Utils")]
        bool DeleteBooking(DeltaClient.Booking.Booking DeletableBooking, string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/DeleteBooking", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/DeleteBookingResponse")]
        System.Threading.Tasks.Task<bool> DeleteBookingAsync(DeltaClient.Booking.Booking DeletableBooking, string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/EndBooking", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/EndBookingResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DeltaClient.Booking.ManagerFault), Action="Delta.DeltaManager.BookingNS/IBookingManager/EndBookingManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaManager.Utils")]
        bool EndBooking(DeltaClient.Booking.Booking EndedBooking, int NewKilometers, int Liters, string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/EndBooking", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/EndBookingResponse")]
        System.Threading.Tasks.Task<bool> EndBookingAsync(DeltaClient.Booking.Booking EndedBooking, int NewKilometers, int Liters, string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookings", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DeltaClient.Booking.ManagerFault), Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaManager.Utils")]
        DeltaClient.Booking.Booking[] GetBookings(string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookings", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsResponse")]
        System.Threading.Tasks.Task<DeltaClient.Booking.Booking[]> GetBookingsAsync(string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsForCar", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsForCarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DeltaClient.Booking.ManagerFault), Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsForCarManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaManager.Utils")]
        DeltaClient.Booking.Booking[] GetBookingsForCar(DeltaClient.Booking.Car car, string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsForCar", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsForCarResponse")]
        System.Threading.Tasks.Task<DeltaClient.Booking.Booking[]> GetBookingsForCarAsync(DeltaClient.Booking.Car car, string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsForUser", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsForUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DeltaClient.Booking.ManagerFault), Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsForUserManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaManager.Utils")]
        DeltaClient.Booking.Booking[] GetBookingsForUser(string UserEmail, string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsForUser", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingsForUserResponse")]
        System.Threading.Tasks.Task<DeltaClient.Booking.Booking[]> GetBookingsForUserAsync(string UserEmail, string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingByID", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingByIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(DeltaClient.Booking.ManagerFault), Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingByIDManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Delta.DeltaManager.Utils")]
        DeltaClient.Booking.Booking GetBookingByID(int ID, string Email, string MD5PassHash);
        
        [System.ServiceModel.OperationContractAttribute(Action="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingByID", ReplyAction="Delta.DeltaManager.BookingNS/IBookingManager/GetBookingByIDResponse")]
        System.Threading.Tasks.Task<DeltaClient.Booking.Booking> GetBookingByIDAsync(int ID, string Email, string MD5PassHash);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookingManagerChannel : DeltaClient.Booking.IBookingManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookingManagerClient : System.ServiceModel.ClientBase<DeltaClient.Booking.IBookingManager>, DeltaClient.Booking.IBookingManager {
        
        public BookingManagerClient() {
        }
        
        public BookingManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookingManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool BookCar(DeltaClient.Booking.Car BookedCar, System.DateTime Start, System.DateTime End, string Email, string MD5PassHash) {
            return base.Channel.BookCar(BookedCar, Start, End, Email, MD5PassHash);
        }
        
        public System.Threading.Tasks.Task<bool> BookCarAsync(DeltaClient.Booking.Car BookedCar, System.DateTime Start, System.DateTime End, string Email, string MD5PassHash) {
            return base.Channel.BookCarAsync(BookedCar, Start, End, Email, MD5PassHash);
        }
        
        public bool DeleteBooking(DeltaClient.Booking.Booking DeletableBooking, string Email, string MD5PassHash) {
            return base.Channel.DeleteBooking(DeletableBooking, Email, MD5PassHash);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteBookingAsync(DeltaClient.Booking.Booking DeletableBooking, string Email, string MD5PassHash) {
            return base.Channel.DeleteBookingAsync(DeletableBooking, Email, MD5PassHash);
        }
        
        public bool EndBooking(DeltaClient.Booking.Booking EndedBooking, int NewKilometers, int Liters, string Email, string MD5PassHash) {
            return base.Channel.EndBooking(EndedBooking, NewKilometers, Liters, Email, MD5PassHash);
        }
        
        public System.Threading.Tasks.Task<bool> EndBookingAsync(DeltaClient.Booking.Booking EndedBooking, int NewKilometers, int Liters, string Email, string MD5PassHash) {
            return base.Channel.EndBookingAsync(EndedBooking, NewKilometers, Liters, Email, MD5PassHash);
        }
        
        public DeltaClient.Booking.Booking[] GetBookings(string Email, string MD5PassHash) {
            return base.Channel.GetBookings(Email, MD5PassHash);
        }
        
        public System.Threading.Tasks.Task<DeltaClient.Booking.Booking[]> GetBookingsAsync(string Email, string MD5PassHash) {
            return base.Channel.GetBookingsAsync(Email, MD5PassHash);
        }
        
        public DeltaClient.Booking.Booking[] GetBookingsForCar(DeltaClient.Booking.Car car, string Email, string MD5PassHash) {
            return base.Channel.GetBookingsForCar(car, Email, MD5PassHash);
        }
        
        public System.Threading.Tasks.Task<DeltaClient.Booking.Booking[]> GetBookingsForCarAsync(DeltaClient.Booking.Car car, string Email, string MD5PassHash) {
            return base.Channel.GetBookingsForCarAsync(car, Email, MD5PassHash);
        }
        
        public DeltaClient.Booking.Booking[] GetBookingsForUser(string UserEmail, string Email, string MD5PassHash) {
            return base.Channel.GetBookingsForUser(UserEmail, Email, MD5PassHash);
        }
        
        public System.Threading.Tasks.Task<DeltaClient.Booking.Booking[]> GetBookingsForUserAsync(string UserEmail, string Email, string MD5PassHash) {
            return base.Channel.GetBookingsForUserAsync(UserEmail, Email, MD5PassHash);
        }
        
        public DeltaClient.Booking.Booking GetBookingByID(int ID, string Email, string MD5PassHash) {
            return base.Channel.GetBookingByID(ID, Email, MD5PassHash);
        }
        
        public System.Threading.Tasks.Task<DeltaClient.Booking.Booking> GetBookingByIDAsync(int ID, string Email, string MD5PassHash) {
            return base.Channel.GetBookingByIDAsync(ID, Email, MD5PassHash);
        }
    }
}
