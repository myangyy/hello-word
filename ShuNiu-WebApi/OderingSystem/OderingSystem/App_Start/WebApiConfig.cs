using OderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace OderingSystem
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Account
            var builder = new ODataConventionModelBuilder();
            var entityCOnfig = builder.EntitySet<AccountEntry>("LoginAccount");
            builder.Namespace = "AccountService";
            builder.EntityType<AccountEntry>()
                .Action("QueryAccount")
                .Parameter<AccountEntry>("account");
          

            config.MapODataServiceRoute(
               routeName: "odata",
               routePrefix: "odata",
               model: builder.GetEdmModel()
               );
        }
    }
}
