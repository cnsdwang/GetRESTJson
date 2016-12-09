using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetRESTJson.Startup))]
namespace GetRESTJson
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
