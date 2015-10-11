using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Goliat.Startup))]
namespace Goliat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
