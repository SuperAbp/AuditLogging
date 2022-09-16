using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SuperAbp.AuditLogging.Dtos
{
    public class GetAuditLogsInput : PagedAndSortedResultRequestDto
    {
        public string HttpMethod { get; set; }
        public string Url { get; set; }
        public int? HttpStatusCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}