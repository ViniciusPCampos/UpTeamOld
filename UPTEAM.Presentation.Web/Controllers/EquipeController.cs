using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UPTEAM.Presentation.Web.Controllers
{
    public class EquipeController : Controller
    {
        // GET: Equipe
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(FormCollection form)
        {
            return View();
        }
    }
}