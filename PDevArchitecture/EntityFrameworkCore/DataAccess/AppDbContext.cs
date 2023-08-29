using Microsoft.EntityFrameworkCore;

namespace PDevArchitecture.EntityFrameworkCore.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }



    }
}
