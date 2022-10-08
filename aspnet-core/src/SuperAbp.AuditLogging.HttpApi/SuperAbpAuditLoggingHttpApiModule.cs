using Localization.Resources.AbpUi;
using SuperAbp.AuditLogging.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace SuperAbp.AuditLogging;

[DependsOn(
    typeof(SuperAbpAuditLoggingApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class SuperAbpAuditLoggingHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(SuperAbpAuditLoggingHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AuditLoggingResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}