using System.Web.Mvc;

namespace UPTEAM.Presentation.Web.Controllers
{
    [Authorize]
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