using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Videe.Startup))]
namespace Videe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
