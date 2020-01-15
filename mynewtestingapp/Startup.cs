using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mynewtestingapp.Startup))]
namespace mynewtestingapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
