using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RWA_FinalProject.Startup))]
namespace RWA_FinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
