using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SE_CMS_PROJECT.Startup))]
namespace SE_CMS_PROJECT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
