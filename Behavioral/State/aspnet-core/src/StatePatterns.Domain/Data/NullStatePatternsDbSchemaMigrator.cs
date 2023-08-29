using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace StatePatterns.Data;

/* This is used if database provider does't define
 * IStatePatternsDbSchemaMigrator implementation.
 */
public class NullStatePatternsDbSchemaMigrator : IStatePatternsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
