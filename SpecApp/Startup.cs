using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpecApp.Startup))]
namespace SpecApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
