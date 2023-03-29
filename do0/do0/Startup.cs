using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(do0.Startup))]
namespace do0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
