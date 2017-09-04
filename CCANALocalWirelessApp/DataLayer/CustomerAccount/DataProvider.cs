using System;
using System.Data;
using System.Reflection;

namespace DataLayer.CustomerAccount
{   
    public abstract class DataProvider
    {

        #region Shared/Static Methods

        // singleton reference to the instantiated object 
        static DataProvider objProvider = null;
        

        // constructor
        static DataProvider()
        {
            CreateProvider();
        }

        // dynamically create provider
        private static void CreateProvider()
        {
            object x = new SqlDataProvider();
            objProvider = (DataProvider)x;
        }

        // return the provider
        public static DataProvider Instance()
        {
            return objProvider;
        }

        #endregion

        #region Abstract methods

        #region CREATE
        public abstract void AddCustomerAccount(string InteractionId,
                                          string CustomerAccount,
                                          string m_to,
                                          string m_ACD_PRIORITY,
                                          string m_requestTime,
                                          string m_state,
                                          string m_INTDATE,
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
                                          bool bLOA);

        public abstract void InsertUpdateBquickCustomer(string customerId,
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
            DateTime  Bquick_disconnectDate,
            DateTime  Bquick_suspendDate,
            DateTime  Bquick_dateCreated);
      
        #endregion CREATE

        #region READ
        public abstract DataSet SelUnavoPhoneNumbers(int CompanyId, int SystemId);
        #endregion

        #endregion Abstract methods

    }
}





