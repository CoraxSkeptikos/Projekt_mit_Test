using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(meinUmfrageTool.Startup))]
namespace meinUmfrageTool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
