using Volo.Abp.Reflection;

namespace SuperAbp.AuditLogging.Permissions;

public class AuditLoggingPermissions
{
    public const string GroupName = "AuditLogging";

    public static class AuditLogs
    {
        public const string Default = GroupName + ".AuditLog";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AuditLoggingPermissions));
    }
}