using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;
using UPTEAM.ApplicationServices;
using UPTEAM.AutoMapper.Parses;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.Web.Controllers
{
    [Authorize]
    public class EquipeController : Controller
    {
        public EquipeController(EquipeModelToTbEquipeParse equipeParser, IEquipeService equipeService, IUsuarioService usuarioService, TbEquipeToEquipeModelParse equipeModelParse)
        {
            _equipeModelParser = equipeParser;
            _equipeService = equipeService;
            _usuarioService = usuarioService;
            _equipeParser = equipeModelParse;
        }

        private EquipeModelToTbEquipeParse _equipeModelParser { get; }
        private TbEquipeToEquipeModelParse _equipeParser { get; }
        private IEquipeService _equipeService { get; }
        private IUsuarioService _usuarioService { get; }
        private tb_usuario _usuarioLogado { get; set; }

        // GET: Equipe
        public ActionResult Index()
        {
            _usuarioLogado = _usuarioService.ObterUsuarioPorLogin(Membership.GetUser().Email);
            var listaEquipes = _equipeService.BuscarPorUsuario(_usuarioLogado.idt_usuario);
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
                _usuarioLogado = _usuarioService.ObterUsuarioPorLogin(Membership.GetUser().Email);
                var equipeTb = _equipeParser.Parse(equipe);
                var equipeBanco = _equipeService.CriarNovaEquipe(equipeTb);
                _equipeService.AdicionarUsuario(_usuarioLogado.idt_usuario, equipeBanco.idt_equipe);
                return RedirectToAction("Index","Equipe");
            }
            catch (Exception e)
            {
                return RedirectToAction("");
            }
        }

        public ActionResult Detalhe(int id)
        {
            var equipe = _equipeService.BuscarPorId(id);
            return View(_equipeParser.Parse(equipe));
        }

        public ActionResult Editar(int id)
        {
            var equipe = _equipeService.BuscarPorId(id);
            return View(_equipeParser.Parse(equipe));
        }
    }
}