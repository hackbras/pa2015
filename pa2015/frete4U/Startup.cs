using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(frete4U.Startup))]
namespace frete4U
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
