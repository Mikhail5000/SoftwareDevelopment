using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCreditApp3.Startup))]
namespace MvcCreditApp3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
