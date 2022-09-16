using SuperAbp.AuditLogging.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SuperAbp.AuditLogging;

public abstract class AuditLoggingController : AbpControllerBase
{
    protected AuditLoggingController()
    {
        LocalizationResource = typeof(AuditLoggingResource);
    }
}
