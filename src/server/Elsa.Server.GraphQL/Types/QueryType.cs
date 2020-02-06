using HotChocolate.Types;

namespace Elsa.Server.GraphQL.Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(x => x.GetWorkflowDefinitions(default, default, default, default))
                .Argument("version", x => x.Type<VersionOptionsInputType>());
            
            descriptor
                .Field(x => x.GetWorkflowDefinition(default, default, default, default, default, default))
                .Argument("id", x => x.Type<IdType>())
                .Argument("definitionId", x => x.Type<IdType>())
                .Argument("version", x => x.Type<VersionOptionsInputType>());
        }
    }
}