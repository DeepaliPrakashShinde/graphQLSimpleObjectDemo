using GraphQL.Types;
using graphQLSimpleObjectDemo.GraphQL.Types;
using graphQLSimpleObjectDemo.Interface;

namespace graphQLSimpleObjectDemo.GraphQL.Queries
{
    public class EmployeeQuery : ObjectGraphType
    {
        public EmployeeQuery(IEmployeeRepo employee)
        {
            Field<ListGraphType<EmployeeType>>(
             "employees",
              resolve: context => employee.GetEmployees()
          );
        }
    }
}
