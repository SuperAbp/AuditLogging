using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SuperAbp.AuditLogging;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AuditLoggingHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class AuditLoggingConsoleApiClientModule : AbpModule
{

}
