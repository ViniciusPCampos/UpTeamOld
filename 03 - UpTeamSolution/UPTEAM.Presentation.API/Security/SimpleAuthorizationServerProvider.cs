using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;
using UPTEAM.Domain.Interfaces;
using UPTEAM.Infra.Data.Repositories;

namespace UPTEAM.Presentation.API.Security
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            using (IUsuarioRepository _repository = new UsuarioRepository())
            {
                var user = _repository.Authenticate(context.UserName, context.Password);

                if (user == null)
                {
                    context.SetError("invelid_grant", "O login ou a senha estão incorretos.");
                    return;
                }
            }
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("sub", context.UserName));
            identity.AddClaim(new Claim("role", "user"));

            context.Validated(identity);
        }
    }
}