using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FutureNet.Startup))]
namespace FutureNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
