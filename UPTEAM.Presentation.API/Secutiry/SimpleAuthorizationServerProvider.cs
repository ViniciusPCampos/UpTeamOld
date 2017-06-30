using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using UPTEAM.Domain.ServiceInterfaces;

namespace UPTEAM.Presentation.API.Secutiry
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        private IUsuarioService _usuarioService;
        public SimpleAuthorizationServerProvider(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            try
            {
                var user = _usuarioService.Authenticate(context.UserName, context.Password);
                if (user == null)
                {
                    context.SetError("invalid_grant", "O login ou a senha estão incorretos.");
                    return;
                }

                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                
                identity.AddClaim(new Claim("sub", context.UserName));
                identity.AddClaim(new Claim("role", "user"));
                identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));

                context.Validated(identity);
            }
            catch (Exception ex)
            {

                context.SetError("invalid_request", "Requisição invalida.");
            }
        }
    }
}