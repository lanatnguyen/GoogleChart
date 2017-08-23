using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleChart.Startup))]
namespace GoogleChart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
