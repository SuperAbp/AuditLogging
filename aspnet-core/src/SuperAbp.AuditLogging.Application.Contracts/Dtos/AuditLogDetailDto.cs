using System;
using System.Collections.Generic;
using System.Text;

namespace SuperAbp.AuditLogging.Dtos
{
    public class AuditLogDetailDto
    {
        public virtual string ApplicationName { get; set; }

        public virtual string UserName { get; protected set; }

        public virtual string TenantName { get; protected set; }

        public virtual DateTime ExecutionTime { get; protected set; }

        public virtual int ExecutionDuration { get; protected set; }

        public virtual string ClientIpAddress { get; protected set; }

        public virtual string ClientName { get; protected set; }

        public virtual string BrowserInfo { get; protected set; }

        public virtual string HttpMethod { get; protected set; }

        public virtual string Url { get; protected set; }

        public virtual string Exceptions { get; protected set; }

        public virtual string Comments { get; protected set; }

        public virtual int? HttpStatusCode { get; set; }
        public ICollection<AuditLogActionDetailDto> Actions { get; set; }
    }
}