using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SprintWseLibrary.com.sprint.WholesaleSubscriptionService;
using SprintWseLibrary.HelperClasses;
using Microsoft.Web.Services3;
using DomainObjects;

namespace SprintWseLibrary.DataLayer
{
    public class DataLayer_WolesaleSubscriptionService
    {
        private static WholesaleSubscriptionService wssService = new WholesaleSubscriptionService();


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

        public static ESNStatusDoc[] ActivateSubscription(List<ESNInfo> lstESNInfo)
        {
            List<ESNStatusDoc> lstESNDoc = new List<ESNStatusDoc>();
            try
            {
                // wssService.activa
                wssService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wssService.RequestSoapContext);
                ESNStatusDoc doc = null;
                foreach (ESNInfo info in lstESNInfo)
                {

                    try
                    {
                        ActivateSubscriptionRequest request = new ActivateSubscriptionRequest();
                        request.csa = info.CSA;
                        request.effectiveDate = DateTime.Now;
                        request.effectiveDateSpecified = true;
                        ProductDeployment deployment = new ProductDeployment();
                        deployment.serviceCode = "321PLAN2";
                        deployment.serviceEffectiveDateSpecified = false;
                        deployment.serviceExpirationDateSpecified = false;
                        request.pricePlan = deployment;
                        ElectronicSerialNumber number = new ElectronicSerialNumber();
                        number.Item = info.ESN;
                        number.ItemElementName = ItemChoiceType.electronicSerialNumberDec;
                        SerialNumber number2 = new SerialNumber();
                        number2.Item = number;
                        request.esn = number2;
                        List<ProductDeployment> list = new List<ProductDeployment>();

                        var dt = DataLayer_WholesaleSubscriptionDetailService.GetPpSocList(info.CSA);

                        if (info.LocalCallOnly)
                        {
                            var soc = from r in dt.AsEnumerable()
                                      where r.Field<string>("socDescription") == "LOCAL CALLING ONLY"
                                      select r.Field<string>("soc");

                            ProductDeployment item = new ProductDeployment();
                            item.serviceCode = soc.FirstOrDefault().ToString();
                            item.serviceEffectiveDate = DateTime.Now;
                            item.serviceEffectiveDateSpecified = true;
                            item.serviceExpirationDateSpecified = false;
                            list.Add(item);
                        }
                        if (info.SMSBlock)
                        {
                            var soc = from r in dt.AsEnumerable()
                                      where r.Field<string>("socDescription") == "MO/MT SMS BLOCKING"
                                      select r.Field<string>("soc");

                            ProductDeployment deployment3 = new ProductDeployment();
                            deployment3.serviceCode = soc.FirstOrDefault().ToString();
                            deployment3.serviceEffectiveDate = DateTime.Now;
                            deployment3.serviceEffectiveDateSpecified = true;
                            deployment3.serviceExpirationDateSpecified = false;
                            list.Add(deployment3);
                        }
                        if (info.VoiceMail)
                        {
                            var soc = from r in dt.AsEnumerable()
                                      where r.Field<string>("socDescription") == "VOICEMAIL"
                                      select r.Field<string>("soc");

                            ProductDeployment deployment4 = new ProductDeployment();
                            deployment4.serviceCode = soc.FirstOrDefault().ToString();
                            deployment4.serviceEffectiveDate = DateTime.Now;
                            deployment4.serviceEffectiveDateSpecified = true;
                            deployment4.serviceExpirationDateSpecified = false;
                            list.Add(deployment4);
                        }

                        if (list.Count > 0)
                        {
                            request.serviceList = list.ToArray();
                        }
                        ActivateSubscriptionReply reply = wssService.ActivateSubscription(request);

                        info.MDN = reply.mdn;
                        info.MSID = reply.msid;

                        doc = new ESNStatusDoc();
                        doc.ESN = info.ESN;
                        doc.MDN = info.MDN;
                        doc.MSID = info.MSID;
                        doc.ESNStatus = ESNSTATUSENUM.SUCCEEDED;
                        doc.Message = "Activated";
                        lstESNDoc.Add(doc);

                    }
                    catch (System.Web.Services.Protocols.SoapException soapEx)
                    {
                        doc = new ESNStatusDoc();
                        doc.ESN = info.ESN;
                        doc.ESNStatus = ESNSTATUSENUM.FAILED;
                        doc.Message = soapEx.Detail.InnerText;
                        lstESNDoc.Add(doc);
                    }
                }
                return lstESNDoc.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ESNStatusDoc[] ActivateSubscriptionV2(List<ESNInfo> lstESNInfo)
        {

            List<ESNStatusDoc> lstESNDoc = new List<ESNStatusDoc>();
            try
            {
                // wssService.activa
                wssService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wssService.RequestSoapContext);
                ESNStatusDoc doc = null;
                foreach (ESNInfo info in lstESNInfo)
                {

                    try
                    {
        
                        WholesaleActivateSubscriptionV2Type request = new WholesaleActivateSubscriptionV2Type();
                        request.csa = info.CSA;
                        request.effectiveDate = DateTime.Now;
                        request.effectiveDateSpecified = true;
                        ProductDeploymentType2 deployment = new ProductDeploymentType2();
                        deployment.serviceCode = "321PLAN4";
                     
                        request.pricePlan = deployment;
                      
                        request.deviceInfo = new DeviceInfoType3()
                        {
                            serialNumber = info.ESN,
                            serialType = DeviceSerialNumberTypeCodeType3.E,
                            serialTypeSpecified = true

                        };

                        List<ProductDeploymentType2> serviceLIst = new List<ProductDeploymentType2>();
                        var dt = DataLayer_WholesaleSubscriptionDetailService.GetPpSocList(info.CSA);
                        if (info.SMSBlock == true)
                        {

                            var soc = from r in dt.AsEnumerable()
                                      where r.Field<string>("socDescription") == "MO/MT SMS BLOCKING"
                                      select r.Field<string>("soc");
                            ProductDeploymentType2 service = new ProductDeploymentType2
                            {
                                serviceCode = soc.FirstOrDefault().ToString()
                            };
                            serviceLIst.Add(service);

                        }
                        if (info.VoiceMail == true)
                        {
                            var soc = from r in dt.AsEnumerable()
                                      where r.Field<string>("socDescription") == "VOICEMAIL"
                                      select r.Field<string>("soc");
                            ProductDeploymentType2 service = new ProductDeploymentType2
                            {
                                serviceCode = soc.FirstOrDefault().ToString()
                            };
                            serviceLIst.Add(service);
                        }
                        if (info.LocalCallOnly == true)
                        {
                             var soc = from r in dt.AsEnumerable()
                                      where r.Field<string>("socDescription") == "LOCAL CALLING ONLY"
                                      select r.Field<string>("soc");
                            ProductDeploymentType2 service = new ProductDeploymentType2
                            {
                                serviceCode = soc.FirstOrDefault().ToString()
                            };
                            serviceLIst.Add(service);
                        }


                        //data blocking by default
                        ProductDeploymentType2 svc = new ProductDeploymentType2 { serviceCode = "321DISNAI" };
                        serviceLIst.Add(svc);

                        if (serviceLIst.Count > 0 )
                        {
                            request.serviceList = serviceLIst.ToArray();
                        }


                        
                        wholesaleActivateSubscriptionV2ResponseType reply = wssService.WholesaleActivateSubscriptionV2(request);

                        info.MDN = reply.mdn;
                        info.MSID = reply.msid;

                        doc = new ESNStatusDoc();
                        doc.ESN = info.ESN;
                        doc.MDN = info.MDN;
                        doc.MSID = info.MSID;
                        doc.ESNStatus = ESNSTATUSENUM.SUCCEEDED;
                        doc.Message = "Activated";
                        lstESNDoc.Add(doc);

                    }
                    catch (System.Web.Services.Protocols.SoapException soapEx)
                    {
                        doc = new ESNStatusDoc();
                        doc.ESN = info.ESN;
                        doc.ESNStatus = ESNSTATUSENUM.FAILED;
                        doc.Message = soapEx.Detail.InnerText;
                        lstESNDoc.Add(doc);
                    }
                }
                return lstESNDoc.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ActivateSubscriptionNpa(string Esn, string csa, string npa)
        {
            try
            {
                wssService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wssService.RequestSoapContext);


                ActivateSubscriptionNpaRequest asRequest = new ActivateSubscriptionNpaRequest();
                asRequest.csa = csa;
                asRequest.effectiveDate = DateTime.Now;
                asRequest.effectiveDateSpecified = true;
             
                ProductDeployment pr = new ProductDeployment();
                pr.serviceCode = "321PLAN2";
                pr.serviceEffectiveDateSpecified = true;
                pr.serviceEffectiveDate = DateTime.Now;
                pr.serviceExpirationDateSpecified = false;
                ProductDeployment pr1 = new ProductDeployment();
                pr1.serviceCode = "321MTBLK";
                pr1.serviceEffectiveDateSpecified = false;
                // pr1.serviceEffectiveDate = DateTime.Now;
                pr1.serviceExpirationDateSpecified = false;
                ElectronicSerialNumber esn = new ElectronicSerialNumber();
                esn.Item = Esn;
                esn.ItemElementName = ItemChoiceType.electronicSerialNumberDec;
                SerialNumber sn = new SerialNumber();
                sn.Item = esn;
              
                asRequest.esn = sn;
                ProductDeployment[] prList = new ProductDeployment[1];
                prList[0] = pr1;
                asRequest.npa = npa;
                asRequest.pricePlan = pr;
                ActivateSubscriptionNpaReply asReply = wssService.ActivateSubscriptionNpa(asRequest);

                Console.WriteLine("");
            }
            catch
            {
                throw;
            }
        }


        public static void ReserveSubscription(string csa)
        {
            try
            {
                wssService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wssService.RequestSoapContext);

                ReserveSubscriptionRequest rsRequest = new ReserveSubscriptionRequest();
                rsRequest.csa = csa;
                ProductDeployment wssPD = new ProductDeployment();
                wssPD.serviceCode = "321PLAN2";
                wssPD.serviceEffectiveDateSpecified = false;
                wssPD.serviceExpirationDateSpecified = false;
                rsRequest.pricePlan = wssPD;
                ReserveSubscriptionReply rsReply = wssService.ReserveSubscription(rsRequest);
                Console.WriteLine();
            }
            catch
            {
                throw;
            }
        }

