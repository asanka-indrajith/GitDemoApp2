using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitDemoApp.Startup))]
namespace GitDemoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
