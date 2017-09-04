using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DomainObjects;


namespace SprintWCFService
{
    [ServiceContract]
    public interface ISprintMVNE
    {
         [OperationContract]
         DataTable GetPpSocList(string CSA);
         [OperationContract]
         DataTable GetPpSocList_V2(string CSA);
         [OperationContract]
         string[] GetCSAList();
         [OperationContract]
         string[] GetValidNpaList(string CSA);
         [OperationContract]
         DataSet QuerySubscription(String Esn, String Mdn, EsnType etype);
         [OperationContract]
         DataSet QuerySubscriptionByMDN(string Mdn);
         [OperationContract]
         DataSet QuerySubscriptionByESN(String ESN);
         [OperationContract]
         DataSet QuerySubscriptionByESN_V2(String ESN);
         [OperationContract]
         DataTable GetPricePlans(String CSA);
         [OperationContract]
         string ExpireSubscription(string mdn, DateTime ExpireDate, bool expireDateSpecified);
         [OperationContract]
         string SuspendSubscription(string mdn, string activity);
         [OperationContract]
         string HotlineSubscription(string mdn);
         [OperationContract]
         string RestoreSubscription(string mdn);
         [OperationContract]
         string RemoveSMSBlockRequest(ESNInfo info);
         [OperationContract]
         string IssueSMSBlockRequest(ESNInfo info);
         [OperationContract]
         string ChangeServicePlans(ESNInfo info, bool OldLocalCallOnly,bool OldVoiceMail,bool OldSMSBlock);
         [OperationContract]
         string WholesaleChangeServicePlansV2(string mdn, string newPricePlan);
         [OperationContract]
         string SwapEsn(string mdn, string newEsn);
         [OperationContract]
         string  SwapMdn(string mdn,out string msid );
         [OperationContract]
         void SplitNpaMdn(string oldMdn);
         [OperationContract]
         void SwapMdnWithReserveId(string oldMdn, string reserveMdnId);
         [OperationContract]
         DataSet WholesaleUsageInqueryByMdn(string mdn, DateTime fromDate,DateTime toDate);
         [OperationContract]
         ESNStatusDoc[] ActivateSubscription(ESNInfo[] ESNInfos);
         [OperationContract]
         ESNStatusDoc[] ActivateSubscriptionV2(ESNInfo[] ESNInfos);
         [OperationContract]
         void ActivateSubscriptionNpa(string Esn, string csa, string npa);
         [OperationContract]
         void ReserveSubscription(string csa);
         [OperationContract]
         void ReserveSubscriptionNpa(string csa, string npa);
         [OperationContract]
         void ReserveSubscriptionGeoCode(string csa);
    }
}
