using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SprintWseLibrary.com.sprint.WholesaleQueryCsaService;
using Microsoft.Web.Services3;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Web.Services3.Security.Tokens;
using Microsoft.Web.Services3.Security;

namespace SprintWseLibrary.HelperClasses
{
    class SecurityHelper
    {

        public static X509Certificate2 GetCertificate()
        {
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            //X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser); //works
            store.Open(OpenFlags.ReadOnly);
            X509Certificate2Collection certColl = new X509Certificate2Collection();
            /* Retrieve a certificate by subject name from the Local Machine store. */
            certColl = store.Certificates;
            X509Certificate2 ucert = new X509Certificate2();

            

            foreach (X509Certificate2 cert in certColl)
            {
                // Replace with the SubjectName of the client certificate
                if (cert.SubjectName.Name == global::SprintWseLibrary.Properties.Settings.Default.userCertificateName)
                {
                    ucert = cert;
                    break;
                }

            }
            return ucert;
        }

        //get certificate and attach it
        public static void prepareSoapContext(SoapContext soapContext)
        {
            X509Certificate2 ucert = GetCertificate();
            X509SecurityToken cerToken = new X509SecurityToken(ucert);
            
                MessageSignature cerSig = new MessageSignature(cerToken);
                soapContext.Security.Elements.Add(cerSig);
           
            
            // requestContext.Security.Tokens.Add(cerToken);
           
        }
    }


}
