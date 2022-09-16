using SuperAbp.AuditLogging.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SuperAbp.AuditLogging.Pages;

public abstract class AuditLoggingPageModel : AbpPageModel
{
    protected AuditLoggingPageModel()
    {
        LocalizationResourceType = typeof(AuditLoggingResource);
    }
}
