using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RobotAPIs.Startup))]
namespace RobotAPIs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
