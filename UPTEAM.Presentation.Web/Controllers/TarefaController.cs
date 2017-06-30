using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.Web.Controllers
{
    public class TarefaController : Controller
    {
        private ITarefaService _tarefaService;
        private ITarefaModelToTbTarefaParse _tarefaModelParser;
        private ITbTarefaToTarefaModelParse _tbTarefaParser;
        private IDificuldadeService _dificuldadeService;
        private ITbDificuldadeToDificuldadeModel _tbDificuldadeParser;
        private IPrioridadeService _prioridadeService;
        private ITbPrioridadeToPrioridadeModel _tbPrioridadeParser;
        private ITipoTarefaService _tipoTarefaService;
        private ITbTipoTarefaToTipoTarefaModel _tbTipoTarefaParser;
        private IEstadoTarefaService _estadoTarefaService;
        private ITbEstadoTarefaToEstadoTarefaModel _tbEstadoTarefaParser;

        public TarefaController(ITarefaService tarefaService, ITarefaModelToTbTarefaParse tarefaModelParser,
            ITbTarefaToTarefaModelParse tbtarefaParser, IDificuldadeService dificuldadeService,
            ITbDificuldadeToDificuldadeModel tbDificuldadeParser, IPrioridadeService prioridadeService,
            ITbPrioridadeToPrioridadeModel tbPrioridadeParser, IEstadoTarefaService estadoTarefaService,
            ITbEstadoTarefaToEstadoTarefaModel tbEstadoTarefaParser, ITipoTarefaService tipoTarefaService,
            ITbTipoTarefaToTipoTarefaModel tbTipoTarefaParser)
        {
            _tarefaService = tarefaService;
            _tarefaModelParser = tarefaModelParser;
            _tbTarefaParser = tbtarefaParser;
            _dificuldadeService = dificuldadeService;
            _tbDificuldadeParser = tbDificuldadeParser;
            _prioridadeService = prioridadeService;
            _tbPrioridadeParser = tbPrioridadeParser;
            _estadoTarefaService = estadoTarefaService;
            _tbEstadoTarefaParser = tbEstadoTarefaParser;
            _tipoTarefaService = tipoTarefaService;
            _tbTipoTarefaParser = tbTipoTarefaParser;
        }

        public ActionResult Criar()
        {

            ViewBag.Dificuldades = new SelectList(_dificuldadeService.BuscarTudo(), "idt_dificuldade", "nme_dificuldade");
            ViewBag.EstadoTarefa = new SelectList(_estadoTarefaService.BuscarTudo(), "idt_estado_tarefa", "nme_estado_tarefa");
            ViewBag.TipoTarefa = new SelectList(_tipoTarefaService.BuscarTudo(), "idt_tipo_tarefa", "nme_tipo_tarefa");
            ViewBag.Prioridade = new SelectList(_prioridadeService.BuscarTudo(), "idt_prioridade", "nme_prioridade");
            var tarefa = new TarefaModel {Sprint = (int) Session["Sprint"]};
            return View(tarefa);
        }

        [HttpPost]
        public ActionResult Criar(TarefaModel tarefa)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var aux = _tarefaModelParser.Parse(tarefa);
            aux = _tarefaService.CriarNovaTarefa(aux);
            return RedirectToAction("Detalhe", "Sprint", new {id = aux.idt_sprint});
        }
    }
}