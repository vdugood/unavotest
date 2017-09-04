using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SprintWseLibrary.com.sprint.WholesaleSubscriptionDetailService;
using SprintWseLibrary.HelperClasses;
using Microsoft.Web.Services3;
using System.Data;
using DomainObjects;

namespace SprintWseLibrary.DataLayer
{
    public class DataLayer_WholesaleSubscriptionDetailService
    {
        private static WholesaleSubscriptionDetailService wsdsService = new WholesaleSubscriptionDetailService();

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

        /// <summary>
        /// Returns the Valid PricePlans For a Csa
        /// </summary>
        /// <param name="CSA"></param>
        /// <returns></returns>
        public static DataTable GetPpSocList(string CSA)
        {
            wsdsService.wsMessageHeader = getHeader();
            SecurityHelper.prepareSoapContext(wsdsService.RequestSoapContext);

            QueryPpSocListRequest qpslRequest = new QueryPpSocListRequest();
            qpslRequest.csa = CSA;
            QueryPpSocListReply qpslReply = wsdsService.QueryPpSocList(qpslRequest);
            DataTable ppSocDataTable = Converter.ConvertToDataTable(qpslReply.socProfileList);
            return ppSocDataTable;

        }

        public static DataTable GetPpSocList_V2(string CSA)
        {
            wsdsService.wsMessageHeader = getHeader();
            SecurityHelper.prepareSoapContext(wsdsService.RequestSoapContext);

            WholesaleQueryPpSocListV2Type request = new WholesaleQueryPpSocListV2Type();
            request.csa = CSA;

            WholesaleQueryPpSocListV2ResponseType reply = wsdsService.WholesaleQueryPpSocListV2(request);
            DataTable ppSocDT = Converter.ConvertToDataTable(reply.socProfileList);

            return ppSocDT;
        }
   
        /// <summary>
        /// Returns a list of all the Valid CSA's for The Login Details
        /// </summary>
        /// <returns></returns>
        public static string[] GetCSAList()
        {
            wsdsService.wsMessageHeader = getHeader();
            SecurityHelper.prepareSoapContext(wsdsService.RequestSoapContext);

            QueryCsaListReply qclReply = wsdsService.QueryCsaList("");
            DataTable dt = Converter.ConvertToDataTable(qclReply.csaList);
            List<string> list = new List<string>();
            foreach (CsaRecord item in qclReply.csaList)
            {
                list.Add(item.csa);
            }

            return list.ToArray();
        }

        /// <summary>
        /// Returns the valid npa's for a CSA
        /// </summary>
        /// <param name="CSA"></param>
        /// <returns>A string array of the valid Npa's for a Csa</returns>
        public static string[] GetValidNpaList(string CSA)
        {
            wsdsService.wsMessageHeader = getHeader();
            SecurityHelper.prepareSoapContext(wsdsService.RequestSoapContext);

            QueryValidNpaListRequest qvnlRequest = new QueryValidNpaListRequest();
            qvnlRequest.csa = CSA;

            QueryValidNpaListReply qvnlReply = wsdsService.QueryValidNpaList(qvnlRequest);

            return qvnlReply.validNpaList;
        }


        public static DataSet QuerySubscription(String Esn, String Mdn, EsnType etype)
        {
            DataSet ds = new DataSet();
         
            wsdsService.wsMessageHeader = getHeader();
            SecurityHelper.prepareSoapContext(wsdsService.RequestSoapContext);

            QuerySubscriptionRequest qsRequest = new QuerySubscriptionRequest();
            ElectronicSerialNumber esn = new ElectronicSerialNumber();
            esn.Item = Esn;

            switch (etype)
            {
                case EsnType.Hex:
                    esn.ItemElementName = ItemChoiceType.electronicSerialNumberHex;
                    break;
                case EsnType.Dec:
                    esn.ItemElementName = ItemChoiceType.electronicSerialNumberDec;
                    break;
                default:
                    break;
            }

            if (!string.IsNullOrEmpty(Mdn))
            {
                qsRequest.mdn = Mdn;

            }

            SerialNumber sn = new SerialNumber();
            sn.Item = esn;
            qsRequest.esn = sn;
           
            try
            {
                QuerySubscriptionReply qsReply = wsdsService.QuerySubscription(qsRequest);

                DataTable dtFeatures = new DataTable();
                DataTable dtHistory = new DataTable();
                DataTable dtPricePlan = new DataTable();
                if (qsReply.detailedServiceList != null)
                {
                    dtFeatures = Converter.ConvertToDataTable(qsReply.detailedServiceList);
                }
                if (qsReply.mdnList != null)
                {
                    dtHistory = Converter.ConvertToDataTable(qsReply.mdnList);
                }

                if (qsReply.pricePlanList != null)
                {
                    dtPricePlan = Converter.ConvertToDataTable(qsReply.pricePlanList);
                }

                ds.Tables.Add(dtHistory);
                ds.Tables.Add(dtPricePlan);
                ds.Tables.Add(dtFeatures);
                return ds;
            }
            catch
            {
                throw;
            }
        }

