using System.Web.Mvc;

namespace UPTEAM.Presentation.Web.Controllers
{
    [Authorize]
    public class MarcoController : Controller
    {
        // GET: Marco
        public ActionResult Index()
        {
            return View();
        }
    }
}