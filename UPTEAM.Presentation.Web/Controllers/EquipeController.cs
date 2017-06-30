using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;
using UPTEAM.AutoMapper.Parses;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.Web.Controllers
{
    [Authorize]
    public class EquipeController : Controller
    {
        public EquipeController(EquipeModelToTbEquipeParse equipeParser, IEquipeService equipeService, IUsuarioService usuarioService, TbEquipeToEquipeModelParse equipeModelParse, IProjetoService projetoService, TbProjetoToProjetoModelParse projetoParser)
        {
            _equipeModelParser = equipeParser;
            _equipeService = equipeService;
            _usuarioService = usuarioService;
            _equipeParser = equipeModelParse;
            _projetoService = projetoService;
            _projetoParser = projetoParser;
        }

        private EquipeModelToTbEquipeParse _equipeModelParser { get; }
        private TbEquipeToEquipeModelParse _equipeParser { get; }
        private IEquipeService _equipeService { get; }
        private IUsuarioService _usuarioService { get; }
        private IProjetoService _projetoService { get; }
        private TbProjetoToProjetoModelParse _projetoParser { get; }

        // GET: Equipe
        public ActionResult Index()
        {
            var usuarioLogado = _usuarioService.ObterUsuarioPorLogin(Membership.GetUser().Email);
            var listaEquipes = _equipeService.BuscarPorUsuario(usuarioLogado.idt_usuario);
            var lstEquipeModels = new List<EquipeModel>();

            foreach (var tbEquipe in listaEquipes)
            {
                lstEquipeModels.Add(_equipeParser.Parse(tbEquipe));
            }
            return View(lstEquipeModels);
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(EquipeModel equipe)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var usuarioLogado = _usuarioService.ObterUsuarioPorLogin(Membership.GetUser().Email);
                var equipeTb = _equipeParser.Parse(equipe);
                var equipeBanco = _equipeService.CriarNovaEquipe(equipeTb);
                _equipeService.AdicionarUsuario(usuarioLogado.idt_usuario, equipeBanco.idt_equipe);
                return RedirectToAction("Index","Equipe");
            }
            catch (Exception ex)
            {
                return RedirectToAction("");
            }
        }

        public ActionResult Detalhe(int id)
        {
            var equipe = _equipeService.BuscarPorId(id);
            var equipeModel = _equipeParser.Parse(equipe);
            var aux = _projetoService.BuscarPorEquipe(equipe.idt_equipe);
            equipeModel.ListaProjetos = new List<ProjetoModel>();
            Session["equipe"] = id;
            foreach (var projeto in aux)
            {
                equipeModel.ListaProjetos.Add(_projetoParser.Parse(projeto));
            }
            
            return View(equipeModel);
        }

        public ActionResult Editar(int id)
        {
            var equipe = _equipeService.BuscarPorId(id);
            return View(_equipeParser.Parse(equipe));
        }
        [HttpPost]
        public ActionResult Editar(EquipeModel equipe)
        {
            var equipeTb = _equipeParser.Parse(equipe);
            _equipeService.AtualizarEquipe(equipeTb);
            return View(_equipeParser.Parse(equipe));
        }
    }
}