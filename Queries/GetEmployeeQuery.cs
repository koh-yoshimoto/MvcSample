using System.Linq;
using MvcSample.Queries.Dtos;

namespace MvcSample.Queries {
    public interface IGetEmployeeQuery
    {
        EmployeeDto Execute();
    }

    public class GetEmployeeQuery : IGetEmployeeQuery
    {
        public EmployeeDto Execute()
        {
            var repos = ServiceLocator.GetEmployeeRepository();

            var e = repos.GetAll().First();

            return new EmployeeDto
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastrName = e.LastrName,
                Salary = e.Salary
            };

        }
    }
}