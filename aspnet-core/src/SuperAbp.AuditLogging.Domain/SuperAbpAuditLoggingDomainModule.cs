using Volo.Abp.AuditLogging;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace SuperAbp.AuditLogging;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(SuperAbpAuditLoggingDomainSharedModule),
    typeof(AbpAuditLoggingDomainModule)
)]
public class SuperAbpAuditLoggingDomainModule : AbpModule
{
}