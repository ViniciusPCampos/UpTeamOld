using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UPTEAM.Models;

namespace UPTEAM.Presentation.API.Controllers
{
    public class BaseController : ApiController
    {
        public HttpResponseMessage ResponseMessage;

        public BaseController()
        {
            ResponseMessage = new HttpResponseMessage();
        }
        public Task<HttpResponseMessage> CreateResponse(HttpStatusCode code, object result, List<ErrosJson> erros)
        {

            var jsonResult = new JsonResult<object>();
            jsonResult.Src = result;
            switch (code)
            {
                case HttpStatusCode.NotFound:
                    jsonResult.Erros.Add(new ErrosJson("Erro 404", new List<string>() { "Nenhum resultado encontrado." }));
                    break;
                case HttpStatusCode.BadRequest:
                    jsonResult.Erros.Add(new ErrosJson("Erro 400", new List<string>() { "Requisição invalida." }));
                    break;
            }

            ResponseMessage = Request.CreateResponse(code, jsonResult);

            return Task.FromResult<HttpResponseMessage>(ResponseMessage);
        }
    }
}
