using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SprintWseLibrary.com.sprint.WholesaleUsageInquiryService;
using SprintWseLibrary.HelperClasses;
using System.Data;





namespace SprintWseLibrary.DataLayer
{
    public class DataLayer_WholesaleUsageInquiryService
    {
        private static WholesaleUsageInquiryService wuiService = new WholesaleUsageInquiryService();


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

        public static DataSet WholesaleUsageInqueryByMdn(string mdn, DateTime fromDate,DateTime toDate)
        {
            wuiService.wsMessageHeader = getHeader();
            SecurityHelper.prepareSoapContext(wuiService.RequestSoapContext);

            QuerySubscriptionUsageRequest request = new QuerySubscriptionUsageRequest();
         
            UsageCategory uc = new UsageCategory();
         
            uc.voiceData = true;
            uc.voiceDataSpecified = true;
            request.usageType = UsageTypeCode.B;
            request.usageCategory = uc;

            request.mdn = mdn;
            request.fromDate = fromDate;
            request.toDate = toDate;
            request.fromDateSpecified = true;
            request.toDateSpecified = true;
            request.usageTypeSpecified = true;

            QuerySubscriptionUsageReply reply = wuiService.QuerySubscriptionUsage(request);
            DataSet ds = new DataSet();
                
            ds.Tables.Add(Converter.ConvertToDataTable(reply.callDetailList));
            return ds;

        }
    }
}
