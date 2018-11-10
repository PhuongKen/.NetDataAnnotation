using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataAnnotations.Startup))]
namespace DataAnnotations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
