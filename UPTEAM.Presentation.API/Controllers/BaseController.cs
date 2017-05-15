using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
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
        public Task<HttpResponseMessage> CreateResponse(HttpStatusCode code, object result)
        {
            var jsonResult = new JsonResult<object>();
            jsonResult.Src = result;

            ResponseMessage = Request.CreateResponse(code, result);

            return Task.FromResult<HttpResponseMessage>(ResponseMessage);
        }
    }
}