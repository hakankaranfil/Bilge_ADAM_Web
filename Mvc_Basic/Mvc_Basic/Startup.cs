using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_Basic.Startup))]
namespace Mvc_Basic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
