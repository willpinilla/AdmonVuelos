using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdmonVuelos.Startup))]
namespace AdmonVuelos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
