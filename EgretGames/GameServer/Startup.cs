using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(GameServer.Startup))]

namespace GameServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888

            var config = new HubConfiguration();
            config.EnableJSONP = true;
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR(config);
        }
    }
}
