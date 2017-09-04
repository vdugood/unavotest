using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SprintWseLibrary.com.sprint.WholesalePortMessageService;
using SprintWseLibrary.HelperClasses;


namespace SprintWseLibrary.DataLayer
{
    public class DataLayer_WholesalePortMessageService
    {
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
    }
}
