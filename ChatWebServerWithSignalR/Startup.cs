using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatWebServerWithSignalR.Startup))]
namespace ChatWebServerWithSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
