using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UPTEAM.Domain.ServiceInterfaces;
using UPTEAM.Models;

namespace UPTEAM.Presentation.Web.Controllers
{
    public class AutenticacaoController : Controller
    {
        private IUsuarioService _usuarioService;
        public AutenticacaoController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
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
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Autenticar", "Autenticacao");

        }
    }
}