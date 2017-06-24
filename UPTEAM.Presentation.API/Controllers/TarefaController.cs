using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.API.Controllers
{
    [RoutePrefix("api/v1")]
    public class TarefaController : BaseController
    {

        private ITarefaService _tarefaService;
        private ITbTarefaToTarefaModelParse _parseTbTarefaToTarefaModel;
        private ITarefaModelToTbTarefaParse _parseTarefaModelToTbTarefa;
        public TarefaController(ITarefaService tarefaService, ITbTarefaToTarefaModelParse parseTbTarefaToTarefaModel, ITarefaModelToTbTarefaParse parseTarefaModelToTbTarefa)
        {
            _tarefaService = tarefaService;
            _parseTbTarefaToTarefaModel = parseTbTarefaToTarefaModel;
            _parseTarefaModelToTbTarefa = parseTarefaModelToTbTarefa;
        }
        [HttpGet]
        [Authorize]
        [Route("tarefa/{id:int}")]
        public Task<HttpResponseMessage> BuscarTarefa(int id)
        {
            try
            {
                var tarefaTb = _tarefaService.BuscarTarefa(id);
                if (tarefaTb != null)
                {
                    // Parse de TB_TAREFA para TarefaModel
                    var tarefaVM = _parseTbTarefaToTarefaModel.Parse(tarefaTb);

                    return CreateResponse(HttpStatusCode.OK, tarefaVM, null);
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
        [Route("sprint/{id:int}/tarefa")]
        public Task<HttpResponseMessage> BuscarPorSprint(int id)
        {
            try
            {
                var tarefaTb = _tarefaService.BuscarTarefasPorSprint(id);
                if (tarefaTb != null)
                {
                    
                    var tarefaVM = _parseTbTarefaToTarefaModel.Parse(tarefaTb);

                    return CreateResponse(HttpStatusCode.OK, tarefaVM, null);
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
        [Route("tarefa")]
        public Task<HttpResponseMessage> BuscarTarefaPorNome(string nome)
        {
            try
            {
                var tarefaTb = _tarefaService.BuscarTarefasPorNome(nome).ToList();
                if (tarefaTb != null)
                {
                    // Parse de TB_TAREFA para TarefaModel
                    var tarefaVM = _parseTbTarefaToTarefaModel.Parse(tarefaTb);

                    return CreateResponse(HttpStatusCode.OK, tarefaVM, null);
                }

                return CreateResponse(HttpStatusCode.NotFound, null, null);
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.BadRequest, null, null);
            }
        }
        [HttpPost]
        [Route("tarefa")]
        [Authorize]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            // Exemplo de request
            
            try
            {
                var tarefaModel = new TarefaModel()
                {
                    NomeTarefa = (string)body.nometarefa,
                    Descricao = (string)body.descricao,
                    DataInicio = (DateTime)body.datainicio,
                    DataFim = (DateTime)body.datafim,
                    Dificuldade = (int)body.dificuldade,
                    Sprint = (int)body.sprint,
                    Usuario = (int)body.usuario,
                    Prioridade = (int)body.prioridade,
                    EstadoTarefa = (int)body.estadotarefa,
                    TipoTarefa = (int)body.tipotarefa
                };

                var tarefaTb = _parseTarefaModelToTbTarefa.Parse(tarefaModel);

                var novaTarefa = _tarefaService.CriarNovaTarefa(tarefaTb);

                if (novaTarefa != null)
                {
                    return CreateResponse(HttpStatusCode.Created, novaTarefa, null);
                }

                return CreateResponse(HttpStatusCode.BadRequest, null, null);
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.BadRequest, null, null);
            }
        }
    }
}
