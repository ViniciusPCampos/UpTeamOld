using System;
using System.Web.Mvc;
using UPTEAM.AutoMapper.Parses;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.Web.Controllers
{
    public class MensagemController : Controller
    {
        private MensagemModelToTbMensagemParse _mensagemParser { get; }
        private TbMensagemToMensagemModelParse _mensagemModelParser { get; }
        private IMensagemService _mensagemService { get; }
        private IUsuarioService _usuarioService { get; }

        public MensagemController(MensagemModelToTbMensagemParse mensagemParser, IMensagemService mensagemService,
            TbMensagemToMensagemModelParse mensagemModelParser, IUsuarioService usuarioService)
        {
            _mensagemParser = mensagemParser;
            _mensagemService = mensagemService;
            _mensagemModelParser = mensagemModelParser;
            _usuarioService = usuarioService;
        }

        public ActionResult Criar(MensagemModel mensagemModel)
        {

            mensagemModel.DataEnvio = DateTime.Now;
            mensagemModel.IdUsuario = _usuarioService.ObterUsuarioPorLogin(User.Identity.Name).idt_usuario;
            mensagemModel.Equipe = (int)Session["equipe"];
            if (!ModelState.IsValid)
            {
                return View();
            }

            var aux = _mensagemModelParser.Parse(mensagemModel);

            aux = _mensagemService.EnviarMensagem(aux);
            return RedirectToAction("Detalhe", "Equipe", new { id = mensagemModel.Equipe });
        }


    }

}
