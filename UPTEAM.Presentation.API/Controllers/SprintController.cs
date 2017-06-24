using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using UPTEAM.ApplicationServices;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.ServiceInterfaces;

namespace UPTEAM.Presentation.API.Controllers
{
    [RoutePrefix("api/v1")]
    public class SprintController : BaseController
    {
        private ISprintService _sprintService;
        private ITbSprintToSprintModelParse _parseTbSprintToSprintModel;
        private ISprintModelToTbSprintParse _parseSprintModelToTbSprint;
        public SprintController(ISprintService sprintService,
                                ITbSprintToSprintModelParse parseTbSprintToSprintModel,
                                ISprintModelToTbSprintParse parseSprintModelToTbSprint)
        {
            _sprintService = sprintService;
            _parseTbSprintToSprintModel = parseTbSprintToSprintModel;
            _parseSprintModelToTbSprint = parseSprintModelToTbSprint;
        }

        [HttpGet]
        [Authorize]
        [Route("projeto/{idProjeto:int}/sprint")]
        public Task<HttpResponseMessage> BuscarPorProjeto(int idProjeto)
        {
            try
            {
                var sprintTb = _sprintService.BuscarPorProjeto(idProjeto);
                if(sprintTb != null)
                {
                    var sprintVM = _parseTbSprintToSprintModel.Parse(sprintTb);

                    return CreateResponse(HttpStatusCode.OK, sprintVM, null);
                }

                return CreateResponse(HttpStatusCode.NotFound, null, null);
            }
            catch(Exception ex)
            {
                return CreateResponse(HttpStatusCode.BadRequest, null, null);
            }
        }

    }
}