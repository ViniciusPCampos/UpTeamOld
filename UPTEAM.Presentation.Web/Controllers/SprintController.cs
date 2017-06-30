using System.Web.Mvc;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.Web.Controllers
{
    public class SprintController : Controller
    {
        private ISprintService _sprintService;
        private ITbSprintToSprintModelParse _sprintModelParse;
        private ISprintModelToTbSprintParse _sprintTbParse;
        public SprintController(ITbSprintToSprintModelParse sprintModelParse, ISprintModelToTbSprintParse sprintTbParse, ISprintService sprintService)
        {
            _sprintModelParse = sprintModelParse;
            _sprintTbParse = sprintTbParse;
            _sprintService = sprintService;
        }
        public ActionResult Criar()
        {
            var sprint = new SprintModel { Projeto = (int)Session["projeto"] };
            return View(sprint);
        }
        [HttpPost]
        public ActionResult Criar(SprintModel sprintModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var aux = _sprintModelParse.Parse(sprintModel);
            aux = _sprintService.CriarSprint(aux);
            return RedirectToAction("Detalhe", new { sprint = aux });
        }
        public ActionResult Delete(int id)
        {
            var sprint = _sprintService.BuscarPorId(id);
            _sprintService.ExcluirSprint(sprint);

            return RedirectToAction("Detalhe", "Projeto", new { id = sprint.idt_projeto });
        }

        public ActionResult Detalhe(int id)
        {
            var tbSprint = _sprintService.BuscarPorId(id);
            var sprint = _sprintTbParse.Parse(tbSprint);
            Session["Sprint"] = sprint.IdSprint;

            return View(sprint);
        }

        public ActionResult Editar(int id)
        {
            var tbSprint = _sprintService.BuscarPorId(id);
            var sprint = _sprintTbParse.Parse(tbSprint);
            Session["Sprint"] = sprint.IdSprint;

            return View(sprint);
        }
        public ActionResult EditarSprint(SprintModel sprint)
        {
            var sprintTb = _sprintTbParse.Parse(sprint);
            _sprintService.AtualizarSprint(sprintTb);

            return RedirectToAction("Detalhe", new { id = sprint.IdSprint });
        }
    }
}