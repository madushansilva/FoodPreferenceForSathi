using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodPreference.Startup))]
namespace FoodPreference
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
