using System.Web.Http;
using WebActivatorEx;
using MarsRoverApi;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace MarsRoverApi
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "MarsRoverApi");
                    c.IncludeXmlComments(string.Format(@"{0}\bin\MarsRoverApi.xml",
                        System.AppDomain.CurrentDomain.BaseDirectory));
                })
                .EnableSwaggerUi();

        }
    }
}
