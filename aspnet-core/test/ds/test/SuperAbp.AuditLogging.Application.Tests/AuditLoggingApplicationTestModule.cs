using Volo.Abp.Modularity;

namespace SuperAbp.AuditLogging;

[DependsOn(
    typeof(AuditLoggingApplicationModule),
    typeof(AuditLoggingDomainTestModule)
    )]
public class AuditLoggingApplicationTestModule : AbpModule
{

}
