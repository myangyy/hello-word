using OderingSystem.Common;
using OderingSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace OderingSystem
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            SingleShuNiuContext context = SingleShuNiuContext.CreateInstance();
            ShuNiuContext sn = new ShuNiuContext();
            if (context.Get()==null)
            {
                context.Set(sn);
            }
            GlobalConfiguration.Configure(WebApiConfig.Register);
            DataUtil.InitSuperAdmin(context.Get());
        }
    }
}
