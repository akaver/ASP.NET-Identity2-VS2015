using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.WebApi.Startup))]
namespace Web.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
