using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SuperAbp.AuditLogging.EntityFrameworkCore
{
    public class AuditLoggingModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AuditLoggingModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {
        }
    }
}