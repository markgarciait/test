using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebToTest.Startup))]
namespace WebToTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
