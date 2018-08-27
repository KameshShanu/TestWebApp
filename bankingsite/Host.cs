using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.Configuration;
using TestStack.Seleno.Configuration.WebServers;
using WebApplication;

namespace bankingsite
{
    public static class Host
    {
        public static readonly SelenoHost Instance;

        static Host()
        {
            Instance = new SelenoHost();
            Instance.Run("WebApplication", 54881);
            Instance.Application.Browser.Manage().Window.Maximize();

            //new code changes 

            //Instance.Run("WebApplication", 54881, configure => configure.WithRouteConfig(WebApplication.RouteConfig.RegisterRoutes).WithMinimumWaitTimeoutOf(System.TimeSpan.FromSeconds(3)));

        }
    }
}
