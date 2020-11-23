using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.Owin.Host.SystemWeb;

[assembly: OwinStartup(typeof(Jeremy.SignalR.Server.Startup))]

namespace Jeremy.SignalR.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888

            // 配置集线器
            app.MapSignalR();
        }
    }
}
