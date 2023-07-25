using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SuperAbp.AuditLogging.Web;

[Dependency(ReplaceServices = true)]
public class AuditLoggingBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AuditLogging";
}
