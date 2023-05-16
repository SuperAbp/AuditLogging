using SuperAbp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SuperAbp.AuditLogging;

[DependsOn(
    typeof(AuditLoggingEntityFrameworkCoreTestModule)
    )]
public class AuditLoggingDomainTestModule : AbpModule
{

}
