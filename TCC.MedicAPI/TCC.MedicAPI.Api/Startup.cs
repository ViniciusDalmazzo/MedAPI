using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using TCC.MedicAPI.Api.Providers;

[assembly: OwinStartup(typeof(TCC.MedicAPI.Api.Startup))]

namespace TCC.MedicAPI.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureOAuth(app);
            WebApiConfig.Register(config);
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions oAuthOption = new OAuthAuthorizationServerOptions
            {
                // Nunca deixar 'true' em um ambiente de produção, será necessário criar certificado para WEB Api
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(1),
                Provider = new AuthServerProvider()
            };

            app.UseOAuthAuthorizationServer(oAuthOption);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
