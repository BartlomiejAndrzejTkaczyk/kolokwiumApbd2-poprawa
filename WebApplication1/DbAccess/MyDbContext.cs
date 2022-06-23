using Microsoft.EntityFrameworkCore;
using WebApplication1.Extensions;
namespace WebApplication1.DbAccess
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MyDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            
        }
    }
}
