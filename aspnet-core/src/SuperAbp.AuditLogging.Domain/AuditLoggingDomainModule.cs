using Volo.Abp.AuditLogging;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace SuperAbp.AuditLogging;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AuditLoggingDomainSharedModule),
    typeof(AbpAuditLoggingDomainModule)
)]
public class AuditLoggingDomainModule : AbpModule
{
}