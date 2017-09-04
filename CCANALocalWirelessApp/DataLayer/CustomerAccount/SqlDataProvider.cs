using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;

namespace DataLayer.CustomerAccount
{  
    public class SqlDataProvider : DataProvider
    {

        #region Private Members

        private const string ProviderType = "data";
        private const string ModuleQualifier = "";

       // private ProviderConfiguration _providerConfiguration = ProviderConfiguration.GetProviderConfiguration(ProviderType);
        private string _connectionString;
        private string _providerPath;
        private string _objectQualifier;
        private string _databaseOwner;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs new SqlDataProvider instance
        /// </summary>
        public SqlDataProvider()
        {
            //Read the configuration specific information for this provider
           // Provider objProvider = (Provider)_providerConfiguration.Providers[_providerConfiguration.DefaultProvider];

            //Read the attributes for this provider
            //Get Connection string from web.config
            _connectionString = ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
            

            //if (_connectionString.Length == 0)
            //{
            //    //Use connection string specified in provider
            //    _connectionString = objProvider.Attributes["connectionString"];
            //}

            _providerPath = string.Empty;

            _objectQualifier = string.Empty;

            if ((_objectQualifier != "") && (_objectQualifier.EndsWith("_") == false))
            {
                _objectQualifier += "_";
            }

            _databaseOwner = string.Empty;
            if ((_databaseOwner != "") && (_databaseOwner.EndsWith(".") == false))
            {
                _databaseOwner += ".";
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets and sets the connection string
        /// </summary>
        public string ConnectionString
        {
            get { return _connectionString; }
        }

        /// <summary>
        /// Gets and sets the Provider path
        /// </summary>
        public string ProviderPath
        {
            get { return _providerPath; }
        }

        /// <summary>
        /// Gets and sets the Object qualifier
        /// </summary>
        public string ObjectQualifier
        {
            get { return _objectQualifier; }
        }

        /// <summary>
        /// Gets and sets the database ownere
        /// </summary>
        public string DatabaseOwner
        {
            get { return _databaseOwner; }
        }

        #endregion

        #region Private Methods

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Gets the fully qualified name of the stored procedure
        /// </summary>
        /// <param name="name">The name of the stored procedure</param>
        /// <returns>The fully qualified name</returns>
        /// -----------------------------------------------------------------------------
        private string GetFullyQualifiedName(string name)
        {
            return DatabaseOwner + ObjectQualifier + ModuleQualifier + name;
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Gets the value for the field or DbNull if field has "null" value
        /// </summary>
        /// <param name="Field">The field to evaluate</param>
        /// <returns></returns>
        /// -----------------------------------------------------------------------------
        //private Object GetNull(Object Field)
        //{
        //    return Null.GetNull(Field, DBNull.Value);
        //}

        #endregion

        #region Public Methods - CRUD

        #region CREATE

        //add a company data
        public override void AddCustomerAccount(
                                          string InteractionId ,
	                                      string CustomerAccount ,
                                          string to,
                                          string ACD_PRIORITY,
                                          string requestTime,
                                          string state,
                                          string INTDATE,
                                          string from,
                                          string projectId,
                                          string imFirstName,
                                          string systemOfferTime,
                                          string uniqueId,
                                          string imLastName,
                                          string imContactId,
                                          string timezone,
                                          string customerId,
                                          string phoneNumber,
                                          string systemTransfer,
                                          string priority,
                                          string userName,
                                          string scriptId,
                                          string queueTime,
                                          string offset,
                                          string firstName,
                                          string doNotRecord,
                                          string INTID,
                                          string systemEmailSubject,
                                          string lastName,
                                          string systemStartTime,
                                          string interactionId,
                                          string MCT,
                                          string agentLastName,
                                          string faqId,
                                          string countryCode,
                                          string agentId,
                                          string display,
                                          string companyName,
                                          string workgroupId,
                                          string predictiveContactId,
                                          string extension,
                                          string contactId,
                                          string email,
                                          string sessionId,
                                          string agentFirstName,
                                          string imCompanyName,
                                          string companyId,
                                          string otherId,
                                          string interactionType,
                                          string agentCompanyName,
                                          bool bLOA)
        {
            SqlParameter[] arParms = new SqlParameter[50];

            arParms[0] = new SqlParameter("@InteractionId", SqlDbType.VarChar);
            arParms[0].Value = InteractionId;

            arParms[1] = new SqlParameter("@CustomerAccount", SqlDbType.VarChar);
            arParms[1].Value = CustomerAccount;

            arParms[2] = new SqlParameter("@to", SqlDbType.VarChar);
            arParms[2].Value = to;

            arParms[3] = new SqlParameter("@ACD_PRIORITY", SqlDbType.VarChar);
            arParms[3].Value = ACD_PRIORITY;

            arParms[4] = new SqlParameter("@RequestTime", SqlDbType.VarChar);
            arParms[4].Value = requestTime;
    
            arParms[5] = new SqlParameter("@State", SqlDbType.VarChar);
            arParms[5].Value = state;

            arParms[6] = new SqlParameter("@INTDATE", SqlDbType.VarChar);
            arParms[6].Value = INTDATE;

            arParms[7] = new SqlParameter("@from", SqlDbType.VarChar);
            arParms[7].Value = from;

            arParms[8] = new SqlParameter("@ProjectId", SqlDbType.VarChar);
            arParms[8].Value = projectId;

            arParms[9] = new SqlParameter("@ImFirstName", SqlDbType.VarChar);
            arParms[9].Value = imFirstName;

            arParms[10] = new SqlParameter("@SystemOfferTime", SqlDbType.VarChar);
            arParms[10].Value = systemOfferTime;

            arParms[11] = new SqlParameter("@UniqueId", SqlDbType.VarChar);
            arParms[11].Value = uniqueId;

            arParms[12] = new SqlParameter("@ImLastName", SqlDbType.VarChar);
            arParms[12].Value = imLastName;

            arParms[13] = new SqlParameter("@ImContactId", SqlDbType.VarChar);
            arParms[13].Value = imContactId;

            arParms[14] = new SqlParameter("@Timezone", SqlDbType.VarChar);
            arParms[14].Value = timezone;

            arParms[15] = new SqlParameter("@CustomerId", SqlDbType.VarChar);
            arParms[15].Value = customerId;

            arParms[16] = new SqlParameter("@PhoneNumber", SqlDbType.VarChar);
            arParms[16].Value = phoneNumber;

            arParms[17] = new SqlParameter("@SystemTransfer", SqlDbType.VarChar);
            arParms[17].Value = systemTransfer;
		
		    arParms[18] = new SqlParameter("@Priority", SqlDbType.VarChar);
            arParms[18].Value = priority;

            arParms[19] = new SqlParameter("@UserName", SqlDbType.VarChar);
            arParms[19].Value = userName;

            arParms[20] = new SqlParameter("@scriptId", SqlDbType.VarChar);
            arParms[20].Value = scriptId;

            arParms[21] = new SqlParameter("@QueueTime", SqlDbType.VarChar);
            arParms[21].Value = queueTime;

            arParms[22] = new SqlParameter("@Offset", SqlDbType.VarChar);
            arParms[22].Value = offset;

            arParms[23] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            arParms[23].Value = firstName;

            arParms[24] = new SqlParameter("@DoNotRecord", SqlDbType.VarChar);
            arParms[24].Value = doNotRecord;

            arParms[25] = new SqlParameter("@INTID", SqlDbType.VarChar);
            arParms[25].Value = INTID;

            arParms[26] = new SqlParameter("@SystemEmailSubject", SqlDbType.VarChar);
            arParms[26].Value = systemEmailSubject;

            arParms[27] = new SqlParameter("@LastName", SqlDbType.VarChar);
            arParms[27].Value = lastName;

            arParms[28] = new SqlParameter("@systemStartTime", SqlDbType.VarChar);
            arParms[28].Value = systemStartTime;

            arParms[29] = new SqlParameter("@MCT", SqlDbType.VarChar);
            arParms[29].Value = MCT;

            arParms[30] = new SqlParameter("@AgentLastName", SqlDbType.VarChar);
            arParms[30].Value = agentLastName;

            arParms[31] = new SqlParameter("@FaqId", SqlDbType.VarChar);
            arParms[31].Value = faqId;

            arParms[32] = new SqlParameter("@CountryCode", SqlDbType.VarChar);
            arParms[32].Value = countryCode;

            arParms[33] = new SqlParameter("@AgentId", SqlDbType.VarChar);
            arParms[33].Value = agentId;

            arParms[34] = new SqlParameter("@Display", SqlDbType.VarChar);
            arParms[34].Value = display;

            arParms[35] = new SqlParameter("@CompanyName", SqlDbType.VarChar);
            arParms[35].Value = companyName;

            arParms[36] = new SqlParameter("@WorkgroupId", SqlDbType.VarChar);
            arParms[36].Value = workgroupId;

            arParms[37] = new SqlParameter("@PredictiveContactId", SqlDbType.VarChar);
            arParms[37].Value = predictiveContactId;

            arParms[38] = new SqlParameter("@Extension", SqlDbType.VarChar);
            arParms[38].Value = extension;

            arParms[39] = new SqlParameter("@ContactId", SqlDbType.VarChar);
            arParms[39].Value = contactId;

            arParms[40] = new SqlParameter("@Email", SqlDbType.VarChar);
            arParms[40].Value = email;

            arParms[41] = new SqlParameter("@SessionId", SqlDbType.VarChar);
            arParms[41].Value = sessionId;

            arParms[42] = new SqlParameter("@AgentFirstName", SqlDbType.VarChar);
            arParms[42].Value = agentFirstName;

            arParms[43] = new SqlParameter("@ImCompanyName", SqlDbType.VarChar);
            arParms[43].Value = imCompanyName;

            arParms[44] = new SqlParameter("@CompanyId", SqlDbType.VarChar);
            arParms[44].Value = companyId;

            arParms[45] = new SqlParameter("@OtherId", SqlDbType.VarChar);
            arParms[45].Value = otherId;

            arParms[46] = new SqlParameter("@InteractionType", SqlDbType.VarChar);
            arParms[46].Value = interactionType;

            arParms[47] = new SqlParameter("@AgentCompanyName", SqlDbType.VarChar);
            arParms[47].Value = agentCompanyName;

            arParms[48] = new SqlParameter("@CCASystemId", SqlDbType.Int);
            arParms[48].Value = 100001;

            arParms[49] = new SqlParameter("@LOA", SqlDbType.Bit);
            arParms[49].Value = bLOA;

            SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.StoredProcedure, GetFullyQualifiedName("sms_InsCustomerAccountInteractionId"), arParms);
        }


        public override void InsertUpdateBquickCustomer(string customerId,
            string salutation,
            string firstName,
            string lastName,
            string agentId,
            string advertisingCode,
            string middleInitial,
            string lifelineCertificationEtc,
            string lifelineCertificationType,
            string lifelineCertificationReceived,
            string renewalDate,
            string salesRepresentative,
            string lineType,
            string statusId,
            string statusName,
            decimal balance,
            decimal balancePastDue,
            string contactPhone,
            string contactPhoneExt,
            string cellPhone,
            string primaryPhone,
            string neighborPhone,
            string pagerPhone,
            string faxPhone,
            string workPhone,
            string workPhoneExtension,
            string email,
            string DOB,
            string SSN,
            string ServiceAddress_address1,
            string ServiceAddress_address2,
            string ServiceAddress_city,
            string ServiceAddress_Zip,
            string ServiceAddress_Zip4,
            string ServiceAddress_county,
            string ServiceAddress_state,
            string BillingAddress_address1,
            string BillingAddress_address2,
            string BillingAddress_city,
            string BillingAddress_Zip,
            string BillingAddress_Zip4,
            string BillingAddress_county,
            string BillingAddress_state,
            string DNIS,
            string InteractionId,
            string FromNumber,
            int CCASystemId,
            DateTime Bquick_activationDate,
            DateTime Bquick_disconnectDate,
            DateTime Bquick_suspendDate,
            DateTime Bquick_dateCreated)
        {
            //insert the customer

            SqlParameter[] parameter = new SqlParameter[51];

            parameter[0] = new SqlParameter("@customerId", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(customerId) == false)
            {
                parameter[0].Value = customerId;
            }
            else
            {
                parameter[0].Value = DBNull.Value;
            }

            parameter[1] = new SqlParameter("@salutation", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(salutation) == false)
            {
                parameter[1].Value = salutation;
            }
            else
            {
                parameter[1].Value = DBNull.Value;
            }

            parameter[2] = new SqlParameter("@firstName", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(firstName) == false)
            {
                parameter[2].Value = firstName;
            }
            else
            {
                parameter[2].Value = DBNull.Value;
            }

            parameter[3] = new SqlParameter("@lastName", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(lastName) == false)
            {
                parameter[3].Value = lastName;
            }
            else
            {
                parameter[3].Value = DBNull.Value;
            }

            parameter[4] = new SqlParameter("@middleInitial", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(middleInitial) == false)
            {
                parameter[4].Value = middleInitial;
            }
            else
            {
                parameter[4].Value = DBNull.Value;
            }

            parameter[5] = new SqlParameter("@lifelineCertificationEtc", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(lifelineCertificationEtc) == false)
            {
                parameter[5].Value = lifelineCertificationEtc;
            }
            else
            {
                parameter[5].Value = DBNull.Value;
            }

            parameter[6] = new SqlParameter("@lifelineCertificationType", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(lifelineCertificationType) == false)
            {
                parameter[6].Value = lifelineCertificationType;
            }
            else
            {
                parameter[6].Value = DBNull.Value;
            }

            parameter[7] = new SqlParameter("@lifelineCertificationReceived", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(lifelineCertificationReceived) == false)
            {
                parameter[7].Value = lifelineCertificationReceived;
            }
            else
            {
                parameter[7].Value = DBNull.Value;
            }

            parameter[8] = new SqlParameter("@renewalDate", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(renewalDate) == false)
            {
                parameter[8].Value = renewalDate;
            }
            else
            {
                parameter[8].Value = DBNull.Value;
            }

            parameter[9] = new SqlParameter("@salesRepresentative", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(salesRepresentative) == false)
            {
                parameter[9].Value = salesRepresentative;
            }
            else
            {
                parameter[9].Value = DBNull.Value;
            }

            parameter[10] = new SqlParameter("@lineType", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(lineType) == false)
            {
                parameter[10].Value = lineType;
            }
            else
            {
                parameter[10].Value = DBNull.Value;
            }

            parameter[11] = new SqlParameter("@statusId", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(statusId) == false)
            {
                parameter[11].Value = statusId;
            }
            else
            {
                parameter[11].Value = DBNull.Value;
            }

            parameter[12] = new SqlParameter("@statusName", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(statusName) == false)
            {
                parameter[12].Value = statusName;
            }
            else
            {
                parameter[12].Value = DBNull.Value;
            }

            parameter[13] = new SqlParameter("@balance", SqlDbType.Decimal);
            if (balance != decimal.MinValue)
            {
                parameter[13].Value = balance;
            }
            else
            {
                parameter[13].Value = DBNull.Value;
            }

            parameter[14] = new SqlParameter("@balancePastDue", SqlDbType.Decimal);
            if (balancePastDue != decimal.MinValue)
            {
                parameter[14].Value = balance;
            }
            else
            {
                parameter[14].Value = DBNull.Value;
            }

            parameter[15] = new SqlParameter("@agentId", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(agentId) == false)
            {
                parameter[15].Value = agentId;
            }
            else
            {
                parameter[15].Value = DBNull.Value;
            }

            parameter[16] = new SqlParameter("@advertisingCode", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(advertisingCode) == false)
            {
                parameter[16].Value = advertisingCode;
            }
            else
            {
                parameter[16].Value = DBNull.Value;
            }
            parameter[17] = new SqlParameter("@contactPhone", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(contactPhone) == false)
            {
                parameter[17].Value = contactPhone;
            }
            else
            {
                parameter[17].Value = DBNull.Value;
            }
            parameter[18] = new SqlParameter("@contactPhoneExt", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(contactPhoneExt) == false)
            {
                parameter[18].Value = contactPhoneExt;
            }
            else
            {
                parameter[18].Value = DBNull.Value;
            }

            parameter[19] = new SqlParameter("@cellPhone", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(cellPhone) == false)
            {
                parameter[19].Value = cellPhone;
            }
            else
            {
                parameter[19].Value = DBNull.Value;
            }

            parameter[20] = new SqlParameter("@primaryPhone", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(primaryPhone) == false)
            {
                parameter[20].Value = primaryPhone;
            }
            else
            {
                parameter[20].Value = DBNull.Value;
            }

            parameter[21] = new SqlParameter("@neighborPhone", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(neighborPhone) == false)
            {
                parameter[21].Value = neighborPhone;
            }
            else
            {
                parameter[21].Value = DBNull.Value;
            }

            parameter[22] = new SqlParameter("@pagerPhone", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(pagerPhone) == false)
            {
                parameter[22].Value = pagerPhone;
            }
            else
            {
                parameter[22].Value = DBNull.Value;
            }

            parameter[23] = new SqlParameter("@faxPhone", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(faxPhone) == false)
            {
                parameter[23].Value = faxPhone;
            }
            else
            {
                parameter[23].Value = DBNull.Value;
            }

            parameter[24] = new SqlParameter("@workPhone", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(workPhone) == false)
            {
                parameter[24].Value = workPhone;
            }
            else
            {
                parameter[24].Value = DBNull.Value;
            }

            parameter[25] = new SqlParameter("@workPhoneExtension", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(workPhoneExtension) == false)
            {
                parameter[25].Value = workPhoneExtension;
            }
            else
            {
                parameter[25].Value = DBNull.Value;
            }

            parameter[26] = new SqlParameter("@email", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(email) == false)
            {
                parameter[26].Value = email;
            }
            else
            {
                parameter[26].Value = DBNull.Value;
            }

            parameter[27] = new SqlParameter("@DOB", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(DOB) == false)
            {
                parameter[27].Value = DOB;
            }
            else
            {
                parameter[27].Value = DBNull.Value;
            }

            parameter[28] = new SqlParameter("@SSN", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(SSN) == false)
            {
                parameter[28].Value = SSN;
            }
            else
            {
                parameter[28].Value = DBNull.Value;
            }

            //Address info
            parameter[29] = new SqlParameter("@ServiceAddress_address1", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(ServiceAddress_address1) == false)
            {
                parameter[29].Value = ServiceAddress_address1;
            }
            else
            {
                parameter[29].Value = DBNull.Value;
            }

            parameter[30] = new SqlParameter("@ServiceAddress_address2", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(ServiceAddress_address2) == false)
            {
                parameter[30].Value = ServiceAddress_address2;
            }
            else
            {
                parameter[30].Value = DBNull.Value;
            }

            parameter[31] = new SqlParameter("@ServiceAddress_city", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(ServiceAddress_city) == false)
            {
                parameter[31].Value = ServiceAddress_city;
            }
            else
            {
                parameter[31].Value = DBNull.Value;
            }

            parameter[32] = new SqlParameter("@ServiceAddress_Zip", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(ServiceAddress_Zip) == false)
            {
                parameter[32].Value = ServiceAddress_Zip;
            }
            else
            {
                parameter[32].Value = DBNull.Value;
            }

            parameter[33] = new SqlParameter("@ServiceAddress_Zip4", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(ServiceAddress_Zip4) == false)
            {
                parameter[33].Value = ServiceAddress_Zip;
            }
            else
            {
                parameter[33].Value = DBNull.Value;
            }

            parameter[34] = new SqlParameter("@ServiceAddress_county", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(ServiceAddress_county) == false)
            {
                parameter[34].Value = ServiceAddress_county;
            }
            else
            {
                parameter[34].Value = DBNull.Value;
            }

            parameter[35] = new SqlParameter("@ServiceAddress_state", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(ServiceAddress_state) == false)
            {
                parameter[35].Value = ServiceAddress_state;
            }
            else
            {
                parameter[35].Value = DBNull.Value;
            }

            parameter[36] = new SqlParameter("@BillingAddress_address1", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(BillingAddress_address1) == false)
            {
                parameter[36].Value = BillingAddress_address1;
            }
            else
            {
                parameter[36].Value = DBNull.Value;
            }

            parameter[37] = new SqlParameter("@BillingAddress_address2", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(BillingAddress_address2) == false)
            {
                parameter[37].Value = BillingAddress_address2;
            }
            else
            {
                parameter[37].Value = DBNull.Value;
            }

            parameter[38] = new SqlParameter("@BillingAddress_city", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(BillingAddress_city) == false)
            {
                parameter[38].Value = BillingAddress_city;
            }
            else
            {
                parameter[38].Value = DBNull.Value;
            }

            parameter[39] = new SqlParameter("@BillingAddress_Zip", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(BillingAddress_Zip) == false)
            {
                parameter[39].Value = BillingAddress_Zip;
            }
            else
            {
                parameter[39].Value = DBNull.Value;
            }

            parameter[40] = new SqlParameter("@BillingAddress_Zip4", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(BillingAddress_Zip4) == false)
            {
                parameter[40].Value = BillingAddress_Zip4;
            }
            else
            {
                parameter[40].Value = DBNull.Value;
            }

            parameter[41] = new SqlParameter("@BillingAddress_county", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(BillingAddress_county) == false)
            {
                parameter[41].Value = BillingAddress_county;
            }
            else
            {
                parameter[41].Value = DBNull.Value;
            }

            parameter[42] = new SqlParameter("@BillingAddress_state", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(BillingAddress_county) == false)
            {
                parameter[42].Value = BillingAddress_county;
            }
            else
            {
                parameter[42].Value = DBNull.Value;
            }

            parameter[43] = new SqlParameter("@DNIS", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(DNIS) == false)
            {
                parameter[43].Value = DNIS;
            }
            else
            {
                parameter[43].Value = DBNull.Value;
            }

            parameter[44] = new SqlParameter("@InteractionId", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(InteractionId) == false)
            {
                parameter[44].Value = InteractionId;
            }
            else
            {
                parameter[44].Value = DBNull.Value;
            }

            parameter[45] = new SqlParameter("@FromNumber", SqlDbType.VarChar);
            if (string.IsNullOrEmpty(FromNumber) == false)
            {
                parameter[45].Value = FromNumber;
            }
            else
            {
                parameter[45].Value = DBNull.Value;
            }
            
            parameter[46] = new SqlParameter("@CCASystemId", SqlDbType.Int);
            parameter[46].Value = CCASystemId;

            parameter[47] = new SqlParameter("@Bquick_activationDate", SqlDbType.DateTime);
            if (Bquick_activationDate != DateTime.MinValue)
            {
                parameter[47].Value = Bquick_activationDate;
            }
            else
            {
                parameter[47].Value = DBNull.Value;
            }
        
            parameter[48] = new SqlParameter("@Bquick_disconnectDate", SqlDbType.DateTime);
            if (Bquick_disconnectDate != DateTime.MinValue)
            {
                parameter[48].Value = Bquick_disconnectDate;
            }
            else
            {
                parameter[48].Value = DBNull.Value;
            }

            parameter[49] = new SqlParameter("@Bquick_suspendDate", SqlDbType.DateTime);
            if (Bquick_disconnectDate != DateTime.MinValue)
            {
                parameter[49].Value = Bquick_suspendDate;
            }
            else
            {
                parameter[49].Value = DBNull.Value;
            }

             parameter[50] = new SqlParameter("@Bquick_dateCreated", SqlDbType.DateTime);
            if (Bquick_disconnectDate != DateTime.MinValue)
            {
                parameter[50].Value = Bquick_dateCreated;
            }
            else
            {
                parameter[50].Value = DBNull.Value;
            }
         
            try
            {
                SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.StoredProcedure, "sms_InsUpdBquickCustomer", parameter);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        #endregion CREATE

        #region READ
        public override DataSet SelUnavoPhoneNumbers(int CompanyId, int SystemId)
        {
            SqlParameter[] arParms = new SqlParameter[2];

            arParms[0] = new SqlParameter("@CompanyId", SqlDbType.Int);
            arParms[0].Value = CompanyId;

            arParms[1] = new SqlParameter("@SystemId", SqlDbType.Int);
            arParms[1].Value = SystemId;

            try
            {
                return SqlHelper.ExecuteDataset(ConnectionString, CommandType.StoredProcedure, "spSelUnavoPhoneNumbers", arParms);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #endregion - CRUD

    }
}
