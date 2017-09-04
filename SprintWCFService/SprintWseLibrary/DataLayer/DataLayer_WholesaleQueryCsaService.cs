using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SprintWseLibrary.com.sprint.WholesaleQueryCsaService;
using SprintWseLibrary.HelperClasses;


namespace SprintWseLibrary.DataLayer
{
    public  class DataLayer_WholesaleQueryCsaService
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


        public static void QueryCsa(GeographicCodeType geoCode, string City, string Country, string ZipCode,
            string State, string Street, string Xstreet)
        {
            ///* Instantiate an instance of the proxy class. */
            QueryCsaService service = new QueryCsaService();
          
            service.wsMessageHeader = getHeader();
            SecurityHelper.prepareSoapContext(service.RequestSoapContext);

            try{
                                
                QueryCsaRequest request = new QueryCsaRequest();

                if (!string.IsNullOrEmpty(ZipCode))
                {
                    PostalCode code = new PostalCode();
                    code.uspsPostalCd = ZipCode;
                    request.zip = code;
                }

                if (!string.IsNullOrEmpty(Street))
                {
                    request.street = Street;
                }
                if (!string.IsNullOrEmpty(Xstreet))
                {
                    request.xStreet = Xstreet;
                }
                if (!string.IsNullOrEmpty(State))
                {
                    request.state = State;
                }

                 request.geoCode = geoCode;
                
                if (!string.IsNullOrEmpty(ZipCode))
                {
                    request.city = City;
                }
                if (!string.IsNullOrEmpty(ZipCode))
                {
                    request.country = Country;
                }

                QueryCsaReply reply = service.QueryCsa(request);
            }
            catch
            {
                throw;
            }

        }

    }
}
