using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mid4.Startup))]
namespace mid4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
