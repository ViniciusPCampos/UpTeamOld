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
        }
        private IMarcoService MarcoService { get; }
        private IMarcoModelToTbMarcoParse MarcoModelParse { get; }
        private ITbMarcoToMarcoModelParse TbMarcoParse { get; }

        private int Projeto { get; set; }

        public ActionResult Criar()
        {
            var marco = new MarcoModel();
            marco.Projeto = (int)Session["Projeto"];
            return View(marco);
        }

        [HttpPost]
        public ActionResult Criar(MarcoModel marco)
        {
            if (!ModelState.IsValid) return View();
            var tbMarco = MarcoModelParse.Parse(marco);
            tbMarco = MarcoService.CriarNovaMarco(tbMarco);
            return RedirectToAction("Detalhe", "Projeto", new{id= tbMarco.idt_projeto });
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
            return RedirectToAction("Detalhe", "Projeto", new { id = tbMarco.idt_projeto });
        }

        public ActionResult Detalhe(int id)
        {
            var marco = MarcoService.BuscarMarco(id);
            var marcoModel = MarcoModelParse.Parse(marco);
            return View(marcoModel);
        }

        public ActionResult Delete(int id)
        {
            var marco = MarcoService.BuscarMarco(id);
            MarcoService.DeletarMarco(marco);
            return RedirectToAction("Detalhe", "Projeto", new { id });
        }
    }
}