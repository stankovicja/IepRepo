using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IepProject.Startup))]
namespace IepProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
