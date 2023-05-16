using SuperAbp.AuditLogging.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SuperAbp.AuditLogging.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AuditLoggingController : AbpControllerBase
{
    protected AuditLoggingController()
    {
        LocalizationResource = typeof(AuditLoggingResource);
    }
}
