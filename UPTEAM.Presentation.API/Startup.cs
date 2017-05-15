using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UPTEAM.Presentation.API.Security;

namespace UPTEAM.Presentation.API
{
    public class Startup
    {
        private SimpleAuthorizationServerProvider _simpleAuthorizationServerProvider;
        public Startup(SimpleAuthorizationServerProvider simpleAuthorizationServerProvider)
        {
            _simpleAuthorizationServerProvider = simpleAuthorizationServerProvider;
        }
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            // Ativar o método para gerar o OAuth Token
            app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions()
            {
                TokenEndpointPath = new PathString("/Token"),
                Provider = _simpleAuthorizationServerProvider,
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                AllowInsecureHttp = true
            });
        }
    }
}