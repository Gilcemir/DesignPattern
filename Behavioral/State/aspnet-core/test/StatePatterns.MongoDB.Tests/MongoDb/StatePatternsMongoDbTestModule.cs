using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace StatePatterns.MongoDB;

[DependsOn(
    typeof(StatePatternsTestBaseModule),
    typeof(StatePatternsMongoDbModule)
    )]
public class StatePatternsMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = StatePatternsMongoDbFixture.GetRandomConnectionString();
        });
    }
}
