using SuperAbp.AuditLogging.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SuperAbp.AuditLogging.Blazor.Server.Host;

public abstract class AuditLoggingComponentBase : AbpComponentBase
{
    protected AuditLoggingComponentBase()
    {
        LocalizationResource = typeof(AuditLoggingResource);
    }
}
