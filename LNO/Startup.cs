using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LNO.Startup))]
namespace LNO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
