using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Options;

namespace CwkSocial.Api.Options
{
    public class ConfigureVersioningOptions : IConfigureOptions<ApiVersioningOptions>
    {
        public void Configure(ApiVersioningOptions config)
        {
            config.DefaultApiVersion = new ApiVersion(1, 0);
            config.AssumeDefaultVersionWhenUnspecified = true;
            config.ReportApiVersions = true;
            config.ApiVersionReader = new UrlSegmentApiVersionReader();
        }
    }
}
