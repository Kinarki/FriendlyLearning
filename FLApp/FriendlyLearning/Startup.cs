using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FriendlyLearning.Startup))]
namespace FriendlyLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
