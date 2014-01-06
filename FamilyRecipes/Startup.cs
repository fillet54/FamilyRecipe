using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FamilyRecipes.Startup))]
namespace FamilyRecipes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
