using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Instance.Run("WebApplication", 7055);
            Instance.Application.Browser.Manage().Window.Maximize();
            Thread.Sleep(5000);
            //new code changes 

            //Instance.Run("WebApplication", 54881, configure => configure.WithRouteConfig(WebApplication.RouteConfig.RegisterRoutes).WithMinimumWaitTimeoutOf(System.TimeSpan.FromSeconds(3)));

        }
    }
}
