using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RWD_Project.Startup))]
namespace RWD_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
