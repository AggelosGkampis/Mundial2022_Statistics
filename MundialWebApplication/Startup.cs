using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MundialWebApplication.Startup))]
namespace MundialWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
