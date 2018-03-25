using Owin;
using Saule.Http;
using System.Web.Http;

namespace SauleStarter
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.ConfigureJsonApi();
            app.UseWebApi(config);
        }
    }
}