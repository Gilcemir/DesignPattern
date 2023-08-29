using StatePatterns.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace StatePatterns.Permissions;

public class StatePatternsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StatePatternsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StatePatternsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StatePatternsResource>(name);
    }
}
