using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hangman_test.Startup))]
namespace Hangman_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
