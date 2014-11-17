using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Knith_Horizon.Startup))]
namespace Knith_Horizon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
