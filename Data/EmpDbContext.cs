using Microsoft.EntityFrameworkCore;
using MvcSample.Data.Entities;

namespace MvcSample.Data
{
    public class EmpDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

    }
}