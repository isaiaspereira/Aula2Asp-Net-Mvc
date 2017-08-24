using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAula2.Startup))]
namespace WebAppAula2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
