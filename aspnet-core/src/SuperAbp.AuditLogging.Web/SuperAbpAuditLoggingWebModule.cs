using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using SuperAbp.AspNetCore.Mvc.UI.Packages.Select2.Theme;
using SuperAbp.AuditLogging.Localization;
using SuperAbp.AuditLogging.Web.Menus;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;
using SuperAbp.AuditLogging.Permissions;
using Volo.Abp.Json;

namespace SuperAbp.AuditLogging.Web;

[DependsOn(
    typeof(SuperAbpAuditLoggingApplicationContractsModule),
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAutoMapperModule),
    typeof(SuperAbpAspNetCoreMvcUiSelect2ThemeModule)
    )]
public class SuperAbpAuditLoggingWebModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(typeof(AuditLoggingResource), typeof(SuperAbpAuditLoggingWebModule).Assembly);
        });

        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(SuperAbpAuditLoggingWebModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpJsonOptions>(options =>
        {
            options.DefaultDateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        });
        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new AuditLoggingMenuContributor());
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SuperAbpAuditLoggingWebModule>();
        });

        context.Services.AddAutoMapperObjectMapper<SuperAbpAuditLoggingWebModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<SuperAbpAuditLoggingWebModule>(validate: true);
        });

        Configure<RazorPagesOptions>(options =>
        {
            //Configure authorization.
        });
    }
}