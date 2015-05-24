using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.EF.Startup))]
namespace Web.EF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
