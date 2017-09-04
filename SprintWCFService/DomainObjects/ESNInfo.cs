using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace DomainObjects
{

    [DataContract]
    public class ESNInfo
    {
        string m_ESN = "";
        string m_CSA = "";
        string m_msid = "";
        string m_mdn = "";
        bool m_LocalCallOnly = false;
        bool m_VoiceMail = false;
        bool m_SMSBlock = false;
        int m_ActivationtypeId = 0;

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
        public string CSA
        {
            get
            {
                return m_CSA;
            }
            set
            {
                m_CSA = value;
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
        public bool LocalCallOnly
        {
            get
            {
                return m_LocalCallOnly;
            }
            set
            {
                m_LocalCallOnly = value;
            }
        }

        [DataMember]
        public bool VoiceMail
        {
            get
            {
                return m_VoiceMail;
            }
            set
            {
                m_VoiceMail = value;
            }
        }

        [DataMember]
        public bool SMSBlock
        {
            get
            {
                return m_SMSBlock;
            }
            set
            {
                m_SMSBlock = value;
            }
        }

        [DataMember]
        public int ActivationtypeId
        {
            get
            {
                return m_ActivationtypeId;
            }
            set
            {
                m_ActivationtypeId = value;
            }
        }
    }
}
