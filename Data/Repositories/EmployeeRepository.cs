using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MvcSample.Data.Entities;

namespace MvcSample.Data.Repositories {
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            var context = new EmpDbContext();
            return context.Employees.AsNoTracking().ToList();
        }
    }
}