using CwkSocial.Api.Registrars.Contracts;
using CwkSocial.Application.UserProfiles.Queries;
using MediatR;

namespace CwkSocial.Api.Registrars
{
    public class BogardRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(Program), typeof(GetAlllUserProfilesQuery));
            builder.Services.AddMediatR(typeof(GetAlllUserProfilesQuery));


        }
    }
}
