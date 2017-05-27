using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.ServiceInterfaces;

namespace UPTEAM.Presentation.API.Controllers
{
    [RoutePrefix("api/v1")]
    public class ProjetoController : BaseController
    {
        private IProjetoService _projetoService;
        private ITbProjetoToProjetoModelParse _parseTbProjetoToProjetoModel;
        private IProjetoModelToTbProjetoParse _parseProjetoModelToTbProjeto;

        public ProjetoController(IProjetoService projetoService, ITbProjetoToProjetoModelParse parseTbProjetoToProjetoModel,
                                IProjetoModelToTbProjetoParse parseProjetoModelToTbProjeto)
        {
            _projetoService = projetoService;
            _parseTbProjetoToProjetoModel = parseTbProjetoToProjetoModel;
            _parseProjetoModelToTbProjeto = parseProjetoModelToTbProjeto;
        }

        [HttpGet]
        [Authorize]
        [Route("projeto")]
        public Task<HttpResponseMessage> BuscarPorNome(string nomeProjeto)
        {
            try
            {
                var projetoTb = _projetoService.BuscarPorNome(nomeProjeto).ToList();
                if (projetoTb != null)
                {
                    var projetoVM = _parseTbProjetoToProjetoModel.Parse(projetoTb);

                    return CreateResponse(HttpStatusCode.OK, projetoVM, null);
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
        [Route("equipe/{idEquipe:int}/projeto")]
        public Task<HttpResponseMessage> BuscarPorEquipe(int idEquipe)
        {
            try
            {
                var projetoTb = _projetoService.BuscarPorEquipe(idEquipe).ToList();
                if (projetoTb != null)
                {
                    var projetoVM = _parseTbProjetoToProjetoModel.Parse(projetoTb);

                    return CreateResponse(HttpStatusCode.OK, projetoVM, null);
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