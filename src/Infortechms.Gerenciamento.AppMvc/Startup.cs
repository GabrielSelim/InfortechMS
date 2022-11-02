using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Infortechms.Gerenciamento.AppMvc.Startup))]
namespace Infortechms.Gerenciamento.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
