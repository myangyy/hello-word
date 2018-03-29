using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using OderingSystem.Models;
using Microsoft.Data.OData;
using OderingSystem.Context;
using OderingSystem.Service;
using OderingSystem.Common;

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

        // GET: odata/GetAccount
        public IHttpActionResult GetAccount(ODataQueryOptions<AccountEntry> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/GetAccount(5)
        public IHttpActionResult GetAccount([FromODataUri] string key, ODataQueryOptions<AccountEntry> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/Account(5)
        public IHttpActionResult Put([FromODataUri] string key, Delta<AccountEntry> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Account
        public IHttpActionResult Post(AccountEntry accountEntry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/AccountGetAccount(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] string key, Delta<AccountEntry> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Account(5)
        public IHttpActionResult Delete([FromODataUri] string key)
        {
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        [HttpPost]
        [EnableQuery]
        public bool QueryAccount(AccountEntry account)
        {
            bool result = false;
            ShuNiuContext context = SingleShuNiuContext.CreateInstance().Get();
            LoginService.Lgoin(account, context);
            return result;
        }
    }
}
