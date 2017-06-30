using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.DTO;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.Web.Controllers
{
    public class AutenticacaoController : Controller
    {
        private IUsuarioService _usuarioService;
        public AutenticacaoController(IUsuarioService usuarioService, IRegistrarModelToTbUsuarioParse registrarModelToTbUsuario)
        {
            _usuarioService = usuarioService;
            _registrarModelToTbUsuario = registrarModelToTbUsuario;
        }
        private IRegistrarModelToTbUsuarioParse _registrarModelToTbUsuario;
        // GET: Autenticacao
        public ActionResult Autenticar()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View();
        }
        [HttpPost]
        public ActionResult Autenticar(AutenticacaoModel usuario)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(usuario.Login, usuario.Senha))
                {
                    FormsAuthentication.SignOut();
                    FormsAuthentication.SetAuthCookie(usuario.Login, true);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("login", "Login ou Senha incorretos.");
            }

            return View();
        }
        //GET: Registrar
        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(RegistrarModel usuario)
        {
            if (usuario.Senha != usuario.ConfirmacaoSenha)
            {
                ModelState.AddModelError("Senha", "A Senha e a Confirmação da Senha não combinam.");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            _usuarioService.Register(_registrarModelToTbUsuario.Parse(usuario));
            return RedirectToAction("autenticar");


        }
        [HttpGet]
        public ActionResult ObterPerfilUsuario(string login)
        {
            var jsonResult = new JsonResult<UsuarioPerfilDTO>();
            var usuario = _usuarioService.ObterPerfilUsuario(login);
            jsonResult.Src = usuario;

            return Json(jsonResult,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Autenticar", "Autenticacao");

        }
    }
}