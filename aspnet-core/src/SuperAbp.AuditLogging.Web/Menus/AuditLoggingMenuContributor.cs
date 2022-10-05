using SuperAbp.AuditLogging.Permissions;
using System.Threading.Tasks;
using SuperAbp.AuditLogging.Localization;
using Volo.Abp.UI.Navigation;

namespace SuperAbp.AuditLogging.Web.Menus;

public class AuditLoggingMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        if (await context.IsGrantedAsync(AuditLoggingPermissions.AuditLogs.Default))
        {
            var l = context.GetLocalizer<AuditLoggingResource>();

            context.Menu.GetAdministration().AddItem(new ApplicationMenuItem(AuditLoggingMenus.Prefix, displayName: l["AuditLogging"], "~/AuditLogging", icon: "fa fa-globe"));
        }
    }
}