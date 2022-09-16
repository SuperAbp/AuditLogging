using System;
using System.Collections.Generic;
using System.Text;

namespace SuperAbp.AuditLogging.Dtos
{
    public class AuditLogActionDetailDto
    {
        public virtual string ServiceName { get; protected set; }

        public virtual string MethodName { get; protected set; }

        public virtual string Parameters { get; protected set; }

        public virtual DateTime ExecutionTime { get; protected set; }

        public virtual int ExecutionDuration { get; protected set; }
    }
}