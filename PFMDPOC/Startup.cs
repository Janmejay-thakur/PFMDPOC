using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PFMDPOC.Startup))]
namespace PFMDPOC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
