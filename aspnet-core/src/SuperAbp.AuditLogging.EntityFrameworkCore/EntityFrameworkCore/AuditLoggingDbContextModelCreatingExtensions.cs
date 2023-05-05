using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp;
using Volo.Abp.AuditLogging.EntityFrameworkCore;

namespace SuperAbp.AuditLogging.EntityFrameworkCore;

public static class AuditLoggingDbContextModelCreatingExtensions
{
    public static void ConfigureSuperAbpAuditLogging(
        this ModelBuilder builder,
            Action<AuditLoggingModelBuilderConfigurationOptions> optionsAction = null)
    {
        Check.NotNull(builder, nameof(builder));

        var options = new AuditLoggingModelBuilderConfigurationOptions(
                AuditLoggingDbProperties.DbTablePrefix,
                AuditLoggingDbProperties.DbSchema
            );

        optionsAction?.Invoke(options);

        builder.ConfigureAuditLogging();
    }
}