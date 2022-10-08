using SuperAbp.AuditLogging.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SuperAbp.AuditLogging.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AuditLoggingPageModel : AbpPageModel
{
    protected AuditLoggingPageModel()
    {
        LocalizationResourceType = typeof(AuditLoggingResource);
        ObjectMapperContext = typeof(SuperAbpAuditLoggingWebModule);
    }
}
