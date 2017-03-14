using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstTestApp.Startup))]
namespace FirstTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
