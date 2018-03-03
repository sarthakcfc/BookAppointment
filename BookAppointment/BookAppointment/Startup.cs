using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookAppointment.Startup))]
namespace BookAppointment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
