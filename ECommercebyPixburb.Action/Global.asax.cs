using ECommercebyPixburb.Action.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ECommercebyPixburb.Action
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ContainerConfig.Initialize();
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
