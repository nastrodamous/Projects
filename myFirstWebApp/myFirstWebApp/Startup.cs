using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myFirstWebApp.Startup))]
namespace myFirstWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
