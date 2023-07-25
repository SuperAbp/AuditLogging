using System.Threading.Tasks;

namespace SuperAbp.AuditLogging.Data;

public interface IAuditLoggingDbSchemaMigrator
{
    Task MigrateAsync();
}
