using Microsoft.EntityFrameworkCore;
using PDevArchitecture.Demonstrations.Entities;

namespace PDevArchitecture.EntityFrameworkCore.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        DbSet<Book>? Books { get; set; }

    }
}
