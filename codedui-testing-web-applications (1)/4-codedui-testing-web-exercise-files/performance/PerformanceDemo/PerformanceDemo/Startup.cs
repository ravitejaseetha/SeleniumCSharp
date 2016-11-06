using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PerformanceDemo.Startup))]
namespace PerformanceDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
