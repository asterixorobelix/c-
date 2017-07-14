using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AsterixOrObelix.Startup))]
namespace AsterixOrObelix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
