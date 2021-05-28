using System.Collections.Generic;
using MvcSample.Data.Entities;
using MvcSample.Data.Repositories;

namespace MvcSample {
    public static class ServiceLocator {
        public static IEmployeeRepository GetEmployeeRepository() {
            return new DummyEmployeeRepository();
        }
    }

    public class DummyEmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return new List<Employee>() {
                new Employee { Id = 1, FirstName = "太郎", LastrName = "山田"}
            };
        }
    }
}