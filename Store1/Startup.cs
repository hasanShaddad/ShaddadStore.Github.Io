using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Store1.Startup))]
namespace Store1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
