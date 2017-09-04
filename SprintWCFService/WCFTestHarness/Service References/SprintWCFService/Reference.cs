﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFTestHarness.SprintWCFService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EsnType", Namespace="http://schemas.datacontract.org/2004/07/DomainObjects")]
    public enum EsnType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Hex = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Dec = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ESNInfo", Namespace="http://schemas.datacontract.org/2004/07/DomainObjects")]
    [System.SerializableAttribute()]
    public partial class ESNInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ActivationtypeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CSAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ESNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool LocalCallOnlyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MDNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MSIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SMSBlockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool VoiceMailField;
        
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
        public int ActivationtypeId {
            get {
                return this.ActivationtypeIdField;
            }
            set {
                if ((this.ActivationtypeIdField.Equals(value) != true)) {
                    this.ActivationtypeIdField = value;
                    this.RaisePropertyChanged("ActivationtypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CSA {
            get {
                return this.CSAField;
            }
            set {
                if ((object.ReferenceEquals(this.CSAField, value) != true)) {
                    this.CSAField = value;
                    this.RaisePropertyChanged("CSA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ESN {
            get {
                return this.ESNField;
            }
            set {
                if ((object.ReferenceEquals(this.ESNField, value) != true)) {
                    this.ESNField = value;
                    this.RaisePropertyChanged("ESN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool LocalCallOnly {
            get {
                return this.LocalCallOnlyField;
            }
            set {
                if ((this.LocalCallOnlyField.Equals(value) != true)) {
                    this.LocalCallOnlyField = value;
                    this.RaisePropertyChanged("LocalCallOnly");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MDN {
            get {
                return this.MDNField;
            }
            set {
                if ((object.ReferenceEquals(this.MDNField, value) != true)) {
                    this.MDNField = value;
                    this.RaisePropertyChanged("MDN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MSID {
            get {
                return this.MSIDField;
            }
            set {
                if ((object.ReferenceEquals(this.MSIDField, value) != true)) {
                    this.MSIDField = value;
                    this.RaisePropertyChanged("MSID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SMSBlock {
            get {
                return this.SMSBlockField;
            }
            set {
                if ((this.SMSBlockField.Equals(value) != true)) {
                    this.SMSBlockField = value;
                    this.RaisePropertyChanged("SMSBlock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool VoiceMail {
            get {
                return this.VoiceMailField;
            }
            set {
                if ((this.VoiceMailField.Equals(value) != true)) {
                    this.VoiceMailField = value;
                    this.RaisePropertyChanged("VoiceMail");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ESNStatusDoc", Namespace="http://schemas.datacontract.org/2004/07/DomainObjects")]
    [System.SerializableAttribute()]
    public partial class ESNStatusDoc : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ESNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFTestHarness.SprintWCFService.ESNSTATUSENUM ESNStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MDNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MSIDField;
        
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
        public string ESN {
            get {
                return this.ESNField;
            }
            set {
                if ((object.ReferenceEquals(this.ESNField, value) != true)) {
                    this.ESNField = value;
                    this.RaisePropertyChanged("ESN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFTestHarness.SprintWCFService.ESNSTATUSENUM ESNStatus {
            get {
                return this.ESNStatusField;
            }
            set {
                if ((this.ESNStatusField.Equals(value) != true)) {
                    this.ESNStatusField = value;
                    this.RaisePropertyChanged("ESNStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MDN {
            get {
                return this.MDNField;
            }
            set {
                if ((object.ReferenceEquals(this.MDNField, value) != true)) {
                    this.MDNField = value;
                    this.RaisePropertyChanged("MDN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MSID {
            get {
                return this.MSIDField;
            }
            set {
                if ((object.ReferenceEquals(this.MSIDField, value) != true)) {
                    this.MSIDField = value;
                    this.RaisePropertyChanged("MSID");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ESNSTATUSENUM", Namespace="http://schemas.datacontract.org/2004/07/DomainObjects")]
    public enum ESNSTATUSENUM : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NONE = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SUCCEEDED = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FAILED = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SprintWCFService.ISprintMVNE")]
    public interface ISprintMVNE {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/GetPpSocList", ReplyAction="http://tempuri.org/ISprintMVNE/GetPpSocListResponse")]
        System.Data.DataTable GetPpSocList(string CSA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/GetPpSocList_V2", ReplyAction="http://tempuri.org/ISprintMVNE/GetPpSocList_V2Response")]
        System.Data.DataTable GetPpSocList_V2(string CSA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/GetCSAList", ReplyAction="http://tempuri.org/ISprintMVNE/GetCSAListResponse")]
        string[] GetCSAList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/GetValidNpaList", ReplyAction="http://tempuri.org/ISprintMVNE/GetValidNpaListResponse")]
        string[] GetValidNpaList(string CSA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/QuerySubscription", ReplyAction="http://tempuri.org/ISprintMVNE/QuerySubscriptionResponse")]
        System.Data.DataSet QuerySubscription(string Esn, string Mdn, WCFTestHarness.SprintWCFService.EsnType etype);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/QuerySubscriptionByMDN", ReplyAction="http://tempuri.org/ISprintMVNE/QuerySubscriptionByMDNResponse")]
        System.Data.DataSet QuerySubscriptionByMDN(string Mdn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/QuerySubscriptionByESN", ReplyAction="http://tempuri.org/ISprintMVNE/QuerySubscriptionByESNResponse")]
        System.Data.DataSet QuerySubscriptionByESN(string ESN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/QuerySubscriptionByESN_V2", ReplyAction="http://tempuri.org/ISprintMVNE/QuerySubscriptionByESN_V2Response")]
        System.Data.DataSet QuerySubscriptionByESN_V2(string ESN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/GetPricePlans", ReplyAction="http://tempuri.org/ISprintMVNE/GetPricePlansResponse")]
        System.Data.DataTable GetPricePlans(string CSA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/ExpireSubscription", ReplyAction="http://tempuri.org/ISprintMVNE/ExpireSubscriptionResponse")]
        string ExpireSubscription(string mdn, System.DateTime ExpireDate, bool expireDateSpecified);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/SuspendSubscription", ReplyAction="http://tempuri.org/ISprintMVNE/SuspendSubscriptionResponse")]
        string SuspendSubscription(string mdn, string activity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/HotlineSubscription", ReplyAction="http://tempuri.org/ISprintMVNE/HotlineSubscriptionResponse")]
        string HotlineSubscription(string mdn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/RestoreSubscription", ReplyAction="http://tempuri.org/ISprintMVNE/RestoreSubscriptionResponse")]
        string RestoreSubscription(string mdn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/RemoveSMSBlockRequest", ReplyAction="http://tempuri.org/ISprintMVNE/RemoveSMSBlockRequestResponse")]
        string RemoveSMSBlockRequest(WCFTestHarness.SprintWCFService.ESNInfo info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/IssueSMSBlockRequest", ReplyAction="http://tempuri.org/ISprintMVNE/IssueSMSBlockRequestResponse")]
        string IssueSMSBlockRequest(WCFTestHarness.SprintWCFService.ESNInfo info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/ChangeServicePlans", ReplyAction="http://tempuri.org/ISprintMVNE/ChangeServicePlansResponse")]
        string ChangeServicePlans(WCFTestHarness.SprintWCFService.ESNInfo info, bool OldLocalCallOnly, bool OldVoiceMail, bool OldSMSBlock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/WholesaleChangeServicePlansV2", ReplyAction="http://tempuri.org/ISprintMVNE/WholesaleChangeServicePlansV2Response")]
        string WholesaleChangeServicePlansV2(string mdn, string newPricePlan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/SwapEsn", ReplyAction="http://tempuri.org/ISprintMVNE/SwapEsnResponse")]
        string SwapEsn(string mdn, string newEsn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/SwapMdn", ReplyAction="http://tempuri.org/ISprintMVNE/SwapMdnResponse")]
        string SwapMdn(out string msid, string mdn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/SplitNpaMdn", ReplyAction="http://tempuri.org/ISprintMVNE/SplitNpaMdnResponse")]
        void SplitNpaMdn(string oldMdn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/SwapMdnWithReserveId", ReplyAction="http://tempuri.org/ISprintMVNE/SwapMdnWithReserveIdResponse")]
        void SwapMdnWithReserveId(string oldMdn, string reserveMdnId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/WholesaleUsageInqueryByMdn", ReplyAction="http://tempuri.org/ISprintMVNE/WholesaleUsageInqueryByMdnResponse")]
        System.Data.DataSet WholesaleUsageInqueryByMdn(string mdn, System.DateTime fromDate, System.DateTime toDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/ActivateSubscription", ReplyAction="http://tempuri.org/ISprintMVNE/ActivateSubscriptionResponse")]
        WCFTestHarness.SprintWCFService.ESNStatusDoc[] ActivateSubscription(WCFTestHarness.SprintWCFService.ESNInfo[] ESNInfos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/ActivateSubscriptionV2", ReplyAction="http://tempuri.org/ISprintMVNE/ActivateSubscriptionV2Response")]
        WCFTestHarness.SprintWCFService.ESNStatusDoc[] ActivateSubscriptionV2(WCFTestHarness.SprintWCFService.ESNInfo[] ESNInfos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/ActivateSubscriptionNpa", ReplyAction="http://tempuri.org/ISprintMVNE/ActivateSubscriptionNpaResponse")]
        void ActivateSubscriptionNpa(string Esn, string csa, string npa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/ReserveSubscription", ReplyAction="http://tempuri.org/ISprintMVNE/ReserveSubscriptionResponse")]
        void ReserveSubscription(string csa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/ReserveSubscriptionNpa", ReplyAction="http://tempuri.org/ISprintMVNE/ReserveSubscriptionNpaResponse")]
        void ReserveSubscriptionNpa(string csa, string npa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISprintMVNE/ReserveSubscriptionGeoCode", ReplyAction="http://tempuri.org/ISprintMVNE/ReserveSubscriptionGeoCodeResponse")]
        void ReserveSubscriptionGeoCode(string csa);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISprintMVNEChannel : WCFTestHarness.SprintWCFService.ISprintMVNE, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SprintMVNEClient : System.ServiceModel.ClientBase<WCFTestHarness.SprintWCFService.ISprintMVNE>, WCFTestHarness.SprintWCFService.ISprintMVNE {
        
        public SprintMVNEClient() {
        }
        
        public SprintMVNEClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SprintMVNEClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SprintMVNEClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SprintMVNEClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetPpSocList(string CSA) {
            return base.Channel.GetPpSocList(CSA);
        }
        
        public System.Data.DataTable GetPpSocList_V2(string CSA) {
            return base.Channel.GetPpSocList_V2(CSA);
        }
        
        public string[] GetCSAList() {
            return base.Channel.GetCSAList();
        }
        
        public string[] GetValidNpaList(string CSA) {
            return base.Channel.GetValidNpaList(CSA);
        }
        
        public System.Data.DataSet QuerySubscription(string Esn, string Mdn, WCFTestHarness.SprintWCFService.EsnType etype) {
            return base.Channel.QuerySubscription(Esn, Mdn, etype);
        }
        
        public System.Data.DataSet QuerySubscriptionByMDN(string Mdn) {
            return base.Channel.QuerySubscriptionByMDN(Mdn);
        }
        
        public System.Data.DataSet QuerySubscriptionByESN(string ESN) {
            return base.Channel.QuerySubscriptionByESN(ESN);
        }
        
        public System.Data.DataSet QuerySubscriptionByESN_V2(string ESN) {
            return base.Channel.QuerySubscriptionByESN_V2(ESN);
        }
        
        public System.Data.DataTable GetPricePlans(string CSA) {
            return base.Channel.GetPricePlans(CSA);
        }
        
        public string ExpireSubscription(string mdn, System.DateTime ExpireDate, bool expireDateSpecified) {
            return base.Channel.ExpireSubscription(mdn, ExpireDate, expireDateSpecified);
        }
        
        public string SuspendSubscription(string mdn, string activity) {
            return base.Channel.SuspendSubscription(mdn, activity);
        }
        
        public string HotlineSubscription(string mdn) {
            return base.Channel.HotlineSubscription(mdn);
        }
        
        public string RestoreSubscription(string mdn) {
            return base.Channel.RestoreSubscription(mdn);
        }
        
        public string RemoveSMSBlockRequest(WCFTestHarness.SprintWCFService.ESNInfo info) {
            return base.Channel.RemoveSMSBlockRequest(info);
        }
        
        public string IssueSMSBlockRequest(WCFTestHarness.SprintWCFService.ESNInfo info) {
            return base.Channel.IssueSMSBlockRequest(info);
        }
        
        public string ChangeServicePlans(WCFTestHarness.SprintWCFService.ESNInfo info, bool OldLocalCallOnly, bool OldVoiceMail, bool OldSMSBlock) {
            return base.Channel.ChangeServicePlans(info, OldLocalCallOnly, OldVoiceMail, OldSMSBlock);
        }
        
        public string WholesaleChangeServicePlansV2(string mdn, string newPricePlan) {
            return base.Channel.WholesaleChangeServicePlansV2(mdn, newPricePlan);
        }
        
        public string SwapEsn(string mdn, string newEsn) {
            return base.Channel.SwapEsn(mdn, newEsn);
        }
        
        public string SwapMdn(out string msid, string mdn) {
            return base.Channel.SwapMdn(out msid, mdn);
        }
        
        public void SplitNpaMdn(string oldMdn) {
            base.Channel.SplitNpaMdn(oldMdn);
        }
        
        public void SwapMdnWithReserveId(string oldMdn, string reserveMdnId) {
            base.Channel.SwapMdnWithReserveId(oldMdn, reserveMdnId);
        }
        
        public System.Data.DataSet WholesaleUsageInqueryByMdn(string mdn, System.DateTime fromDate, System.DateTime toDate) {
            return base.Channel.WholesaleUsageInqueryByMdn(mdn, fromDate, toDate);
        }
        
        public WCFTestHarness.SprintWCFService.ESNStatusDoc[] ActivateSubscription(WCFTestHarness.SprintWCFService.ESNInfo[] ESNInfos) {
            return base.Channel.ActivateSubscription(ESNInfos);
        }
        
        public WCFTestHarness.SprintWCFService.ESNStatusDoc[] ActivateSubscriptionV2(WCFTestHarness.SprintWCFService.ESNInfo[] ESNInfos) {
            return base.Channel.ActivateSubscriptionV2(ESNInfos);
        }
        
        public void ActivateSubscriptionNpa(string Esn, string csa, string npa) {
            base.Channel.ActivateSubscriptionNpa(Esn, csa, npa);
        }
        
        public void ReserveSubscription(string csa) {
            base.Channel.ReserveSubscription(csa);
        }
        
        public void ReserveSubscriptionNpa(string csa, string npa) {
            base.Channel.ReserveSubscriptionNpa(csa, npa);
        }
        
        public void ReserveSubscriptionGeoCode(string csa) {
            base.Channel.ReserveSubscriptionGeoCode(csa);
        }
    }
}