using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ABCLeagueMSService.Startup))]

namespace ABCLeagueMSService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}