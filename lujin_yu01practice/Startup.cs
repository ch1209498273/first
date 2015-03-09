using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lujin_yu01practice.Startup))]
namespace lujin_yu01practice
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
