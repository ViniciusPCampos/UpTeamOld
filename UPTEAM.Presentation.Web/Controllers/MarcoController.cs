using System.Collections.Generic;
using System.Web.Mvc;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.Web.Controllers
{
    public class MarcoController : Controller
    {
        public MarcoController(IMarcoService marcoService, IMarcoModelToTbMarcoParse marcoModelParse, ITbMarcoToMarcoModelParse tbMarcoParse)
        {
            MarcoService = marcoService;
            MarcoModelParse = marcoModelParse;
            TbMarcoParse = tbMarcoParse;
            Projeto = (ProjetoModel) Session["Projeto"];
        }
        private IMarcoService MarcoService { get; }
        private IMarcoModelToTbMarcoParse MarcoModelParse { get; }
        private ITbMarcoToMarcoModelParse TbMarcoParse { get; }

        private ProjetoModel Projeto { get;}
        // GET: Marco
        public ActionResult Index()
        {
            List<MarcoModel> aux = new List<MarcoModel>();
            var listMarcosProjeto = MarcoService.BuscarPorProjeto(Projeto.IdProjeto);
            foreach (var tbMarco in listMarcosProjeto)
            {
                aux.Add(TbMarcoParse.Parse(tbMarco));
            }
            
            return View(aux);
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(MarcoModel marco)
        {
            if (!ModelState.IsValid) return View();
            var tbMarco = MarcoModelParse.Parse(marco);
            tbMarco = MarcoService.CriarNovaMarco(tbMarco);
            return RedirectToAction("Detalhe", tbMarco);
        }

        public ActionResult Editar(int id)
        {
            var marco = MarcoService.BuscarMarco(id);
            var marcoModel = MarcoModelParse.Parse(marco);
            return View(marcoModel);
        }

        [HttpPost]
        public ActionResult Editar(MarcoModel marco)
        {
            if (!ModelState.IsValid) return View();

            var tbMarco = MarcoModelParse.Parse(marco);
            MarcoService.AlterarMarco(tbMarco);
            return RedirectToAction("Detalhe", tbMarco.idt_projeto);
        }

        public ActionResult Detalhe(int id)
        {
            var marco = MarcoService.BuscarMarco(id);
            var marcoModel = MarcoModelParse.Parse(marco);
            return View(marcoModel);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var marco = MarcoService.BuscarMarco(id);
            MarcoService.DeletarMarco(marco);
            return View();
        }
    }
}