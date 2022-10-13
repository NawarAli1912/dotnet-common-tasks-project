using CwkSocial.Api.Options;
using CwkSocial.Api.Registrars.Contracts;

namespace CwkSocial.Api.Registrars
{
    public class MvcRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {


            builder.Services.AddControllers();

            // Api versioning
            builder.Services.AddApiVersioning();
            builder.Services.ConfigureOptions<ConfigureVersioningOptions>();
            builder.Services.AddVersionedApiExplorer(config =>
            {
                config.GroupNameFormat = "'v'VVV";
                config.SubstituteApiVersionInUrl = true;
            });

            builder.Services.AddEndpointsApiExplorer();
        }
    }
}
