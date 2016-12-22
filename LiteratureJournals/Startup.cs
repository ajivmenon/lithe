using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiteratureJournals.Startup))]
namespace LiteratureJournals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
