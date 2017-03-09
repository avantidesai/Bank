using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankMVC.Startup))]
namespace BankMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
