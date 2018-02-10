using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmpTask.Startup))]
namespace EmpTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
