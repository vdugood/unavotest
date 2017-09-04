using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace DomainObjects
{
    [DataContract]
    public enum ActivationTypeEnum : int
    {
        [EnumMember]
        OVER_THE_AIR=100000,
        [EnumMember]
        MANUAL = 100001,
        [EnumMember]
        SHIPPED_ACTIVATED= 100002,
        [EnumMember]
        SCHEDULED_ACTIVATION = 100003,
        [EnumMember]
        ONLINE_REFRESH = 100004,
        [EnumMember]
        BATCH_REFRESH= 100005,
        [EnumMember]
        BATCH_ACTIVATION =   100006,
        [EnumMember]
        ONLINE_ACTIVATION = 100007,
        [EnumMember]
        ONLINE_CANCELLATION = 100008,
        [EnumMember]
        OUT_OF_TIME = 100009,
        [EnumMember]
        ONLINE_SUSPESION = 100010,
        [EnumMember]
        ONLINE_RESTORE= 100011,
        [EnumMember]
        ONLINE_SWAP_MDN=100017,
        [EnumMember]
        ONLINE_SWAP_ESN = 100019
    }

    [DataContract]
    public enum EsnType
    {
        [EnumMember]
        Hex,
        [EnumMember]
        Dec
    }
}
