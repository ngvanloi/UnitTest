using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnitTesst.Startup))]
namespace UnitTesst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
