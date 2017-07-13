using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModernHall.Startup))]
namespace ModernHall
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
