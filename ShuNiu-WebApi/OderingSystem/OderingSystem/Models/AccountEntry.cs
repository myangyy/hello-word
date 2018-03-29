using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OderingSystem.Models
{
    [DataContract]
    public class AccountEntry
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string RoleId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string ChineseName { get; set; }
        [DataMember]
        public string PassWord { get; set; }
    }
}