using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentricConsultingProject.Startup))]
namespace CentricConsultingProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
