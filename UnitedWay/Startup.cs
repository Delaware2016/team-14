using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnitedWay.Startup))]
namespace UnitedWay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
