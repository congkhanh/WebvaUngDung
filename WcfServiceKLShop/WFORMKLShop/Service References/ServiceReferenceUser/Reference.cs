﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFORMKLShop.ServiceReferenceUser {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceKLShop")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChucVuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiaChiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HoTenUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NgaysinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PassUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> QuyenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SoDienThoaiField;
        
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
        public string ChucVu {
            get {
                return this.ChucVuField;
            }
            set {
                if ((object.ReferenceEquals(this.ChucVuField, value) != true)) {
                    this.ChucVuField = value;
                    this.RaisePropertyChanged("ChucVu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DiaChi {
            get {
                return this.DiaChiField;
            }
            set {
                if ((object.ReferenceEquals(this.DiaChiField, value) != true)) {
                    this.DiaChiField = value;
                    this.RaisePropertyChanged("DiaChi");
                }
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
        public string HoTenUser {
            get {
                return this.HoTenUserField;
            }
            set {
                if ((object.ReferenceEquals(this.HoTenUserField, value) != true)) {
                    this.HoTenUserField = value;
                    this.RaisePropertyChanged("HoTenUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDUser {
            get {
                return this.IDUserField;
            }
            set {
                if ((object.ReferenceEquals(this.IDUserField, value) != true)) {
                    this.IDUserField = value;
                    this.RaisePropertyChanged("IDUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ngaysinh {
            get {
                return this.NgaysinhField;
            }
            set {
                if ((object.ReferenceEquals(this.NgaysinhField, value) != true)) {
                    this.NgaysinhField = value;
                    this.RaisePropertyChanged("Ngaysinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PassUser {
            get {
                return this.PassUserField;
            }
            set {
                if ((object.ReferenceEquals(this.PassUserField, value) != true)) {
                    this.PassUserField = value;
                    this.RaisePropertyChanged("PassUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Quyen {
            get {
                return this.QuyenField;
            }
            set {
                if ((this.QuyenField.Equals(value) != true)) {
                    this.QuyenField = value;
                    this.RaisePropertyChanged("Quyen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SoDienThoai {
            get {
                return this.SoDienThoaiField;
            }
            set {
                if ((object.ReferenceEquals(this.SoDienThoaiField, value) != true)) {
                    this.SoDienThoaiField = value;
                    this.RaisePropertyChanged("SoDienThoai");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceUser.IServiceUser")]
    public interface IServiceUser {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/Login", ReplyAction="http://tempuri.org/IServiceUser/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/Login", ReplyAction="http://tempuri.org/IServiceUser/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/All", ReplyAction="http://tempuri.org/IServiceUser/AllResponse")]
        WFORMKLShop.ServiceReferenceUser.User[] All();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/All", ReplyAction="http://tempuri.org/IServiceUser/AllResponse")]
        System.Threading.Tasks.Task<WFORMKLShop.ServiceReferenceUser.User[]> AllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/KTraUser", ReplyAction="http://tempuri.org/IServiceUser/KTraUserResponse")]
        bool KTraUser(string IDUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/KTraUser", ReplyAction="http://tempuri.org/IServiceUser/KTraUserResponse")]
        System.Threading.Tasks.Task<bool> KTraUserAsync(string IDUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/AddUser", ReplyAction="http://tempuri.org/IServiceUser/AddUserResponse")]
        bool AddUser(string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh, int quyen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/AddUser", ReplyAction="http://tempuri.org/IServiceUser/AddUserResponse")]
        System.Threading.Tasks.Task<bool> AddUserAsync(string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh, int quyen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/TimEDitUser", ReplyAction="http://tempuri.org/IServiceUser/TimEDitUserResponse")]
        WFORMKLShop.ServiceReferenceUser.User TimEDitUser(string IDUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/TimEDitUser", ReplyAction="http://tempuri.org/IServiceUser/TimEDitUserResponse")]
        System.Threading.Tasks.Task<WFORMKLShop.ServiceReferenceUser.User> TimEDitUserAsync(string IDUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/EditUser", ReplyAction="http://tempuri.org/IServiceUser/EditUserResponse")]
        bool EditUser(string userht, string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/EditUser", ReplyAction="http://tempuri.org/IServiceUser/EditUserResponse")]
        System.Threading.Tasks.Task<bool> EditUserAsync(string userht, string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/XoaUser", ReplyAction="http://tempuri.org/IServiceUser/XoaUserResponse")]
        bool XoaUser(string IDUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/XoaUser", ReplyAction="http://tempuri.org/IServiceUser/XoaUserResponse")]
        System.Threading.Tasks.Task<bool> XoaUserAsync(string IDUser);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceUserChannel : WFORMKLShop.ServiceReferenceUser.IServiceUser, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceUserClient : System.ServiceModel.ClientBase<WFORMKLShop.ServiceReferenceUser.IServiceUser>, WFORMKLShop.ServiceReferenceUser.IServiceUser {
        
        public ServiceUserClient() {
        }
        
        public ServiceUserClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceUserClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceUserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceUserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public WFORMKLShop.ServiceReferenceUser.User[] All() {
            return base.Channel.All();
        }
        
        public System.Threading.Tasks.Task<WFORMKLShop.ServiceReferenceUser.User[]> AllAsync() {
            return base.Channel.AllAsync();
        }
        
        public bool KTraUser(string IDUser) {
            return base.Channel.KTraUser(IDUser);
        }
        
        public System.Threading.Tasks.Task<bool> KTraUserAsync(string IDUser) {
            return base.Channel.KTraUserAsync(IDUser);
        }
        
        public bool AddUser(string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh, int quyen) {
            return base.Channel.AddUser(IDUser, PassUser, HoTenUser, Email, DiaChi, SoDienThoai, NgaySinh, quyen);
        }
        
        public System.Threading.Tasks.Task<bool> AddUserAsync(string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh, int quyen) {
            return base.Channel.AddUserAsync(IDUser, PassUser, HoTenUser, Email, DiaChi, SoDienThoai, NgaySinh, quyen);
        }
        
        public WFORMKLShop.ServiceReferenceUser.User TimEDitUser(string IDUser) {
            return base.Channel.TimEDitUser(IDUser);
        }
        
        public System.Threading.Tasks.Task<WFORMKLShop.ServiceReferenceUser.User> TimEDitUserAsync(string IDUser) {
            return base.Channel.TimEDitUserAsync(IDUser);
        }
        
        public bool EditUser(string userht, string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh) {
            return base.Channel.EditUser(userht, IDUser, PassUser, HoTenUser, Email, DiaChi, SoDienThoai, NgaySinh);
        }
        
        public System.Threading.Tasks.Task<bool> EditUserAsync(string userht, string IDUser, string PassUser, string HoTenUser, string Email, string DiaChi, string SoDienThoai, string NgaySinh) {
            return base.Channel.EditUserAsync(userht, IDUser, PassUser, HoTenUser, Email, DiaChi, SoDienThoai, NgaySinh);
        }
        
        public bool XoaUser(string IDUser) {
            return base.Channel.XoaUser(IDUser);
        }
        
        public System.Threading.Tasks.Task<bool> XoaUserAsync(string IDUser) {
            return base.Channel.XoaUserAsync(IDUser);
        }
    }
}
