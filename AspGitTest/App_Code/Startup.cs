using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspGitTest.Startup))]
namespace AspGitTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
