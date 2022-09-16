using SuperAbp.AuditLogging.Localization;
using Volo.Abp.Application.Services;

namespace SuperAbp.AuditLogging;

public abstract class AuditLoggingAppService : ApplicationService
{
    protected AuditLoggingAppService()
    {
        LocalizationResource = typeof(AuditLoggingResource);
        ObjectMapperContext = typeof(AuditLoggingApplicationModule);
    }
}
