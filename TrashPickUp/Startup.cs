using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashPickUp.Startup))]
namespace TrashPickUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
