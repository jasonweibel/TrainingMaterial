﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Northwind.WPFConsumer.NorthwindServiceClasses {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NorthwindEmployee", Namespace="http://schemas.datacontract.org/2004/07/Northwind.WCFContracts.DataContract")]
    [System.SerializableAttribute()]
    public partial class NorthwindEmployee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HomePhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public int EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((this.EmployeeIdField.Equals(value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HomePhone {
            get {
                return this.HomePhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.HomePhoneField, value) != true)) {
                    this.HomePhoneField = value;
                    this.RaisePropertyChanged("HomePhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NorthwindProduct", Namespace="http://schemas.datacontract.org/2004/07/Northwind.WCFContracts.DataContract")]
    [System.SerializableAttribute()]
    public partial class NorthwindProduct : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal UnitPriceField;
        
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
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NorthwindServiceClasses.INorthwindServiceContract")]
    public interface INorthwindServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectEmployeeById", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectEmployeeByIdResponse")]
        Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee SelectEmployeeById(int employeeid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectEmployeeById", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectEmployeeByIdResponse")]
        System.Threading.Tasks.Task<Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee> SelectEmployeeByIdAsync(int employeeid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectEmployees", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectEmployeesResponse")]
        Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee[] SelectEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectEmployees", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectEmployeesResponse")]
        System.Threading.Tasks.Task<Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee[]> SelectEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectProductById", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectProductByIdResponse")]
        Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindProduct SelectProductById(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectProductById", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectProductByIdResponse")]
        System.Threading.Tasks.Task<Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindProduct> SelectProductByIdAsync(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectProducts", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectProductsResponse")]
        Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindProduct[] SelectProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectProducts", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectProductsResponse")]
        System.Threading.Tasks.Task<Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindProduct[]> SelectProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectEmployeeTitles", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectEmployeeTitlesResponse")]
        string[] SelectEmployeeTitles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectEmployeeTitles", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectEmployeeTitlesResponse")]
        System.Threading.Tasks.Task<string[]> SelectEmployeeTitlesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectEmployeesByTitle", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectEmployeesByTitleResponse")]
        Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee[] SelectEmployeesByTitle(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/SelectEmployeesByTitle", ReplyAction="http://tempuri.org/INorthwindServiceContract/SelectEmployeesByTitleResponse")]
        System.Threading.Tasks.Task<Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee[]> SelectEmployeesByTitleAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/InsertEmployee", ReplyAction="http://tempuri.org/INorthwindServiceContract/InsertEmployeeResponse")]
        int InsertEmployee(Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INorthwindServiceContract/InsertEmployee", ReplyAction="http://tempuri.org/INorthwindServiceContract/InsertEmployeeResponse")]
        System.Threading.Tasks.Task<int> InsertEmployeeAsync(Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee employee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INorthwindServiceContractChannel : Northwind.WPFConsumer.NorthwindServiceClasses.INorthwindServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NorthwindServiceContractClient : System.ServiceModel.ClientBase<Northwind.WPFConsumer.NorthwindServiceClasses.INorthwindServiceContract>, Northwind.WPFConsumer.NorthwindServiceClasses.INorthwindServiceContract {
        
        public NorthwindServiceContractClient() {
        }
        
        public NorthwindServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NorthwindServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NorthwindServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NorthwindServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee SelectEmployeeById(int employeeid) {
            return base.Channel.SelectEmployeeById(employeeid);
        }
        
        public System.Threading.Tasks.Task<Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee> SelectEmployeeByIdAsync(int employeeid) {
            return base.Channel.SelectEmployeeByIdAsync(employeeid);
        }
        
        public Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee[] SelectEmployees() {
            return base.Channel.SelectEmployees();
        }
        
        public System.Threading.Tasks.Task<Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee[]> SelectEmployeesAsync() {
            return base.Channel.SelectEmployeesAsync();
        }
        
        public Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindProduct SelectProductById(int productID) {
            return base.Channel.SelectProductById(productID);
        }
        
        public System.Threading.Tasks.Task<Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindProduct> SelectProductByIdAsync(int productID) {
            return base.Channel.SelectProductByIdAsync(productID);
        }
        
        public Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindProduct[] SelectProducts() {
            return base.Channel.SelectProducts();
        }
        
        public System.Threading.Tasks.Task<Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindProduct[]> SelectProductsAsync() {
            return base.Channel.SelectProductsAsync();
        }
        
        public string[] SelectEmployeeTitles() {
            return base.Channel.SelectEmployeeTitles();
        }
        
        public System.Threading.Tasks.Task<string[]> SelectEmployeeTitlesAsync() {
            return base.Channel.SelectEmployeeTitlesAsync();
        }
        
        public Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee[] SelectEmployeesByTitle(string title) {
            return base.Channel.SelectEmployeesByTitle(title);
        }
        
        public System.Threading.Tasks.Task<Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee[]> SelectEmployeesByTitleAsync(string title) {
            return base.Channel.SelectEmployeesByTitleAsync(title);
        }
        
        public int InsertEmployee(Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee employee) {
            return base.Channel.InsertEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<int> InsertEmployeeAsync(Northwind.WPFConsumer.NorthwindServiceClasses.NorthwindEmployee employee) {
            return base.Channel.InsertEmployeeAsync(employee);
        }
    }
}