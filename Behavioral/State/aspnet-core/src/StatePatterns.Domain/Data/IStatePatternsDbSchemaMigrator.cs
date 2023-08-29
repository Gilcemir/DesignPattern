using System.Threading.Tasks;

namespace StatePatterns.Data;

public interface IStatePatternsDbSchemaMigrator
{
    Task MigrateAsync();
}
