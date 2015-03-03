using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comida_Web_App.Startup))]
namespace Comida_Web_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          
        }
    }
}
