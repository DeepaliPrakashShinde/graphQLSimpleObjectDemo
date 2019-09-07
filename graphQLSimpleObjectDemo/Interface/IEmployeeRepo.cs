using graphQLSimpleObjectDemo.Models;
using System.Collections.Generic;

namespace graphQLSimpleObjectDemo.Interface
{
    public interface IEmployeeRepo
    {
        List<Employee> GetEmployees();
    }
}
