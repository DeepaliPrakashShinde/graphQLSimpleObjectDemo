using GraphQL;
using GraphQL.Types;
using graphQLSimpleObjectDemo.GraphQL.Queries;

namespace graphQLSimpleObjectDemo.GraphQL.Schemas
{
    public class EmployeeSchema : Schema
    {
        public EmployeeSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<EmployeeQuery>();
        }
    }
}
