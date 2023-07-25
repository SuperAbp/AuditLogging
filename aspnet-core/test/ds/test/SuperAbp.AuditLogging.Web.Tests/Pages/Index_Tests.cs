using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace SuperAbp.AuditLogging.Pages;

public class Index_Tests : AuditLoggingWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
