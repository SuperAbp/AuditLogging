using Volo.Abp.Modularity;

namespace SuperAbp.AuditLogging;

[DependsOn(
    typeof(SuperAbpAuditLoggingApplicationModule),
    typeof(AuditLoggingDomainTestModule)
    )]
public class AuditLoggingApplicationTestModule : AbpModule
{
}