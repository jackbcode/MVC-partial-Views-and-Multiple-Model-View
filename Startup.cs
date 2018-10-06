using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test__Connection.Startup))]
namespace Test__Connection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
