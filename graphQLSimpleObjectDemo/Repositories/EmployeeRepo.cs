using graphQLSimpleObjectDemo.Interface;
using graphQLSimpleObjectDemo.Models;
using System.Collections.Generic;

namespace graphQLSimpleObjectDemo.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private static readonly List<Employee> _employees = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Age = 23,
                Email = "john@emp.com",
                Gender = "Male"
            },
            new Employee
            {
                Id = 2,
                Name = "Anne",
                Age = 22,
                Email = "anne@emp.com",
                Gender = "Female"
            },
            new Employee
            {
                Id = 3,
                Name = "Jennifer",
                Age = 25,
                Email = "jennifer@emp.com",
                Gender = "Female"
            },
             new Employee
            {
                Id = 4,
                Name = "Benjamin",
                Age = 25,
                Email = "benjamin@emp.com",
                Gender = "Male"
            }
        };

        public List<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
