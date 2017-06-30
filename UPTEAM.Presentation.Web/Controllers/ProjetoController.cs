using System.Collections.Generic;
using System.Web.Mvc;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.Web.Controllers
{
    public class ProjetoController : Controller
    {
        public ProjetoController(IProjetoService projetoService, IProjetoModelToTbProjetoParse projetoModelParser, ITbProjetoToProjetoModelParse tbProjetoParser, IMarcoService marcoService, ITbMarcoToMarcoModelParse marcoParse)
        {
            _projetoService = projetoService;
            _projetoModelParser = projetoModelParser;
            _tbProjetoParser = tbProjetoParser;
            _marcoService = marcoService;
            _marcoParse = marcoParse;
        }

        private IProjetoService _projetoService { get; }
        private IProjetoModelToTbProjetoParse _projetoModelParser { get; }
        private ITbProjetoToProjetoModelParse _tbProjetoParser { get; }
        private IMarcoService _marcoService { get; }
        private ITbMarcoToMarcoModelParse _marcoParse { get; }
        public ActionResult Criar()
        {
            var projeto = new ProjetoModel {EquipeProjeto = (int) Session["equipe"]};
            return View(projeto);
        }
        [HttpPost]
        public ActionResult Criar(ProjetoModel projetoModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var aux = _projetoModelParser.Parse(projetoModel);
            aux = _projetoService.CriarNovoProjeto(aux);
            return RedirectToAction("Detalhe", new { id = aux.idt_projeto });
        }

        public ActionResult Detalhe(int id)
        {
            var tbProjeto = _projetoService.BuscarPorID(id);
            var projeto = _tbProjetoParser.Parse(tbProjeto);
            projeto.Marcos = new List<MarcoModel>();
            var tbMarcos = _marcoService.BuscarPorProjeto(projeto.IdProjeto);
            foreach (var marco in tbMarcos)
            {
                projeto.Marcos.Add(_marcoParse.Parse(marco));
            }
            Session["Projeto"] = projeto.IdProjeto;
            return View(projeto);
        }

        public ActionResult Editar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}