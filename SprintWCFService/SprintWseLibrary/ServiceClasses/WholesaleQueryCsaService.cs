//generated in vs2005

#pragma warning disable 1591

namespace SprintWseLibrary.com.sprint.WholesaleQueryCsaService
{
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "QueryCsaBinding", Namespace = "http://integration.sprint.com/eai/services/QueryCsa/v1/QueryCsa.wsdl")]
    public partial class QueryCsaService : Microsoft.Web.Services3.WebServicesClientProtocol
    {

        private WsMessageHeaderType wsMessageHeaderField;

        private System.Threading.SendOrPostCallback QueryCsaOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        public QueryCsaService()
        {
            this.Url = global::SprintWseLibrary.Properties.Settings.Default.PingTestClient_com_sprint_webservicesgatewaytest_QueryCsaService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        public WsMessageHeaderType wsMessageHeader
        {
            get
            {
                return this.wsMessageHeaderField;
            }
            set
            {
                this.wsMessageHeaderField = value;
            }
        }

        public new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true)
                            && (this.useDefaultCredentialsSetExplicitly == false))
                            && (this.IsLocalFileSystemWebService(value) == false)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        /// <remarks/>
        public event QueryCsaCompletedEventHandler QueryCsaCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("wsMessageHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("queryCsa", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("queryCsaResponse", Namespace = "http://integration.sprint.com/interfaces/QueryCsa/v1/QueryCsaEnvelope.xsd")]
        public QueryCsaReply QueryCsa([System.Xml.Serialization.XmlElementAttribute("queryCsa", Namespace = "http://integration.sprint.com/interfaces/QueryCsa/v1/QueryCsaEnvelope.xsd")] QueryCsaRequest queryCsa1)
        {
            object[] results = this.Invoke("QueryCsa", new object[] {
                        queryCsa1});
            return ((QueryCsaReply)(results[0]));
        }

        /// <remarks/>
        public void QueryCsaAsync(QueryCsaRequest queryCsa1)
        {
            this.QueryCsaAsync(queryCsa1, null);
        }

        /// <remarks/>
        public void QueryCsaAsync(QueryCsaRequest queryCsa1, object userState)
        {
            if ((this.QueryCsaOperationCompleted == null))
            {
                this.QueryCsaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryCsaOperationCompleted);
            }
            this.InvokeAsync("QueryCsa", new object[] {
                        queryCsa1}, this.QueryCsaOperationCompleted, userState);
        }

        private void OnQueryCsaOperationCompleted(object arg)
        {
            if ((this.QueryCsaCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryCsaCompleted(this, new QueryCsaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if (((url == null)
                        || (url == string.Empty)))
            {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024)
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0)))
            {
                return true;
            }
            return false;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://integration.sprint.com/common/header/WSMessageHeader/v2")]
    [System.Xml.Serialization.XmlRootAttribute("wsMessageHeader", Namespace = "http://integration.sprint.com/common/header/WSMessageHeader/v2", IsNullable = false)]
    public partial class WsMessageHeaderType : System.Web.Services.Protocols.SoapHeader
    {

        private TrackingMessageHeaderType trackingMessageHeaderField;

        private SecurityMessageHeaderType securityMessageHeaderField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        public TrackingMessageHeaderType trackingMessageHeader
        {
            get
            {
                return this.trackingMessageHeaderField;
            }
            set
            {
                this.trackingMessageHeaderField = value;
            }
        }

        /// <remarks/>
        public SecurityMessageHeaderType securityMessageHeader
        {
            get
            {
                return this.securityMessageHeaderField;
            }
            set
            {
                this.securityMessageHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://integration.sprint.com/common/header/WSMessageHeader/v2")]
    public partial class TrackingMessageHeaderType
    {

        private string applicationIdField;

        private string applicationUserIdField;

        private string consumerIdField;

        private string messageIdField;

        private string conversationIdField;

        private string timeToLiveField;

        private long replyCompletionCodeField;

        private bool replyCompletionCodeFieldSpecified;

        private System.DateTime messageDateTimeStampField;

        /// <remarks/>
        public string applicationId
        {
            get
            {
                return this.applicationIdField;
            }
            set
            {
                this.applicationIdField = value;
            }
        }

        /// <remarks/>
        public string applicationUserId
        {
            get
            {
                return this.applicationUserIdField;
            }
            set
            {
                this.applicationUserIdField = value;
            }
        }

        /// <remarks/>
        public string consumerId
        {
            get
            {
                return this.consumerIdField;
            }
            set
            {
                this.consumerIdField = value;
            }
        }

        /// <remarks/>
        public string messageId
        {
            get
            {
                return this.messageIdField;
            }
            set
            {
                this.messageIdField = value;
            }
        }

        /// <remarks/>
        public string conversationId
        {
            get
            {
                return this.conversationIdField;
            }
            set
            {
                this.conversationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string timeToLive
        {
            get
            {
                return this.timeToLiveField;
            }
            set
            {
                this.timeToLiveField = value;
            }
        }

        /// <remarks/>
        public long replyCompletionCode
        {
            get
            {
                return this.replyCompletionCodeField;
            }
            set
            {
                this.replyCompletionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool replyCompletionCodeSpecified
        {
            get
            {
                return this.replyCompletionCodeFieldSpecified;
            }
            set
            {
                this.replyCompletionCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime messageDateTimeStamp
        {
            get
            {
                return this.messageDateTimeStampField;
            }
            set
            {
                this.messageDateTimeStampField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://integration.sprint.com/interfaces/QueryCsa/v1/QueryCsaEnvelope.xsd")]
    public partial class QueryCsaReply
    {

        private string streetField;

        private string xStreetField;

        private string cityField;

        private string stateField;

        private PostalCode zipField;

        private string countryField;

        private decimal longitudeField;

        private bool longitudeFieldSpecified;

        private decimal latitudeField;

        private bool latitudeFieldSpecified;

        private string confidenceField;

        private string csaField;

        private bool is3gField;

        private bool is3gFieldSpecified;

        private bool evdoField;

        private bool evdoFieldSpecified;

        private bool idenField;

        private bool idenFieldSpecified;

        private bool hybridField;

        private bool hybridFieldSpecified;

        private CoverageQuality coverageQualityCdmaField;

        private bool coverageQualityCdmaFieldSpecified;

        private CoverageQuality coverageQualityIdenField;

        private bool coverageQualityIdenFieldSpecified;

        private bool roamDigitalField;

        private bool roamDigitalFieldSpecified;

        private bool roamAnalogField;

        private bool roamAnalogFieldSpecified;

        private bool upcomingCoverageCdmaField;

        private bool upcomingCoverageCdmaFieldSpecified;

        private bool upcomingCoverageIdenField;

        private bool upcomingCoverageIdenFieldSpecified;

        private string npaField;

        private string nxxField;

        private string affiliateNameField;

        /// <remarks/>
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string xStreet
        {
            get
            {
                return this.xStreetField;
            }
            set
            {
                this.xStreetField = value;
            }
        }

        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public PostalCode zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }

        /// <remarks/>
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool longitudeSpecified
        {
            get
            {
                return this.longitudeFieldSpecified;
            }
            set
            {
                this.longitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool latitudeSpecified
        {
            get
            {
                return this.latitudeFieldSpecified;
            }
            set
            {
                this.latitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string confidence
        {
            get
            {
                return this.confidenceField;
            }
            set
            {
                this.confidenceField = value;
            }
        }

        /// <remarks/>
        public string csa
        {
            get
            {
                return this.csaField;
            }
            set
            {
                this.csaField = value;
            }
        }

        /// <remarks/>
        public bool is3g
        {
            get
            {
                return this.is3gField;
            }
            set
            {
                this.is3gField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool is3gSpecified
        {
            get
            {
                return this.is3gFieldSpecified;
            }
            set
            {
                this.is3gFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool evdo
        {
            get
            {
                return this.evdoField;
            }
            set
            {
                this.evdoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool evdoSpecified
        {
            get
            {
                return this.evdoFieldSpecified;
            }
            set
            {
                this.evdoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool iden
        {
            get
            {
                return this.idenField;
            }
            set
            {
                this.idenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idenSpecified
        {
            get
            {
                return this.idenFieldSpecified;
            }
            set
            {
                this.idenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool hybrid
        {
            get
            {
                return this.hybridField;
            }
            set
            {
                this.hybridField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hybridSpecified
        {
            get
            {
                return this.hybridFieldSpecified;
            }
            set
            {
                this.hybridFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CoverageQuality coverageQualityCdma
        {
            get
            {
                return this.coverageQualityCdmaField;
            }
            set
            {
                this.coverageQualityCdmaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool coverageQualityCdmaSpecified
        {
            get
            {
                return this.coverageQualityCdmaFieldSpecified;
            }
            set
            {
                this.coverageQualityCdmaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CoverageQuality coverageQualityIden
        {
            get
            {
                return this.coverageQualityIdenField;
            }
            set
            {
                this.coverageQualityIdenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool coverageQualityIdenSpecified
        {
            get
            {
                return this.coverageQualityIdenFieldSpecified;
            }
            set
            {
                this.coverageQualityIdenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool roamDigital
        {
            get
            {
                return this.roamDigitalField;
            }
            set
            {
                this.roamDigitalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool roamDigitalSpecified
        {
            get
            {
                return this.roamDigitalFieldSpecified;
            }
            set
            {
                this.roamDigitalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool roamAnalog
        {
            get
            {
                return this.roamAnalogField;
            }
            set
            {
                this.roamAnalogField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool roamAnalogSpecified
        {
            get
            {
                return this.roamAnalogFieldSpecified;
            }
            set
            {
                this.roamAnalogFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool UpcomingCoverageCdma
        {
            get
            {
                return this.upcomingCoverageCdmaField;
            }
            set
            {
                this.upcomingCoverageCdmaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpcomingCoverageCdmaSpecified
        {
            get
            {
                return this.upcomingCoverageCdmaFieldSpecified;
            }
            set
            {
                this.upcomingCoverageCdmaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool UpcomingCoverageIden
        {
            get
            {
                return this.upcomingCoverageIdenField;
            }
            set
            {
                this.upcomingCoverageIdenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpcomingCoverageIdenSpecified
        {
            get
            {
                return this.upcomingCoverageIdenFieldSpecified;
            }
            set
            {
                this.upcomingCoverageIdenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string npa
        {
            get
            {
                return this.npaField;
            }
            set
            {
                this.npaField = value;
            }
        }

        /// <remarks/>
        public string nxx
        {
            get
            {
                return this.nxxField;
            }
            set
            {
                this.nxxField = value;
            }
        }

        /// <remarks/>
        public string affiliateName
        {
            get
            {
                return this.affiliateNameField;
            }
            set
            {
                this.affiliateNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://integration.sprint.com/interfaces/QueryCsa/v1/QueryCsaEnvelope.xsd")]
    public partial class PostalCode
    {

        private string uspsPostalCdField;

        private string uspsPostalCdExtensionField;

        /// <remarks/>
        public string uspsPostalCd
        {
            get
            {
                return this.uspsPostalCdField;
            }
            set
            {
                this.uspsPostalCdField = value;
            }
        }

        /// <remarks/>
        public string uspsPostalCdExtension
        {
            get
            {
                return this.uspsPostalCdExtensionField;
            }
            set
            {
                this.uspsPostalCdExtensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://integration.sprint.com/interfaces/QueryCsa/v1/QueryCsaEnvelope.xsd")]
    public enum CoverageQuality
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Best Coverage")]
        BestCoverage,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Good Coverage")]
        GoodCoverage,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Fair Coverage")]
        FairCoverage,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("No Coverage")]
        NoCoverage,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://integration.sprint.com/interfaces/QueryCsa/v1/QueryCsaEnvelope.xsd")]
    public partial class QueryCsaRequest
    {

        private GeographicCodeType geoCodeField;

        private string streetField;

        private string xStreetField;

        private string cityField;

        private string stateField;

        private PostalCode zipField;

        private string countryField;

        /// <remarks/>
        public GeographicCodeType geoCode
        {
            get
            {
                return this.geoCodeField;
            }
            set
            {
                this.geoCodeField = value;
            }
        }

        /// <remarks/>
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string xStreet
        {
            get
            {
                return this.xStreetField;
            }
            set
            {
                this.xStreetField = value;
            }
        }

        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public PostalCode zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }

        /// <remarks/>
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://integration.sprint.com/interfaces/QueryCsa/v1/QueryCsaEnvelope.xsd")]
    public enum GeographicCodeType
    {

        /// <remarks/>
        ExactAddress,

        /// <remarks/>
        CrossStreet,

        /// <remarks/>
        Zip,

        /// <remarks/>
        CityState,

        /// <remarks/>
        International,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://integration.sprint.com/common/header/WSMessageHeader/v2")]
    public partial class BasicCredentialInfoType
    {

        private string idField;

        private string passwordField;

        /// <remarks/>
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://integration.sprint.com/common/header/WSMessageHeader/v2")]
    public partial class SdcLoginCredentialsType
    {

        private string userIdField;

        private string passwordField;

        /// <remarks/>
        public string userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }

        /// <remarks/>
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://integration.sprint.com/common/header/WSMessageHeader/v2")]
    public partial class SecurityMessageHeaderType
    {

        private object itemField;

        private string corpIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("basicCredentialInfo", typeof(BasicCredentialInfoType))]
        [System.Xml.Serialization.XmlElementAttribute("pin", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("sdcLoginCredentials", typeof(SdcLoginCredentialsType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public string corpId
        {
            get
            {
                return this.corpIdField;
            }
            set
            {
                this.corpIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    public delegate void QueryCsaCompletedEventHandler(object sender, QueryCsaCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryCsaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal QueryCsaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public QueryCsaReply Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((QueryCsaReply)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591