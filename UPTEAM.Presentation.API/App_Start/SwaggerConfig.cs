using System.Web.Http;
using WebActivatorEx;
using UPTEAM.Presentation.API;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace UPTEAM.Presentation.API
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                    .EnableSwagger(c =>
                    {
                        c.ApiKey("Bearer")
                        .Description("Filling bearer token here")
                        .Name("Authorization")
                        .In("header");

                        c.SingleApiVersion("v1", "A title for your API");
                    })

                  //.EnableSwagger(c => c.SingleApiVersion("v1", "A title for your API"))
                  .EnableSwaggerUi();
        }
    }
}