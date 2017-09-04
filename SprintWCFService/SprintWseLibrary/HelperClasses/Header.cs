using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SprintWseLibrary.HelperClasses
{
    class Header
    {
        public string applicationId { get; set; }
        public string applicationUserId { get; set; }
        public string messageId { get; set; }
        public string timeToLive { get; set; }              
    }
}
