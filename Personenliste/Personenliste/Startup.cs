using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Personenliste.Startup))]
namespace Personenliste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
