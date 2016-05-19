using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeLearningMVC.Startup))]
namespace MeLearningMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
