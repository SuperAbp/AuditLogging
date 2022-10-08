using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace SuperAbp.AuditLogging;

[DependsOn(
    typeof(SuperAbpAuditLoggingDomainModule),
    typeof(SuperAbpAuditLoggingApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class SuperAbpAuditLoggingApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<SuperAbpAuditLoggingApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<SuperAbpAuditLoggingApplicationModule>(validate: true);
        });
    }
}