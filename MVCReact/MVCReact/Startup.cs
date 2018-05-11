using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCReact.Startup))]
namespace MVCReact
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
