using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Power_BI_Survey.Startup))]
namespace Power_BI_Survey
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
