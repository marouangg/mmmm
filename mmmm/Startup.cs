using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mmmm.Startup))]
namespace mmmm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ///////
        }
    }
}
