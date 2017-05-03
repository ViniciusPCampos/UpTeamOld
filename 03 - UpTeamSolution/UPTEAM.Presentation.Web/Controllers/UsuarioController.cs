using System.Web.Mvc;

namespace UPTEAM.Presentation.Web.Controllers
{
    [Authorize]
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
    }
}