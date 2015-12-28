using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Agenda.UI.Mvc.Startup))]
namespace Agenda.UI.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
