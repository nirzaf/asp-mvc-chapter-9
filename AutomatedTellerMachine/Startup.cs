using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomatedTellerMachine.Startup))]
namespace AutomatedTellerMachine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
