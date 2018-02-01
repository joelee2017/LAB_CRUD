using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB_CRUD.Startup))]
namespace LAB_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
