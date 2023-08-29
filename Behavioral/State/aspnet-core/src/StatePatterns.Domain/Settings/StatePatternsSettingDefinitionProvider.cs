using Volo.Abp.Settings;

namespace StatePatterns.Settings;

public class StatePatternsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StatePatternsSettings.MySetting1));
    }
}
