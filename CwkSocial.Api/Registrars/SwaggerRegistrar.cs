using CwkSocial.Api.Options;
using CwkSocial.Api.Registrars.Contracts;

namespace CwkSocial.Api.Registrars
{
    public class SwaggerRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
            // Configuring api versioning with swagger
            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
        }
    }
}
