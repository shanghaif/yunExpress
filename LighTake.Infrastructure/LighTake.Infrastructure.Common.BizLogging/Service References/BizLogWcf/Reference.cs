﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18063
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LighTake.Infrastructure.Common.BizLogging.BizLogWcf {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BizLogModel", Namespace="http://schemas.datacontract.org/2004/07/LighTake.BizLog.Services.Dto")]
    [System.SerializableAttribute()]
    public partial class BizLogModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateOnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeywordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KeywordTypeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long LogIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModuleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SummaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SystemCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string URLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserRealNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserTypeField;
        
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
        public System.DateTime CreateOn {
            get {
                return this.CreateOnField;
            }
            set {
                if ((this.CreateOnField.Equals(value) != true)) {
                    this.CreateOnField = value;
                    this.RaisePropertyChanged("CreateOn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IP {
            get {
                return this.IPField;
            }
            set {
                if ((object.ReferenceEquals(this.IPField, value) != true)) {
                    this.IPField = value;
                    this.RaisePropertyChanged("IP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Keyword {
            get {
                return this.KeywordField;
            }
            set {
                if ((object.ReferenceEquals(this.KeywordField, value) != true)) {
                    this.KeywordField = value;
                    this.RaisePropertyChanged("Keyword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int KeywordTypeID {
            get {
                return this.KeywordTypeIDField;
            }
            set {
                if ((this.KeywordTypeIDField.Equals(value) != true)) {
                    this.KeywordTypeIDField = value;
                    this.RaisePropertyChanged("KeywordTypeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long LogID {
            get {
                return this.LogIDField;
            }
            set {
                if ((this.LogIDField.Equals(value) != true)) {
                    this.LogIDField = value;
                    this.RaisePropertyChanged("LogID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mac {
            get {
                return this.MacField;
            }
            set {
                if ((object.ReferenceEquals(this.MacField, value) != true)) {
                    this.MacField = value;
                    this.RaisePropertyChanged("Mac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModuleName {
            get {
                return this.ModuleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ModuleNameField, value) != true)) {
                    this.ModuleNameField = value;
                    this.RaisePropertyChanged("ModuleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary {
            get {
                return this.SummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SummaryField, value) != true)) {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemCode {
            get {
                return this.SystemCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.SystemCodeField, value) != true)) {
                    this.SystemCodeField = value;
                    this.RaisePropertyChanged("SystemCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string URL {
            get {
                return this.URLField;
            }
            set {
                if ((object.ReferenceEquals(this.URLField, value) != true)) {
                    this.URLField = value;
                    this.RaisePropertyChanged("URL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserCode {
            get {
                return this.UserCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.UserCodeField, value) != true)) {
                    this.UserCodeField = value;
                    this.RaisePropertyChanged("UserCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserRealName {
            get {
                return this.UserRealNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserRealNameField, value) != true)) {
                    this.UserRealNameField = value;
                    this.RaisePropertyChanged("UserRealName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserType {
            get {
                return this.UserTypeField;
            }
            set {
                if ((this.UserTypeField.Equals(value) != true)) {
                    this.UserTypeField = value;
                    this.RaisePropertyChanged("UserType");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BizLogFilter", Namespace="http://schemas.datacontract.org/2004/07/LighTake.BizLog.Services.Dto")]
    [System.SerializableAttribute()]
    public partial class BizLogFilter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreateOnEndField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreateOnStartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeywordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KeywordTypeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModuleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageIndexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SummaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SystemCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string URLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserRealNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserTypeField;
        
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
        public System.Nullable<System.DateTime> CreateOnEnd {
            get {
                return this.CreateOnEndField;
            }
            set {
                if ((this.CreateOnEndField.Equals(value) != true)) {
                    this.CreateOnEndField = value;
                    this.RaisePropertyChanged("CreateOnEnd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreateOnStart {
            get {
                return this.CreateOnStartField;
            }
            set {
                if ((this.CreateOnStartField.Equals(value) != true)) {
                    this.CreateOnStartField = value;
                    this.RaisePropertyChanged("CreateOnStart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IP {
            get {
                return this.IPField;
            }
            set {
                if ((object.ReferenceEquals(this.IPField, value) != true)) {
                    this.IPField = value;
                    this.RaisePropertyChanged("IP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Keyword {
            get {
                return this.KeywordField;
            }
            set {
                if ((object.ReferenceEquals(this.KeywordField, value) != true)) {
                    this.KeywordField = value;
                    this.RaisePropertyChanged("Keyword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int KeywordTypeID {
            get {
                return this.KeywordTypeIDField;
            }
            set {
                if ((this.KeywordTypeIDField.Equals(value) != true)) {
                    this.KeywordTypeIDField = value;
                    this.RaisePropertyChanged("KeywordTypeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mac {
            get {
                return this.MacField;
            }
            set {
                if ((object.ReferenceEquals(this.MacField, value) != true)) {
                    this.MacField = value;
                    this.RaisePropertyChanged("Mac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModuleName {
            get {
                return this.ModuleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ModuleNameField, value) != true)) {
                    this.ModuleNameField = value;
                    this.RaisePropertyChanged("ModuleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageIndex {
            get {
                return this.PageIndexField;
            }
            set {
                if ((this.PageIndexField.Equals(value) != true)) {
                    this.PageIndexField = value;
                    this.RaisePropertyChanged("PageIndex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageSize {
            get {
                return this.PageSizeField;
            }
            set {
                if ((this.PageSizeField.Equals(value) != true)) {
                    this.PageSizeField = value;
                    this.RaisePropertyChanged("PageSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary {
            get {
                return this.SummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SummaryField, value) != true)) {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemCode {
            get {
                return this.SystemCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.SystemCodeField, value) != true)) {
                    this.SystemCodeField = value;
                    this.RaisePropertyChanged("SystemCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string URL {
            get {
                return this.URLField;
            }
            set {
                if ((object.ReferenceEquals(this.URLField, value) != true)) {
                    this.URLField = value;
                    this.RaisePropertyChanged("URL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserCode {
            get {
                return this.UserCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.UserCodeField, value) != true)) {
                    this.UserCodeField = value;
                    this.RaisePropertyChanged("UserCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserRealName {
            get {
                return this.UserRealNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserRealNameField, value) != true)) {
                    this.UserRealNameField = value;
                    this.RaisePropertyChanged("UserRealName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserType {
            get {
                return this.UserTypeField;
            }
            set {
                if ((this.UserTypeField.Equals(value) != true)) {
                    this.UserTypeField = value;
                    this.RaisePropertyChanged("UserType");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BizLogWcf.IAPI")]
    public interface IAPI {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAPI/WriteLog")]
        void WriteLog(LighTake.Infrastructure.Common.BizLogging.BizLogWcf.BizLogModel log);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAPI/WriteLogs")]
        void WriteLogs(LighTake.Infrastructure.Common.BizLogging.BizLogWcf.BizLogModel[] logs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAPI/QueryLog", ReplyAction="http://tempuri.org/IAPI/QueryLogResponse")]
        LighTake.Infrastructure.Common.BizLogging.BizLogWcf.BizLogModel[] QueryLog(out int totalRecords, LighTake.Infrastructure.Common.BizLogging.BizLogWcf.BizLogFilter filter);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAPIChannel : LighTake.Infrastructure.Common.BizLogging.BizLogWcf.IAPI, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class APIClient : System.ServiceModel.ClientBase<LighTake.Infrastructure.Common.BizLogging.BizLogWcf.IAPI>, LighTake.Infrastructure.Common.BizLogging.BizLogWcf.IAPI {
        
        public APIClient() {
        }
        
        public APIClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public APIClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public APIClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public APIClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void WriteLog(LighTake.Infrastructure.Common.BizLogging.BizLogWcf.BizLogModel log) {
            base.Channel.WriteLog(log);
        }
        
        public void WriteLogs(LighTake.Infrastructure.Common.BizLogging.BizLogWcf.BizLogModel[] logs) {
            base.Channel.WriteLogs(logs);
        }
        
        public LighTake.Infrastructure.Common.BizLogging.BizLogWcf.BizLogModel[] QueryLog(out int totalRecords, LighTake.Infrastructure.Common.BizLogging.BizLogWcf.BizLogFilter filter) {
            return base.Channel.QueryLog(out totalRecords, filter);
        }
    }
}