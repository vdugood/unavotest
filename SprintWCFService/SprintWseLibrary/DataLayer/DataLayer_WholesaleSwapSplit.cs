using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SprintWseLibrary.com.sprint.WholesaleSwapSplit;
using SprintWseLibrary.HelperClasses;
using Microsoft.Web.Services3;

namespace SprintWseLibrary.DataLayer
{
    public  class DataLayer_WholesaleSwapSplit
    {
        private static WholesaleSwapSplit wssService = new WholesaleSwapSplit();


        private static WsMessageHeaderType getHeader()
        {
            WsMessageHeaderType header = new WsMessageHeaderType();
            header.trackingMessageHeader = new TrackingMessageHeaderType();
            header.trackingMessageHeader.applicationId = "2010102801";
            header.trackingMessageHeader.applicationUserId = "tstool01";
            header.trackingMessageHeader.messageId = "32813";
            header.trackingMessageHeader.timeToLive = "60";
            return header;

        }

        public static string SwapEsn(string mdn, string newEsn)
        {
            try
            {
                wssService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wssService.RequestSoapContext);


                SwapEsnRequest seRequest = new SwapEsnRequest();
                seRequest.mdn = mdn;
                ElectronicSerialNumber esn = new ElectronicSerialNumber();
                esn.Item = newEsn;
                esn.ItemElementName = ItemChoiceType.electronicSerialNumberDec;
                SerialNumber sn = new SerialNumber();
                sn.Item = esn;
                seRequest.esn = sn;
                SwapEsnReply seReply = wssService.SwapEsn(seRequest);
                return seReply.msid;
            }
            catch
            {
                throw;
            }

        }

        public static string  SwapMdn(string mdn,out string msid )
        {
            try
            {
                wssService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wssService.RequestSoapContext);

                SwapMdnRequest smRequest = new SwapMdnRequest();
                smRequest.mdn = mdn;
               
                SwapMdnReply smReply = wssService.SwapMdn(smRequest);
                msid = smReply.msid;
                return smReply.newMdn;
                
            }
            catch
            {
                throw;
            }
        }

        public static void SplitNpaMdn(string oldMdn)
        {
            try
            {
                wssService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wssService.RequestSoapContext);

                SplitNpaMdnRequest snmRequest = new SplitNpaMdnRequest();
                snmRequest.oldMdn = oldMdn;
                
                SplitNpaMdnReply snmReply = wssService.SplitNpaMdn(snmRequest);
            }
            catch
            {
                throw;
            }
        }

        public static void SwapMdnWithReserveId(string oldMdn, string reserveMdnId)
        {
            try
            {

                wssService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wssService.RequestSoapContext);

                SwapMdnWithReserveIdRequest smwriRequest = new SwapMdnWithReserveIdRequest();
                smwriRequest.oldMdn = oldMdn;
                smwriRequest.reserveMdnId = reserveMdnId;
                SwapMdnWithReserveIdReply smwriReply = wssService.SwapMdnWithReserveId(smwriRequest);
            }
            catch
            {
                throw;
            }
        }

    }
}
