using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace DomainObjects
{
    [DataContract]
    public class Address
    {
        int m_AddressId = 0;
        int m_AddressTypeId = 0;
        string m_Address1 = "";
        string m_Address2 = "";
        string m_City = "";
        string m_StateType = "";
        string m_ZipCode = "";
        string m_SourceField = "";
        int m_SourceId = 0;
        string m_FirstName = "";
        string m_MiddleInitial="";
        string m_LastName = "";
        string m_Title = "";

        [DataMember]
        public int AddressId
        {
            get
            {
                return m_AddressId;
            }
            set
            {
                m_AddressId = value;
            }
        }

        [DataMember]
        public int AddressTypeId
        {
            get
            {
                return m_AddressTypeId;
            }
            set
            {
                m_AddressTypeId = value;
            }
        }

        [DataMember]
        public string StateType
        {
            get
            {
                return m_StateType;
            }
            set
            {
                m_StateType = value;
            }
        }

        [DataMember]
        public string Address1
        {
            get
            {
                return m_Address1;
            }
            set
            {
                m_Address1 = value;
            }
        }

        [DataMember]
        public string Address2
        {
            get
            {
                return m_Address2;
            }
            set
            {
                m_Address2 = value;
            }
        }

        [DataMember]
        public string City
        {
            get
            {
                return m_City;
            }
            set
            {
                m_City = value;
            }
        }

        [DataMember]
        public string ZipCode
        {
            get
            {
                return m_ZipCode;
            }
            set
            {
                m_ZipCode = value;
            }
        }

        [DataMember]
        public string SourceField
        {
            get
            {
                return m_SourceField;
            }
            set
            {
                m_SourceField = value;
            }
        }

        [DataMember]
        public int SourceId
        {
            get
            {
                return m_SourceId;
            }
            set
            {
                m_SourceId = value;
            }
        }

        [DataMember]
        public string FirstName
        {
            get
            {
                return m_FirstName;
            }
            set
            {
                m_FirstName = value;
            }
        }

        [DataMember]
        public string MiddleInitial
        {
            get
            {
                return m_MiddleInitial;
            }
            set
            {
                m_MiddleInitial = value;
            }
        }

        [DataMember]
        public string LastName
        {
            get
            {
                return m_LastName;
            }
            set
            {
                m_LastName = value;
            }
        }

        [DataMember]
        public string Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }
    
    }
}
