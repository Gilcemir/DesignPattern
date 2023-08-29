using Volo.Abp.Modularity;

namespace StatePatterns;

[DependsOn(
    typeof(StatePatternsApplicationModule),
    typeof(StatePatternsDomainTestModule)
    )]
public class StatePatternsApplicationTestModule : AbpModule
{

}
