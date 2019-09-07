using GraphQL.Types;
using graphQLSimpleObjectDemo.Models;

namespace graphQLSimpleObjectDemo.GraphQL.Types
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(x => x.Id, type: typeof(IntGraphType)).Description("Unique Employee Id");
            Field(x => x.Name).Description("Name of the Employee");
            Field(x => x.Age).Description("Age of the Employee");
            Field(x => x.Gender).Description("Gender of the Employee");
            Field(x => x.Email).Description("Email of the Employee");
        }
    }
}
