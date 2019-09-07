using graphQLSimpleObjectDemo.Models;
using System.Collections.Generic;

namespace graphQLSimpleObjectDemo.Interface
{
    internal interface IEmployeeRepo
    {
        List<Employee> GetEmployees();
    }
}
