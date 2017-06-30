using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using UPTEAM.Domain.Entities;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.Web.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        private readonly IUsuarioService _usuarioService;
        private readonly ITarefaService _tarefaService;
        private readonly IProjetoService _projetoService;
        private readonly IEquipeService _equipeService;
        private IConquistaService _conquistaService;
        public HomeController(IUsuarioService usuarioService, ITarefaService tarefaService, IProjetoService projetoService, IEquipeService equipeService, IConquistaService conquistaService)
        {
            _usuarioService = usuarioService;
            _tarefaService = tarefaService;
            _projetoService = projetoService;
            _equipeService = equipeService;
            _conquistaService = conquistaService;
        }
        public ActionResult Index()
        {
            var membershipUser = Membership.GetUser();
            if (membershipUser != null)
            {
                var usuarioDashboard = new UsuarioDashboard()
                {
                    Usuario = _usuarioService.ObterUsuarioPorLogin(membershipUser.Email)
                };
                Session["usuario"] = usuarioDashboard.Usuario.idt_usuario;
                usuarioDashboard.ListaEquipes = _equipeService.BuscarPorUsuario(usuarioDashboard.Usuario.idt_usuario);
                usuarioDashboard.ListaTarefa = _tarefaService.BuscarTarefasPorUsuario(usuarioDashboard.Usuario);
                List<tb_projeto> aux = usuarioDashboard.ListaEquipes
                    .SelectMany(equipe => _projetoService.BuscarPorEquipe(equipe.idt_equipe)).ToList();
                usuarioDashboard.ListaProjetos = aux;
                //usuarioDashboard.ListaConquista = _conquistaService.BuscarConquistas().ToList();
                return View(usuarioDashboard);
            }
            return RedirectToAction("Logout", "Autenticacao");
        }
    }
}