using StatePatterns.MongoDB;
using Xunit;

namespace StatePatterns;

[CollectionDefinition(StatePatternsTestConsts.CollectionDefinitionName)]
public class StatePatternsApplicationCollection : StatePatternsMongoDbCollectionFixtureBase
{

}
