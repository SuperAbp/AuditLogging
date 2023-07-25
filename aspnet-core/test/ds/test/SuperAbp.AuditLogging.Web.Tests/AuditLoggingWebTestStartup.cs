using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace SuperAbp.AuditLogging;

public class AuditLoggingWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<AuditLoggingWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