        public static void ReserveSubscriptionNpa(string csa, string npa)
        {
            try
            {
                wssService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wssService.RequestSoapContext);


                ReserveSubscriptionNpaRequest rsnRequest = new ReserveSubscriptionNpaRequest();
                rsnRequest.csa = csa;


                ProductDeployment pr = new ProductDeployment();
                pr.serviceCode = "321PLAN2";
                pr.serviceEffectiveDateSpecified = true;
                pr.serviceEffectiveDate = DateTime.Now;
                pr.serviceExpirationDateSpecified = false;
                ProductDeployment pr1 = new ProductDeployment();
                pr1.serviceCode = "321MTBLK";
                pr1.serviceEffectiveDateSpecified = false;
                pr1.serviceExpirationDateSpecified = false;
                ProductDeployment[] prList = new ProductDeployment[1];
                prList[0] = pr1;
                rsnRequest.npa = npa;
                rsnRequest.pricePlan = pr;
                ReserveSubscriptionNpaReply rsnReply = wssService.ReserveSubscriptionNpa(rsnRequest);
            }
            catch
            {
                throw;
            }
        }

        public static void ReserveSubscriptionGeoCode(string csa)
        {
            try
            {
                wssService.wsMessageHeader = getHeader();
                SecurityHelper.prepareSoapContext(wssService.RequestSoapContext);


                ReserveSubscriptionGeoCodeRequest rsgcRequest = new ReserveSubscriptionGeoCodeRequest();
                rsgcRequest.csa = csa;
                PostalCode code = new PostalCode();
                code.uspsPostalCd = "66223";
                rsgcRequest.zip = code;
                ProductDeployment pr = new ProductDeployment();
                pr.serviceCode = "321PLAN2";
                pr.serviceEffectiveDateSpecified = true;
                pr.serviceEffectiveDate = DateTime.Now;
                pr.serviceExpirationDateSpecified = false;
                ProductDeployment pr1 = new ProductDeployment();
                pr1.serviceCode = "321MTBLK";
                pr1.serviceEffectiveDateSpecified = false;
                pr1.serviceExpirationDateSpecified = false;
                ProductDeployment[] prList = new ProductDeployment[1];
                prList[0] = pr1;

                rsgcRequest.pricePlan = pr;
                ReserveSubscriptionGeoCodeReply rsgcReply = wssService.ReserveSubscriptionGeoCode(rsgcRequest);
              
            }
            catch
            {
                throw;
            }
        }

    }
}
