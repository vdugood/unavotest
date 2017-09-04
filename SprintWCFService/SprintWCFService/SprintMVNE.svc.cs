using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SprintWseLibrary.DataLayer;
using DomainObjects;

namespace SprintWCFService
{
    public class SprintMVNE : ISprintMVNE
    {
        
        public DataTable GetPpSocList(string CSA)
        {
            return DataLayer_WholesaleSubscriptionDetailService.GetPpSocList(CSA);
        }
        
        public DataTable GetPpSocList_V2(string CSA)
        {
            return DataLayer_WholesaleSubscriptionDetailService.GetPpSocList_V2(CSA);
        }
        
        public string[] GetCSAList()
        {
            return DataLayer_WholesaleSubscriptionDetailService.GetCSAList();
        }

        public string[] GetValidNpaList(string CSA)
        {
            return DataLayer_WholesaleSubscriptionDetailService.GetValidNpaList(CSA);
        }

        public DataSet QuerySubscription(String Esn, String Mdn, EsnType etype)
        {
            return DataLayer_WholesaleSubscriptionDetailService.QuerySubscription(Esn, Mdn, etype);
        }
       
        public DataSet QuerySubscriptionByMDN(string Mdn)
        {
            return DataLayer_WholesaleSubscriptionDetailService.QuerySubscriptionByMDN(Mdn);
        }

        public DataSet QuerySubscriptionByESN(String ESN)
        {
            return DataLayer_WholesaleSubscriptionDetailService.QuerySubscriptionByESN(ESN);
        }

        
        public DataSet QuerySubscriptionByESN_V2(String ESN)
        {
            return DataLayer_WholesaleSubscriptionDetailService.QuerySubscriptionByESN_V2(ESN);
        }
        
        public DataTable GetPricePlans(String CSA)
        {
            return DataLayer_WholesaleSubscriptionModifyService.GetPricePlans(CSA);
        }

        
        public string ExpireSubscription(string mdn, DateTime ExpireDate, bool expireDateSpecified)
        {
            return DataLayer_WholesaleSubscriptionModifyService.ExpireSubscription(mdn,ExpireDate,expireDateSpecified);
        }
        
        public string SuspendSubscription(string mdn, string activity)
        {
            return DataLayer_WholesaleSubscriptionModifyService.SuspendSubscription(mdn,activity);
        }

        
        public string HotlineSubscription(string mdn)
        {
            return DataLayer_WholesaleSubscriptionModifyService.HotlineSubscription(mdn);
        }

        public string RestoreSubscription(string mdn)
        {
            return DataLayer_WholesaleSubscriptionModifyService.RestoreSubscription(mdn);
        }
        
        public string RemoveSMSBlockRequest(ESNInfo info)
        {
            return DataLayer_WholesaleSubscriptionModifyService.RemoveSMSBlockRequest(info);
        }

        
        public string IssueSMSBlockRequest(ESNInfo info)
        {
            return DataLayer_WholesaleSubscriptionModifyService.IssueSMSBlockRequest(info);
        }

        public string ChangeServicePlans(ESNInfo info, bool OldLocalCallOnly, bool OldVoiceMail, bool OldSMSBlock)
        {
            return DataLayer_WholesaleSubscriptionModifyService.ChangeServicePlans(info, OldLocalCallOnly,OldVoiceMail,OldSMSBlock);
        }
        
        public string WholesaleChangeServicePlansV2(string mdn, string newPricePlan)
        {
            return DataLayer_WholesaleSubscriptionModifyService.WholesaleChangeServicePlansV2(mdn, newPricePlan);
        }
        
        public string SwapEsn(string mdn, string newEsn)
        {
            return DataLayer_WholesaleSwapSplit.SwapEsn(mdn, newEsn);
        }
        
        public string SwapMdn(string mdn, out string msid)
        {
            return DataLayer_WholesaleSwapSplit.SwapMdn(mdn, out  msid);
        }
        
        public void SplitNpaMdn(string oldMdn)
        {
            DataLayer_WholesaleSwapSplit.SplitNpaMdn(oldMdn);
        }

        public void SwapMdnWithReserveId(string oldMdn, string reserveMdnId)
        {
            DataLayer_WholesaleSwapSplit.SwapMdnWithReserveId(oldMdn, reserveMdnId);
        }
        
        public DataSet WholesaleUsageInqueryByMdn(string mdn, DateTime fromDate, DateTime toDate)
        {
           return DataLayer_WholesaleUsageInquiryService.WholesaleUsageInqueryByMdn(mdn,fromDate,toDate);
        }

        public ESNStatusDoc[] ActivateSubscription(ESNInfo[] ESNInfos)
        {
            List<ESNInfo> lstESNInfo = new List<ESNInfo>(ESNInfos);

            return DataLayer_WolesaleSubscriptionService.ActivateSubscription(lstESNInfo);

        }

        public ESNStatusDoc[] ActivateSubscriptionV2(ESNInfo[] ESNInfos)
        {
            List<ESNInfo> lstESNInfo = new List<ESNInfo>(ESNInfos);

            return DataLayer_WolesaleSubscriptionService.ActivateSubscriptionV2(lstESNInfo);

        }
        
        public void ActivateSubscriptionNpa(string Esn, string csa, string npa)
        {
            DataLayer_WolesaleSubscriptionService.ActivateSubscriptionNpa(Esn,csa, npa);
        }

        public void ReserveSubscription(string csa)
        {
            DataLayer_WolesaleSubscriptionService.ReserveSubscription(csa);
        }

        public void ReserveSubscriptionNpa(string csa, string npa)
        {
            DataLayer_WolesaleSubscriptionService.ReserveSubscriptionNpa(csa, npa);
        }

        public void ReserveSubscriptionGeoCode(string csa)
        {
            DataLayer_WolesaleSubscriptionService.ReserveSubscriptionGeoCode(csa);
        }
    }
}