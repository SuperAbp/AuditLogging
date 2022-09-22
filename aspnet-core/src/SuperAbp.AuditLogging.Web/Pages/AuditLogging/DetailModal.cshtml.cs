using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperAbp.AuditLogging.Dtos;
using System;
using System.Threading.Tasks;

namespace SuperAbp.AuditLogging.Web.Pages.AuditLogging
{
    public class DetailModalModel : AuditLoggingPageModel
    {
        private readonly IAuditLogAppService _auditLogAppService;

        public DetailModalModel(IAuditLogAppService auditLogAppService)
        {
            _auditLogAppService = auditLogAppService;
        }

        public AuditLogDetailDto AuditLogging { get; set; }

        public async Task OnGet(Guid id)
        {
            AuditLogging = await _auditLogAppService.GetDetailAsync(id);
        }
    }
}