using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Xml;
using System.Web;



namespace DataLayer.CustomerAccount
{
    public class CustomerAccountController //: ISearchable, IPortable
    {
        #region Constructors

        public CustomerAccountController()
        {
        }

        #endregion

        #region Public Methods - CRUD

        #region CREATE

        public  void  AddCustomerAccount(string InteractionId,
                                         string CustomerAccount,
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


            DataProvider.Instance().AddCustomerAccount(InteractionId,
                                          CustomerAccount, 
                                          to,
                                          ACD_PRIORITY,
                                          requestTime,
                                          state,
                                          INTDATE,
                                          from,
                                          projectId,
                                          imFirstName,
                                          systemOfferTime,
                                          uniqueId,
                                          imLastName,
                                          imContactId,
                                          timezone,
                                          customerId,
                                          phoneNumber,
                                          systemTransfer,
                                          priority,
                                          userName,
                                          scriptId,
                                          queueTime,
                                          offset,
                                          firstName,
                                          doNotRecord,
                                          INTID,
                                          systemEmailSubject,
                                          lastName,
                                          systemStartTime,
                                          interactionId,
                                          MCT,
                                          agentLastName,
                                          faqId,
                                          countryCode,
                                          agentId,
                                          display,
                                          companyName,
                                          workgroupId,
                                          predictiveContactId,
                                          extension,
                                          contactId,
                                          email,
                                          sessionId,
                                          agentFirstName,
                                          imCompanyName,
                                          companyId,
                                          otherId,
                                          interactionType,
                                          agentCompanyName,
                                          bLOA);
        }

        public void InsertUpdateBquickCustomer(string customerId,
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
            DataProvider.Instance().InsertUpdateBquickCustomer(customerId,
                                      salutation,
                                      firstName,
                                      lastName,
                                      agentId,
                                      advertisingCode,
                                      middleInitial,
                                      lifelineCertificationEtc,
                                      lifelineCertificationType,
                                      lifelineCertificationReceived,
                                      renewalDate,
                                      salesRepresentative,
                                      lineType,
                                      statusId,
                                      statusName,
                                      balance,
                                      balancePastDue,
                                      contactPhone,
                                      contactPhoneExt,
                                      cellPhone,
                                      primaryPhone,
                                      neighborPhone,
                                      pagerPhone,
                                      faxPhone,
                                      workPhone,
                                      workPhoneExtension,
                                      email,
                                      DOB,
                                      SSN,
                                     ServiceAddress_address1,
                                     ServiceAddress_address2,
                                     ServiceAddress_city,
                                     ServiceAddress_Zip,
                                     ServiceAddress_Zip4,
                                     ServiceAddress_county,
                                     ServiceAddress_state,
                                     BillingAddress_address1,
                                     BillingAddress_address2,
                                     BillingAddress_city,
                                     BillingAddress_Zip,
                                     BillingAddress_Zip4,
                                     BillingAddress_county,
                                     BillingAddress_state,
                                     DNIS,
                                     InteractionId,
                                     FromNumber,
                                     CCASystemId,
                                     Bquick_activationDate,
                                     Bquick_disconnectDate,
                                     Bquick_suspendDate,
                                     Bquick_dateCreated);
                                }
    
        #endregion CREATE


        #region READ

        public DataSet SelUnavoPhoneNumbers(int CompanyId, int SystemId)
        {
            return  DataProvider.Instance().SelUnavoPhoneNumbers(CompanyId,SystemId);
        }

        #endregion
        #endregion Public Methods


    }
}

