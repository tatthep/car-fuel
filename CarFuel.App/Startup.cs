using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarFuel.App.Startup))]
namespace CarFuel.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
