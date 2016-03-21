using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaKardexInventario.UI.Startup))]
namespace SistemaKardexInventario.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
