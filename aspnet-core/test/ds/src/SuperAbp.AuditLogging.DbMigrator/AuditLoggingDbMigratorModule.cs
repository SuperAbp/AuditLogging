using SuperAbp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SuperAbp.AuditLogging.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AuditLoggingEntityFrameworkCoreModule),
    typeof(AuditLoggingApplicationContractsModule)
    )]
public class AuditLoggingDbMigratorModule : AbpModule
{

}
