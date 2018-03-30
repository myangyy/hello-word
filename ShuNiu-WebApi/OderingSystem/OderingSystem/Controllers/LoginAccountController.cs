using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using OderingSystem.Models;
using Microsoft.Data.OData;
using OderingSystem.Context;
using OderingSystem.Service;
using OderingSystem.Common;
using System.Web.OData;

namespace OderingSystem.Controllers
{
    public class LoginAccountController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();
        private ILoginService _LoginService;
        private ILoginService LoginService
        {
            get
            {
                if (_LoginService == null)
                {
                    ActorRuntimeWithCastle container = ActorRuntimeWithCastle.CreateInstance(AppDomain.CurrentDomain.BaseDirectory + @"\Config\component.config");
                    _LoginService = container.Resolve<ILoginService>("LoginService");
                }
                return _LoginService;
            }
        }


        [HttpPost]
        [EnableQuery]
        public int QueryAccount(ODataActionParameters parameters)
        {
            int result = 0;
            try
            {
                if (ModelState.IsValid)
                {
                    ShuNiuContext context = SingleShuNiuContext.CreateInstance().Get();
                    var account = (AccountEntry)parameters["account"];
                    result = (int)LoginService.Lgoin(account, context).LoginResult;
                    return result;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
            return 0;
        }
    }
}
