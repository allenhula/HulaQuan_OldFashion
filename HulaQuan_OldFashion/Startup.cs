using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HulaQuan_OldFashion.Startup))]
namespace HulaQuan_OldFashion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
