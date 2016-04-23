using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(paulmemoryboxService.Startup))]

namespace paulmemoryboxService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}