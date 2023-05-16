using Volo.Abp.Settings;

namespace SuperAbp.AuditLogging.Settings;

public class AuditLoggingSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AuditLoggingSettings.MySetting1));
    }
}
