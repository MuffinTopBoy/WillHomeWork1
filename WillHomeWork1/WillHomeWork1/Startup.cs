using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WillHomeWork1.Startup))]
namespace WillHomeWork1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
