using MongoDB.Driver;
using StatePatterns.Invoices;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace StatePatterns.MongoDB;

[ConnectionStringName("Default")]
public class StatePatternsMongoDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */
    public IMongoCollection<Invoice> Invoices => Collection<Invoice>();
    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //modelBuilder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}
