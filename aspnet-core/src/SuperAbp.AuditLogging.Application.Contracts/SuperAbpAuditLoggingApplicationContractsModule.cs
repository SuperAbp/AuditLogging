using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace SuperAbp.AuditLogging;

[DependsOn(
    typeof(SuperAbpAuditLoggingDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class SuperAbpAuditLoggingApplicationContractsModule : AbpModule
{
}