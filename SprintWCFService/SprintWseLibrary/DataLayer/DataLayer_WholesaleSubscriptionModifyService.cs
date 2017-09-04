using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WSM = SprintWseLibrary.com.sprint.WholesaleSubscriptionModifyService;
using WSD = SprintWseLibrary.com.sprint.WholesaleSubscriptionDetailService;
using SprintWseLibrary.HelperClasses;
using Microsoft.Web.Services3;
using DomainObjects;

namespace SprintWseLibrary.DataLayer
{
    public class DataLayer_WholesaleSubscriptionModifyService
    {
        private static WSM.WholesaleSubscriptionModifyService wsmsService = new WSM.WholesaleSubscriptionModifyService();


        private static WSM.WsMessageHeaderType getHeader()
        {
            WSM.WsMessageHeaderType header = new WSM.WsMessageHeaderType();
            header.trackingMessageHeader = new WSM.TrackingMessageHeaderType();
            header.trackingMessageHeader.applicationId = "2010102801";
            header.trackingMessageHeader.applicationUserId = "tstool01";
            header.trackingMessageHeader.messageId = "32813";
            header.trackingMessageHeader.timeToLive = "60";
            return header;
        }

        public static DataTable GetPricePlans(String CSA)
        {
          return  DataLayer_WholesaleSubscriptionDetailService.GetPpSocList(CSA);
        }

        public static string ExpireSubscription(string mdn, DateTime ExpireDate, bool expireDateSpecified)
        {

            try
            {
                wsmsService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wsmsService.RequestSoapContext);

                WSM.ExpireSubscriptionRequest esRequest = new WSM.ExpireSubscriptionRequest();

                esRequest.mdn = mdn;
                esRequest.expireDate = ExpireDate;
                esRequest.expireDateSpecified = expireDateSpecified;
                WSM.ConfirmMsg cnfMsg = wsmsService.ExpireSubscription(esRequest);
                return cnfMsg.confirmMsg;
            }
            catch
            {
                throw;
            }
        }

