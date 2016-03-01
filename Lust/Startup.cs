using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lust.Startup))]
namespace Lust
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
