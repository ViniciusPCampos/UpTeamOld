using Owin;
using UPTEAM.Presentation.Web;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace UPTEAM.Presentation.Web
{

    public partial class Startup
    {
        public  void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}