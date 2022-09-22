using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using SuperAbp.AuditLogging.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.AuditLogging;

namespace SuperAbp.AuditLogging;

[DependsOn(
    typeof(AbpValidationModule),
    typeof(AbpAuditLoggingDomainSharedModule)
)]
public class AuditLoggingDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AuditLoggingDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AuditLoggingResource>("en")
                .AddBaseTypes(typeof(Volo.Abp.AuditLogging.Localization.AuditLoggingResource))
                .AddVirtualJson("/Localization/AuditLogging");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("AuditLogging", typeof(AuditLoggingResource));
        });
    }
}