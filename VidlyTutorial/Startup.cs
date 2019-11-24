using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyTutorial.Startup))]
namespace VidlyTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
