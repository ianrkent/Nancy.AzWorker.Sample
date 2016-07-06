using Nancy.Owin;
using Owin;

namespace Nancy.Worker.Owin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy(new NancyOptions { });
        }
    }
}