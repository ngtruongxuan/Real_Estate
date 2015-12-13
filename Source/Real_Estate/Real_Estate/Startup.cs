using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Real_Estate.Startup))]
namespace Real_Estate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
