using System;
using System.Collections.Generic;
using System.Linq;
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

        private ITbEquipeToEquipeModelParse _equipeParse;

        public EquipeController(IEquipeService equipeService, ITbEquipeToEquipeModelParse equipeParse)
        {
            _equipeService = equipeService;
            _equipeParse = equipeParse;
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
    }
}
