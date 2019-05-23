using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarbisanBruegger.Startup))]
namespace BarbisanBruegger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
