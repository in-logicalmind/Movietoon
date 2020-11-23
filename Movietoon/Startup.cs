using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movietoon.Startup))]
namespace Movietoon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
