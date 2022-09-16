using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SuperAbp.AuditLogging.Dtos;

public class AuditLogListDto : EntityDto<Guid>
{
    public virtual string ApplicationName { get; set; }

    public virtual string UserName { get; protected set; }
    public virtual string TenantName { get; protected set; }

    public virtual DateTime ExecutionTime { get; protected set; }

    public virtual int ExecutionDuration { get; protected set; }

    public virtual string ClientIpAddress { get; protected set; }

    public virtual string HttpMethod { get; protected set; }

    public virtual string Url { get; protected set; }

    public virtual int? HttpStatusCode { get; set; }
}