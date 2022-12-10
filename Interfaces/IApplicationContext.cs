using HW2.Models;
using Microsoft.EntityFrameworkCore;

namespace HW2.Interfaces
{
    public interface IApplicationContext
    {
        DbSet<Friend> Friends { get; }

        public int SaveChanges();    
    }
}
