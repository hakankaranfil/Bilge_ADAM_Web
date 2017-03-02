using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_First.Startup))]
namespace MVC_First
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
