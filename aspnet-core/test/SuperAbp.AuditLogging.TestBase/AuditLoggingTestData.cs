using System;
using Volo.Abp.DependencyInjection;

namespace SuperAbp.AuditLogging;

public class AuditLoggingTestData : ISingletonDependency
{
    public Guid AuditLogId { get; set; } = Guid.NewGuid();
}