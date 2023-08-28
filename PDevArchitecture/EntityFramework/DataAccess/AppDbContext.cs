using Microsoft.EntityFrameworkCore;
using PDevArchitecture.EntityFramework.Entities;

namespace PDevArchitecture.EntityFramework.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee>? Employees { get; set; }


    }
}