        public static DataSet QuerySubscriptionByMDN(string Mdn)
        {
            DataSet ds = new DataSet();
            wsdsService.wsMessageHeader = getHeader();
            SecurityHelper.prepareSoapContext(wsdsService.RequestSoapContext);

            QuerySubscriptionRequest qsRequest = new QuerySubscriptionRequest();
            qsRequest.mdn = Mdn;
            QuerySubscriptionReply qsReply = wsdsService.QuerySubscription(qsRequest);

            DataTable dtFeatures = new DataTable();
            DataTable dtHistory = new DataTable();
            DataTable dtPricePlan = new DataTable();
            if (qsReply.detailedServiceList != null)
            {
                dtFeatures = Converter.ConvertToDataTable(qsReply.detailedServiceList);
            }
            if (qsReply.mdnList != null)
            {
                dtHistory = Converter.ConvertToDataTable(qsReply.mdnList);
            }

            if (qsReply.pricePlanList != null)
            {
                dtPricePlan = Converter.ConvertToDataTable(qsReply.pricePlanList);
            }

            ds.Tables.Add(dtHistory);
            ds.Tables.Add(dtPricePlan);
            ds.Tables.Add(dtFeatures);

            return ds;

        }

        public static DataSet QuerySubscriptionByESN(String ESN)
        {
            wsdsService.wsMessageHeader = getHeader();
            SecurityHelper.prepareSoapContext(wsdsService.RequestSoapContext);


            QuerySubscriptionRequest qsRequest = new QuerySubscriptionRequest();
            ElectronicSerialNumber esn = new ElectronicSerialNumber();
            esn.Item = ESN;


            esn.ItemElementName = ItemChoiceType.electronicSerialNumberDec;

            DataSet ds = new DataSet();

            SerialNumber sn = new SerialNumber();
            sn.Item = esn;
            qsRequest.esn = sn;
            try
            {
                // wsdsService.query
                QuerySubscriptionReply qsReply = wsdsService.QuerySubscription(qsRequest);

                DataTable dtFeatures = new DataTable();
                DataTable dtHistory = new DataTable();
                DataTable dtPricePlan = new DataTable();
                if (qsReply.detailedServiceList != null)
                {
                    dtFeatures = Converter.ConvertToDataTable(qsReply.detailedServiceList);
                }
                if (qsReply.mdnList != null)
                {
                    dtHistory = Converter.ConvertToDataTable(qsReply.mdnList);
                }

                if (qsReply.pricePlanList != null)
                {
                    dtPricePlan = Converter.ConvertToDataTable(qsReply.pricePlanList);
                }

                ds.Tables.Add(dtHistory);
                ds.Tables.Add(dtPricePlan);
                ds.Tables.Add(dtFeatures);

                return ds;

            }
            catch
            {

                throw;
            }

        }

        public static DataSet QuerySubscriptionByESN_V2(String ESN)
        {
            wsdsService.wsMessageHeader = getHeader();
            SecurityHelper.prepareSoapContext(wsdsService.RequestSoapContext);


            WholesaleQuerySubscriptionV2Type qsRequest = new WholesaleQuerySubscriptionV2Type();
            DeviceInfoType deviceInfoType = new DeviceInfoType();


            
            deviceInfoType.serialNumber = ESN;
            deviceInfoType.serialType = DeviceSerialNumberTypeCodeType.E;
            deviceInfoType.serialTypeSpecified = true;

            qsRequest.Item = deviceInfoType;

            DataSet ds = new DataSet();

            try
            {
                // wsdsService.query
                WholesaleQuerySubscriptionV2ResponseType qsReply = wsdsService.WholesaleQuerySubscriptionV2(qsRequest);

                DataTable dtFeatures = new DataTable();
                DataTable dtHistory = new DataTable();
                DataTable dtPricePlan = new DataTable();
                if (qsReply.detailedServiceList != null)
                {
                    dtFeatures = Converter.ConvertToDataTable(qsReply.detailedServiceList);
                }
                if (qsReply.mdnList != null)
                {
                    dtHistory = Converter.ConvertToDataTable(qsReply.mdnList);
                }

                if (qsReply.pricePlanList != null)
                {
                    dtPricePlan = Converter.ConvertToDataTable(qsReply.pricePlanList);
                }

                ds.Tables.Add(dtHistory);
                ds.Tables.Add(dtPricePlan);
                ds.Tables.Add(dtFeatures);

                return ds;

            }
            catch
            {
                throw;
            }

        }

        public static QueryReservedSubscriptionReply QueryReserverdSubscription(string mdn)
        {
            try
            {
                wsdsService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wsdsService.RequestSoapContext);

                QueryReservedSubscriptionRequest qrsRequest = new QueryReservedSubscriptionRequest();
                qrsRequest.mdn = mdn;

                QueryReservedSubscriptionReply qrsReply = wsdsService.QueryReservedSubscription(qrsRequest);
               
                return qrsReply;
            }
            catch
            {
                throw;
            }

        }

        public static WholesaleQueryReservedSubscriptionV2ResponseType QueryWholesaleReserverdSubscription(string mdn)
        {
            try
            {
                wsdsService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wsdsService.RequestSoapContext);

                WholesaleQueryReservedSubscriptionV2Type qrsRequest = new WholesaleQueryReservedSubscriptionV2Type();
                qrsRequest.mdn = mdn;
                WholesaleQueryReservedSubscriptionV2ResponseType qrsReply = wsdsService.WholesaleQueryReservedSubscriptionV2(qrsRequest);
              
                return qrsReply;
            }
            catch
            {
                throw;
            }
        }

        public static WholesaleQuerySubscriptionV2ResponseType QueryWholesaleSubscriptionV2(DeviceInfoType deviceInfoType)
        {
            try
            {
                wsdsService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wsdsService.RequestSoapContext);

                WholesaleQuerySubscriptionV2Type qrsRequest = new WholesaleQuerySubscriptionV2Type();
                qrsRequest.Item = deviceInfoType;
                WholesaleQuerySubscriptionV2ResponseType qrsReply = wsdsService.WholesaleQuerySubscriptionV2(qrsRequest);
           
                return qrsReply;
            }
            catch
            {
                throw;
            }
        }
    }
}
