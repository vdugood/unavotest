using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace DomainObjects
{
    [DataContract]
    public enum ESNSTATUSENUM
    {
        [EnumMember]
        NONE=0,
        [EnumMember]
        SUCCEEDED =1,
        [EnumMember]
        FAILED = 2
    }

    [DataContract]
    public enum NumberType
    {
        [EnumMember]
        ESN,
        [EnumMember]
        MDN,
        [EnumMember]
        Invalid
    }

    [DataContract]
    public class ESNStatusDoc
    {
        string m_ESN = "";
        string m_msid = "";
        string m_mdn = "";
        string m_Message = "";
        ESNSTATUSENUM m_esnstatus = ESNSTATUSENUM.NONE;

        [DataMember]
        public string ESN
        {
            get
            {
                return m_ESN;
            }
            set
            {
                m_ESN = value;
            }
        }

        [DataMember]
        public string MSID
        {
            get
            {
                return m_msid;
            }
            set
            {
                m_msid = value;
            }
        }

        [DataMember]
        public string MDN
        {
            get
            {
                return m_mdn;
            }
            set
            {
                m_mdn = value;
            }
        }

        [DataMember]
        public string Message
        {
            get
            {
                return m_Message;
            }
            set
            {
                m_Message = value;
            }
        }

        [DataMember]
        public ESNSTATUSENUM ESNStatus
        {
            get
            {
                return m_esnstatus;
            }
            set
            {
                m_esnstatus = value;
            }
        }
    }
}
