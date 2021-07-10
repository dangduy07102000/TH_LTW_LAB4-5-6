using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB04_DANGNGUYENHOAIDUY.Startup))]
namespace LAB04_DANGNGUYENHOAIDUY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
