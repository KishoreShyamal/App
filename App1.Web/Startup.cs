using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App1.Web.Startup))]
namespace App1.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
