using HW2.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HW2.Models
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public DbSet<Friend> Friends { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
