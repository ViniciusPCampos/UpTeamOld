using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UPTEAM.Domain.ServiceInterfaces;

namespace UPTEAM.Presentation.API.Controllers
{
    [RoutePrefix("api/v1")]
    public class UsuarioController : BaseController
    {
        private IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpGet]
        [Authorize]
        [Route("usuario/perfil")]
        public Task<HttpResponseMessage> BuscarPerfilUsuario()
        {
            try
            {
                var usuarioPerfil = _usuarioService.ObterPerfilUsuario(ObterUsuarioLogado());

                if (usuarioPerfil != null)
                {
                    return CreateResponse(HttpStatusCode.OK, usuarioPerfil, null);
                }

                return CreateResponse(HttpStatusCode.NotFound, null, null);
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.BadRequest, null, null);
            }
        }
    }
}
