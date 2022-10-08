using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace SuperAbp.AuditLogging;

[DependsOn(
    typeof(SuperAbpAuditLoggingApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class SuperAbpAuditLoggingHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(SuperAbpAuditLoggingApplicationContractsModule).Assembly,
            AuditLoggingRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SuperAbpAuditLoggingHttpApiClientModule>();
        });
    }
}