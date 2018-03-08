using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThelightHotel.Startup))]
namespace ThelightHotel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
