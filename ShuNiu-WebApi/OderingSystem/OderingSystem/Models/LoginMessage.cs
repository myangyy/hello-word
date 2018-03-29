using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OderingSystem.Models
{
    [Serializable]
    [DataContract]
    public class LoginMessage
    {
        [DataMember]
        public string HomeUrl { get; set; }
        [DataMember]
        public LoginResult LoginResult { get; set; }
        [DataMember]
        public string Message { get; set; }
    }

    public enum LoginResult
    {
        LoginSuccess = 0,
        LoginFailed = 1,
        SuperAdminLogin = 2,
        AdminLogin = 3,
        UserLogin = 4
    }

}