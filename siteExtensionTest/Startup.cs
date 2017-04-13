using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(siteExtensionTest.Startup))]
namespace siteExtensionTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
