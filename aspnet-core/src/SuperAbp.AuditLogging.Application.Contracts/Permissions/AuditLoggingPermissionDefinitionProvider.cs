using SuperAbp.AuditLogging.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SuperAbp.AuditLogging.Permissions;

public class AuditLoggingPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AuditLoggingPermissions.GroupName, L("Permission:AuditLogging"));

        var auditLogs = myGroup.AddPermission(AuditLoggingPermissions.AuditLogs.Default, L("Permission:AuditLogs"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AuditLoggingResource>(name);
    }
}