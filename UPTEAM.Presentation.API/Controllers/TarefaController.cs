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
        private IProjetoService _projetoService;
        private IUsuarioService _usuarioService;

        private ITbTarefaToTarefaModelParse _parseTbTarefaToTarefaModel;
        private ITarefaModelToTbTarefaParse _parseTarefaModelToTbTarefa;
        private ITbProjetoToProjetoModelParse _parseTbProjetoToProjetoModel;
        private IProjetoModelToTbProjetoParse _parseProjetoModelToTbProjeto;

        public TarefaController(
            ITarefaService tarefaService,
            ITbTarefaToTarefaModelParse parseTbTarefaToTarefaModel,
            ITarefaModelToTbTarefaParse parseTarefaModelToTbTarefa,
            IProjetoService projetoService,
            IUsuarioService usuarioService,
            ITbProjetoToProjetoModelParse parseTbProjetoToProjetoModel,
            IProjetoModelToTbProjetoParse parseProjetoModelToTbProjeto
            )
        {
            _tarefaService = tarefaService;
            _parseTbTarefaToTarefaModel = parseTbTarefaToTarefaModel;
            _parseTarefaModelToTbTarefa = parseTarefaModelToTbTarefa;

            _projetoService = projetoService;
            _usuarioService = usuarioService;
            _parseTbProjetoToProjetoModel = parseTbProjetoToProjetoModel;
            _parseProjetoModelToTbProjeto = parseProjetoModelToTbProjeto;
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
        [HttpGet]
        [Authorize]
        [Route("tarefas")]
        public Task<HttpResponseMessage> BuscarTarefasPorUsuario()
        {
            try
            {
                var usuario = _usuarioService.ObterUsuarioPorLogin(ObterUsuarioLogado());

                var projetosTb = _projetoService.BuscarProjetosTarefasPorUsuario(usuario.idt_usuario);

                if (projetosTb != null)
                {
                    var projetosVM = _parseTbProjetoToProjetoModel.Parse(projetosTb);

                    return CreateResponse(HttpStatusCode.OK, projetosVM, null);
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
                    IdDificuldade = (int)body.dificuldade,
                    Sprint = (int)body.sprint,
                    Usuario = (int)body.usuario,
                    IdPrioridade = (int)body.prioridade,
                    IdEstadoTarefa = (int)body.estadotarefa,
                    IdTipoTarefa = (int)body.tipotarefa
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
