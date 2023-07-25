using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SuperAbp.AuditLogging.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AuditLoggingDbContextFactory : IDesignTimeDbContextFactory<AuditLoggingDbContext>
{
    public AuditLoggingDbContext CreateDbContext(string[] args)
    {
        AuditLoggingEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AuditLoggingDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AuditLoggingDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SuperAbp.AuditLogging.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