        public static string SuspendSubscription(string mdn, string activity)
        {

            try
            {
                wsmsService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wsmsService.RequestSoapContext);

                WSM.SuspendSubscriptionRequest ssRequest = new WSM.SuspendSubscriptionRequest();

                ssRequest.mdn = mdn;
                ssRequest.activity = activity;

                WSM.ConfirmMsg cnfMsg = wsmsService.SuspendSubscription(ssRequest);
                return cnfMsg.confirmMsg;
            }
            catch
            {
                throw;
            }
        }

        public static string HotlineSubscription(string mdn)
        {
            try
            {
                wsmsService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wsmsService.RequestSoapContext);

                WSM.SuspendSubscriptionRequest ssRequest = new WSM.SuspendSubscriptionRequest();

                ssRequest.mdn = mdn;
                ssRequest.activity = "HTL";

                WSM.ConfirmMsg cnfMsg = wsmsService.SuspendSubscription(ssRequest);
                return cnfMsg.confirmMsg;
            }
            catch
            {
                throw;
            }
        }

        public static string RestoreSubscription(string mdn)
        {

            try
            {
                wsmsService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wsmsService.RequestSoapContext);

                WSM.RestoreSubscriptionRequest rsRequest = new WSM.RestoreSubscriptionRequest();

                rsRequest.mdn = mdn;


                WSM.ConfirmMsg cnfMsg = wsmsService.RestoreSubscription(rsRequest);
                return cnfMsg.confirmMsg;
            }
            catch
            {
                throw;
            }
        }


        public static string RemoveSMSBlockRequest(ESNInfo info)
        {
            try
            {
                wsmsService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wsmsService.RequestSoapContext);

                WSM.ChangeServicePlansRequest cspRequest = new WSM.ChangeServicePlansRequest();
                cspRequest.mdn = info.MDN;

                WSM.ProductDeployment deployment = new WSM.ProductDeployment();
                deployment.serviceCode = "321PLAN2";
                deployment.serviceEffectiveDateSpecified = true;
                deployment.serviceEffectiveDate = DateTime.Now;
                deployment.serviceExpirationDateSpecified = false;
               
                List<WSM.ProductDeployment> list = new List<WSM.ProductDeployment>();
                List<WSM.ProductDeployment> Oldlist = new List<WSM.ProductDeployment>();

                var dt = DataLayer_WholesaleSubscriptionDetailService.GetPpSocList(info.CSA);

                var soc = from r in dt.AsEnumerable()
                          where r.Field<string>("socDescription") == "MO/MT SMS BLOCKING"
                          select r.Field<string>("soc");

                WSM.ProductDeployment deployment3 = new WSM.ProductDeployment();
                deployment3.serviceCode = soc.FirstOrDefault().ToString();
                deployment3.serviceExpirationDate = DateTime.Now;
                deployment3.serviceEffectiveDateSpecified = false;
                deployment3.serviceExpirationDateSpecified = true;
                Oldlist.Add(deployment3);

                if (Oldlist.Count > 0)
                {
                    cspRequest.oldServiceList = Oldlist.ToArray();
                }

                WSM.ConfirmMsg cnfMsg = wsmsService.ChangeServicePlans(cspRequest);
                return cnfMsg.confirmMsg;
                
            }
            catch
            {
                throw;
            }
        }

        public static string IssueSMSBlockRequest(ESNInfo info)
        {
            try
            {
                wsmsService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wsmsService.RequestSoapContext);

                WSM.ChangeServicePlansRequest cspRequest = new WSM.ChangeServicePlansRequest();
                cspRequest.mdn = info.MDN;

                WSM.ProductDeployment deployment = new WSM.ProductDeployment();
                deployment.serviceCode = "321PLAN2";
                deployment.serviceEffectiveDateSpecified = true;
                deployment.serviceEffectiveDate = DateTime.Now;
                deployment.serviceExpirationDateSpecified = false;
                // cspRequest.pricePlan = deployment;

                List<WSM.ProductDeployment> list = new List<WSM.ProductDeployment>();
                List<WSM.ProductDeployment> Oldlist = new List<WSM.ProductDeployment>();

                var dt = DataLayer_WholesaleSubscriptionDetailService.GetPpSocList(info.CSA);
                    
                var soc = from r in dt.AsEnumerable()
                            where r.Field<string>("socDescription") == "MO/MT SMS BLOCKING"
                            select r.Field<string>("soc");

                WSM.ProductDeployment deployment3 = new WSM.ProductDeployment();
                deployment3.serviceCode = soc.FirstOrDefault().ToString();
                deployment3.serviceEffectiveDate = DateTime.Now;
                deployment3.serviceEffectiveDateSpecified = true;
                deployment3.serviceExpirationDateSpecified = false;
                list.Add(deployment3);
              
                if (list.Count > 0 || Oldlist.Count > 0)
                {
                    cspRequest.serviceList = list.ToArray();
                    WSM.ConfirmMsg cnfMsg = wsmsService.ChangeServicePlans(cspRequest);
                    return cnfMsg.confirmMsg;
                }
            }
            catch
            {
                throw;
            }
            return string.Empty;
        }

        public static string ChangeServicePlans(ESNInfo info, bool OldLocalCallOnly,bool OldVoiceMail,bool OldSMSBlock)
        {

            try
            {
                wsmsService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wsmsService.RequestSoapContext);

                WSM.ChangeServicePlansRequest cspRequest = new WSM.ChangeServicePlansRequest();
                cspRequest.mdn = info.MDN;

                WSM.ProductDeployment deployment = new WSM.ProductDeployment();
                deployment.serviceCode = "321PLAN2";
                deployment.serviceEffectiveDateSpecified = true;
                deployment.serviceEffectiveDate = DateTime.Now;
                deployment.serviceExpirationDateSpecified = false;
               
                List<WSM.ProductDeployment> list = new List<WSM.ProductDeployment>();
                List<WSM.ProductDeployment> Oldlist = new List<WSM.ProductDeployment>();
            
                var dt = DataLayer_WholesaleSubscriptionDetailService.GetPpSocList(info.CSA);


                //Set the old services
                
                if(OldLocalCallOnly == true && info.LocalCallOnly == false)
                {
                    var soc = from r in dt.AsEnumerable()
                              where r.Field<string>("socDescription") == "LOCAL CALLING ONLY"
                              select r.Field<string>("soc");

                    WSM.ProductDeployment item = new WSM.ProductDeployment();
                    item.serviceCode = soc.FirstOrDefault().ToString();
                    item.serviceExpirationDate= DateTime.Now;
                    item.serviceEffectiveDateSpecified = false;
                    item.serviceExpirationDateSpecified = true;
                    Oldlist.Add(item);
                }
                if(OldVoiceMail ==true && info.VoiceMail == false)
                {
                    var soc = from r in dt.AsEnumerable()
                              where r.Field<string>("socDescription") == "VOICEMAIL"
                              select r.Field<string>("soc");

                    WSM.ProductDeployment deployment4 = new WSM.ProductDeployment();
                    deployment4.serviceCode = soc.FirstOrDefault().ToString();
                    deployment4.serviceExpirationDate = DateTime.Now;
                    deployment4.serviceEffectiveDateSpecified = false;
                    deployment4.serviceExpirationDateSpecified = true;
                    Oldlist.Add(deployment4);
                }
                if (OldSMSBlock == true && info.SMSBlock ==false )
                {
                    var soc = from r in dt.AsEnumerable()
                              where r.Field<string>("socDescription") == "MO/MT SMS BLOCKING"
                              select r.Field<string>("soc");

                    WSM.ProductDeployment deployment3 = new WSM.ProductDeployment();
                    deployment3.serviceCode = soc.FirstOrDefault().ToString();
                    deployment3.serviceExpirationDate = DateTime.Now;
                    deployment3.serviceEffectiveDateSpecified = false;
                    deployment3.serviceExpirationDateSpecified = true;
                    Oldlist.Add(deployment3);
                }

                if (Oldlist.Count > 0)
                {
                    cspRequest.oldServiceList = Oldlist.ToArray();
                }

                // New services
                if (info.LocalCallOnly && OldLocalCallOnly ==false)
                {
                    var soc = from r in dt.AsEnumerable()
                              where r.Field<string>("socDescription") == "LOCAL CALLING ONLY"
                              select r.Field<string>("soc");

                    WSM.ProductDeployment item = new WSM.ProductDeployment();
                    item.serviceCode = soc.FirstOrDefault().ToString();
                    item.serviceEffectiveDate = DateTime.Now;
                    item.serviceEffectiveDateSpecified = true;
                    item.serviceExpirationDateSpecified = false;
                    list.Add(item);
                }
                if (info.SMSBlock && OldSMSBlock ==false)
                {
                    var soc = from r in dt.AsEnumerable()
                              where r.Field<string>("socDescription") == "MO/MT SMS BLOCKING"
                              select r.Field<string>("soc");

                    WSM.ProductDeployment deployment3 = new WSM.ProductDeployment();
                    deployment3.serviceCode = soc.FirstOrDefault().ToString();
                    deployment3.serviceEffectiveDate = DateTime.Now;
                    deployment3.serviceEffectiveDateSpecified = true;
                    deployment3.serviceExpirationDateSpecified = false;
                    list.Add(deployment3);
                }
                if (info.VoiceMail && OldVoiceMail ==false)
                {
                    var soc = from r in dt.AsEnumerable()
                              where r.Field<string>("socDescription") == "VOICEMAIL"
                              select r.Field<string>("soc");

                    WSM.ProductDeployment deployment4 = new WSM.ProductDeployment();
                    deployment4.serviceCode = soc.FirstOrDefault().ToString();
                    deployment4.serviceEffectiveDate = DateTime.Now;
                    deployment4.serviceEffectiveDateSpecified = true;
                    deployment4.serviceExpirationDateSpecified = false;
                    list.Add(deployment4);
                }

                if (list.Count > 0 || Oldlist.Count >0 )
                {
                    cspRequest.serviceList = list.ToArray();
                    WSM.ConfirmMsg cnfMsg = wsmsService.ChangeServicePlans(cspRequest);
                    return cnfMsg.confirmMsg;
                }
            }
            catch
            {
                throw;
            }
            return string.Empty;
        }

        //changes price plan of the mdn to the new one given.
        public static string WholesaleChangeServicePlansV2(string mdn, string newPricePlan)
        {
            wsmsService.wsMessageHeader = getHeader();
            SecurityHelper.prepareSoapContext(wsmsService.RequestSoapContext);

            WSM.WholesaleChangeServicePlansV2Type request = new WSM.WholesaleChangeServicePlansV2Type();
            request.mdn = mdn;
            request.pricePlan = new WSM.ProductDeploymentType
            {
                serviceCode = newPricePlan,
                serviceEffectiveDate = DateTime.Now,
                serviceEffectiveDateSpecified = true
            };
            
            
            var reply = wsmsService.WholesaleChangeServicePlansV2(request);
          
            return reply.confirmMsg;
        }

    }
}
