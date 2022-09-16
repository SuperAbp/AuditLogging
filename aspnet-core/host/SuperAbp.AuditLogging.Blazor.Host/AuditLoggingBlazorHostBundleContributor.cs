using Volo.Abp.Bundling;

namespace SuperAbp.AuditLogging.Blazor.Host;

public class AuditLoggingBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
