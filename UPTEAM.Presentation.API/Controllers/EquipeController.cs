using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UPTEAM.AutoMapper.Parses;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.ServiceInterfaces;

namespace UPTEAM.Presentation.API.Controllers
{
    [RoutePrefix("api/v1")]
    public class EquipeController : BaseController
    {
        private IEquipeService _equipeService;
        private IUsuarioService _usuarioService;

        private ITbEquipeToEquipeModelParse _equipeParse;
        private ITbUsuarioToUsuarioModelParse _usuarioParse;

        public EquipeController(IEquipeService equipeService, ITbEquipeToEquipeModelParse equipeParse, IUsuarioService usuarioService, ITbUsuarioToUsuarioModelParse usuarioParse)
        {
            _equipeService = equipeService;
            _usuarioService = usuarioService;

            _equipeParse = equipeParse;
            _usuarioParse = usuarioParse;
        }

        [HttpGet]
        [Authorize]
        [Route("equipe")]
        public Task<HttpResponseMessage> BuscarPorNome(string nome)
        {
            try
            {
                var equipeTb = _equipeService.BuscarEquipePorNome(nome);
                if (equipeTb != null)
                {
                    
                    var equipeVM = _equipeParse.Parse(equipeTb);

                    return CreateResponse(HttpStatusCode.OK, equipeVM, null);
                }

                return CreateResponse(HttpStatusCode.NotFound, null, null);
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.BadRequest, null, null);
            }
        }
        [HttpGet]
        [Authorize]
        [Route("equipes")]
        public Task<HttpResponseMessage> BuscarEquipesPorUsuario()
        {
            try
            {
                var usuario = _usuarioService.ObterUsuarioPorLogin(ObterUsuarioLogado());
                var equipeTb = _equipeService.BuscarEquipesPorUsuario(usuario);
                if (equipeTb != null)
                {

                    var equipeVM = _equipeParse.Parse(equipeTb);

                    return CreateResponse(HttpStatusCode.OK, equipeVM, null);
                }

                return CreateResponse(HttpStatusCode.NotFound, null, null);
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.BadRequest, null, null);
            }
        }
        [HttpGet]
        [Authorize]
        [Route("equipes/{id:int}/usuarios")]
        public Task<HttpResponseMessage> BuscarUsuariosEquipe(int id)
        {
            try
            {
                var usuarios = _equipeService.BuscarUsuariosEquipe(id);
                if (usuarios != null)
                {

                    var usuariosVM = _usuarioParse.Parse(usuarios);

                    return CreateResponse(HttpStatusCode.OK, usuariosVM, null);
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
