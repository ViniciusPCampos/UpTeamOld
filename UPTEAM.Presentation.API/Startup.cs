using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Ninject;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Presentation.API.Security;

namespace UPTEAM.Presentation.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            IKernel kernel = new StandardKernel();
            IoC.DependenceResolver.Resolver(kernel);
            ConfigureAuth(app, kernel.Get<IUsuarioService>());
        }
        public void ConfigureAuth(IAppBuilder app, IUsuarioService userService)
        {
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            // Ativar o método para gerar o OAuth Token
            app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions()
            {
                TokenEndpointPath = new PathString("/Token"),
                Provider = new SimpleAuthorizationServerProvider(userService),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                AllowInsecureHttp = true
            });
        }
    }
}