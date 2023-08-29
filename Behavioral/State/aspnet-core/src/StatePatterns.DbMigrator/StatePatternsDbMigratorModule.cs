using StatePatterns.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace StatePatterns.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StatePatternsMongoDbModule),
    typeof(StatePatternsApplicationContractsModule)
    )]
public class StatePatternsDbMigratorModule : AbpModule
{
}
