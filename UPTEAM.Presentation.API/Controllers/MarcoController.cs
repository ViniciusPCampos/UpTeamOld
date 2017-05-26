using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.ServiceInterfaces;

namespace UPTEAM.Presentation.API.Controllers
{
    [RoutePrefix("api/v1")]
    public class MarcoController : BaseController
    {
        private IMarcoService _marcoService;
        private ITbMarcoToMarcoModelParse _parseTbMarcoToMarcoModel;
        private IMarcoModelToTbMarcoParse _parseMarcoModelToTbModel;

        public MarcoController(IMarcoService marcoService, ITbMarcoToMarcoModelParse parseTbMarcoToMarcoModel,
                               IMarcoModelToTbMarcoParse parseMarcoModelToTbModel)
        {
            _marcoService = marcoService;
            _parseTbMarcoToMarcoModel = parseTbMarcoToMarcoModel;
            _parseMarcoModelToTbModel = parseMarcoModelToTbModel;
        }

        [HttpGet]
        [Authorize]
        [Route("marco/{id:int}")]
        public Task<HttpResponseMessage> BuscarMarco(int id)
        {
            try
            {
                var marcoTb = _marcoService.BuscarMarco(id);
                if(marcoTb != null)
                {
                    var marcoVM = _parseTbMarcoToMarcoModel.Parse(marcoTb);

                    return CreateResponse(HttpStatusCode.OK, marcoVM, null);
                }

                return CreateResponse(HttpStatusCode.NotFound, null, null);
            } catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.BadRequest, null, null);
            }
        }

        [HttpGet]
        [Authorize]
        [Route("projeto/{idProjeto:int}/marco")]
        public Task<HttpResponseMessage> BuscaPorProjeto(int idProjeto)
        {
            try
            {
                var marcoTb = _marcoService.BuscarPorProjeto(idProjeto).ToList();
                if(marcoTb != null)
                {
                    var marcoVM = _parseTbMarcoToMarcoModel.Parse(marcoTb);

                    return CreateResponse(HttpStatusCode.OK, marcoTb, null);
                }

                return CreateResponse(HttpStatusCode.NotFound, null, null);
            } catch(Exception ex)
            {
                return CreateResponse(HttpStatusCode.BadRequest, null, null);
            }
        }


    }
}