using Microsoft.EntityFrameworkCore;
using MyCompanyAPI.Models;

namespace MyCompanyAPI.Data
{
    public class MyCompanyDbContext : DbContext
    {
        public MyCompanyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
