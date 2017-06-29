using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UPTEAM.Domain.ServiceInterfaces;

namespace UPTEAM.Presentation.API.Controllers
{
    [RoutePrefix("api/v1")]
    public class DashboardController : BaseController
    {
        private IDashboardService _dashboardService;
        private IUsuarioService _usuarioService;

        public DashboardController(IDashboardService dashboardService, IUsuarioService usuarioService)
        {
            _dashboardService = dashboardService;
            _usuarioService = usuarioService;
        }
        [HttpGet]
        [Authorize]
        [Route("dashboard")]
        public Task<HttpResponseMessage> BuscarDashboard()
        {
            try
            {
                var usuario = _usuarioService.ObterUsuarioPorLogin(ObterUsuarioLogado());

                var dashboard = _dashboardService.ObterDashboard(usuario.idt_usuario);
                if (dashboard != null)
                {

                    return CreateResponse(HttpStatusCode.OK, dashboard, null);
                }

                return CreateResponse(HttpStatusCode.NotFound, null, null);
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.BadRequest, null, null);
            }
        }
    }
}
