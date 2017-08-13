using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidlyyyy.Startup))]
namespace Vidlyyyy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
