using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SelfTestWebForm.Startup))]
namespace SelfTestWebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
