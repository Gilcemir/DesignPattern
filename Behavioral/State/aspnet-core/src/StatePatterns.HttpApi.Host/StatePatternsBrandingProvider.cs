using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace StatePatterns;

[Dependency(ReplaceServices = true)]
public class StatePatternsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StatePatterns";
}
