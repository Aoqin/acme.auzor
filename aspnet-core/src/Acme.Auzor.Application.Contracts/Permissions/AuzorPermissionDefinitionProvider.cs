using Acme.Auzor.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.Auzor.Permissions
{
    public class AuzorPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AuzorPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AuzorPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AuzorResource>(name);
        }
    }
}
