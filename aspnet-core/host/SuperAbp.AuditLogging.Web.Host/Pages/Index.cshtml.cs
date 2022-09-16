using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace SuperAbp.AuditLogging.Pages;

public class IndexModel : AuditLoggingPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
