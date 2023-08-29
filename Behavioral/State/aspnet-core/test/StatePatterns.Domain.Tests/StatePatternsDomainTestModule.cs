using StatePatterns.MongoDB;
using Volo.Abp.Modularity;

namespace StatePatterns;

[DependsOn(
    typeof(StatePatternsMongoDbTestModule)
    )]
public class StatePatternsDomainTestModule : AbpModule
{

}
