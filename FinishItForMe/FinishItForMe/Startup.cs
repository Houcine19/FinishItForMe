using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinishItForMe.Startup))]
namespace FinishItForMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
