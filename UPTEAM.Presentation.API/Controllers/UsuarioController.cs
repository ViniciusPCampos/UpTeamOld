using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.API.Controllers
{
    [RoutePrefix("api/v1")]
    public class UsuarioController : BaseController
    {
        public HttpResponseMessage ResponseMessage;

        private readonly IUsuarioService _usuarioService;

        private readonly ITbUsuarioToUsuarioModelParse _usuariotbParse;
        private readonly IUsuarioModelToTbUsuarioParse _usuarioParse;

        public UsuarioController(IUsuarioService usuarioService, ITbUsuarioToUsuarioModelParse usuariotbParse, IUsuarioModelToTbUsuarioParse usuarioParse)
        {
            _usuarioService = usuarioService;

            _usuariotbParse = usuariotbParse;
            _usuarioParse = usuarioParse;
        }
        // GET: User
        [HttpPost]
        [Route("user")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var usuarioRegister = new UsuarioModel()
            {
                Nome = (string)body.login,
                Telefone = (string)body.telefone,
                Login = (string)body.login,
                Password = (string)body.password

            };
            var jsonResult = new JsonResult<UsuarioModel>();
            var usuarioTb = _usuarioParse.Parse(usuarioRegister);

            jsonResult.Src = _usuariotbParse.Parse(_usuarioService.Register(usuarioTb));

            return CreateResponse(HttpStatusCode.Created, jsonResult);
        }
    }
}