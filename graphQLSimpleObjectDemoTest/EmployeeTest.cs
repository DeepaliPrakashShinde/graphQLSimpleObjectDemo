using GraphQL;
using GraphQL.Types;
using graphQLSimpleObjectDemo.GraphQL.Queries;
using graphQLSimpleObjectDemo.GraphQL.Schemas;
using graphQLSimpleObjectDemo.Interface;
using graphQLSimpleObjectDemo.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class EmployeeTest
    {
        private readonly List<Employee> _employees = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "John test",
                Age = 23,
                Email = "john@emp.com",
                Gender = "Male"
            },
            new Employee
            {
                Id = 2,
                Name = "Anne test",
                Age = 22,
                Email = "anne@emp.com",
                Gender = "Female"
            }
        };
        [TestCase]
        public void EmployeeTestSuccess()
        {
            Mock<IDependencyResolver> mockRepository = new Mock<IDependencyResolver>();
            EmployeeSchema controller = new EmployeeSchema(mockRepository.Object);


            Mock<IEmployeeRepo> mockEmp = new Mock<IEmployeeRepo>();
            mockEmp.Setup(m => m.GetEmployees()).Returns(_employees);
            Schema schema = new Schema { Query = new EmployeeQuery(mockEmp.Object) };

            string json = controller.Execute(_ =>
            {
                _.Schema = schema;
                _.Query = "{employees{name}}";
            });
            string expectedData = _employeesName.Replace("'", "\"");
            Assert.True(json.Equals(expectedData));
        }

        private readonly string _employeesName = "{\r\n  \"data\": {\r\n    \"employees\": [\r\n      {\r\n        \"name\": \"John test\"\r\n      },\r\n      {\r\n        \"name\": \"Anne test\"\r\n      }\r\n    ]\r\n  }\r\n}";
    }
}

