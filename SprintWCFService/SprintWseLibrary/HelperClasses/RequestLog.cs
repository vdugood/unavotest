using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Common;
using System.Data;
using System.Xml.Serialization;
using System.Xml;

namespace SprintWseLibrary.HelperClasses
{
    class RequestLog
    {


        public static void LogRequestResponse(object Request, object Reply, Type requestObjectType, Type replyObjectType)
        {

            XmlSerializer requestSerializer = new XmlSerializer(requestObjectType);
            XmlDocument RequestXmlDoc = new XmlDocument();
            
            

          // requestSerializer.Serialize(RequestXmlDoc.w)
            


        }


        Database db = EnterpriseLibraryContainer.Current.GetInstance<Database>(
                                       "SprintDatabase");

      




















    }
}
