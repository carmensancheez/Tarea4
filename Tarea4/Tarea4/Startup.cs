using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tarea4.Startup))]
namespace Tarea4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
