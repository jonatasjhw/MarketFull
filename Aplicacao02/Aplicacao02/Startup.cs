using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aplicacao02.Startup))]
namespace Aplicacao02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
