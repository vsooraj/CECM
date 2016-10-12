using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CECM.Web.Startup))]
namespace CECM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
