using System;
using System.Threading.Tasks;
using Volo.Abp.AuditLogging;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Xunit.Sdk;

namespace SuperAbp.AuditLogging;

public class AuditLoggingTestDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly AuditLoggingTestData _testData;
    private readonly IAuditLogRepository _auditLogRepository;

    public AuditLoggingTestDataSeedContributor(IAuditLogRepository auditLogRepository, AuditLoggingTestData testData)
    {
        _auditLogRepository = auditLogRepository;
        _testData = testData;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        await _auditLogRepository.InsertAsync(new AuditLog(_testData.AuditLogId, null, null, null, null, null, DateTime.Now, 0, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null));
    }
}