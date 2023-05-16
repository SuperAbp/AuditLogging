using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using SuperAbp.AuditLogging.Dtos;
using Xunit;

namespace SuperAbp.AuditLogging;

public sealed class AuditLogAppServiceTests : AuditLoggingApplicationTestBase
{
    private readonly AuditLoggingTestData _testData;
    private readonly IAuditLogAppService _auditLogAppService;

    public AuditLogAppServiceTests()
    {
        _testData = GetRequiredService<AuditLoggingTestData>();
        _auditLogAppService = GetRequiredService<IAuditLogAppService>();
    }

    [Fact]
    public async Task Should_Get_List()
    {
        var result = await _auditLogAppService.GetListAsync(new GetAuditLogsInput());

        result.Items.Count.ShouldBeGreaterThan(0);
    }

    [Fact]
    public async Task Should_Get_Detail()
    {
        var result = await _auditLogAppService.GetDetailAsync(_testData.AuditLogId);
        result.ShouldNotBeNull();
    }
}