using System;
using System.Collections.Generic;
using System.Text;
using SuperAbp.AuditLogging.Localization;
using Volo.Abp.Application.Services;

namespace SuperAbp.AuditLogging;

/* Inherit your application services from this class.
 */
public abstract class AuditLoggingAppService : ApplicationService
{
    protected AuditLoggingAppService()
    {
        LocalizationResource = typeof(AuditLoggingResource);
    }
}
