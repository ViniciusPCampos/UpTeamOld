using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UPTEAM.Presentation.Web.Controllers
{
    public class MensagemController : Controller
    {
        // GET: Mensagem
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Criar()
        {
            return View();
        }
        public ActionResult Ler()
        {
            return View();
        }
    }
}