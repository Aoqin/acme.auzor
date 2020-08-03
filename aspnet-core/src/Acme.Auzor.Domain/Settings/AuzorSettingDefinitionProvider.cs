using Volo.Abp.Settings;

namespace Acme.Auzor.Settings
{
    public class AuzorSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AuzorSettings.MySetting1));
        }
    }
}
