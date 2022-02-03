using Microsoft.EntityFrameworkCore;

namespace Core_Web_API.Models
{
    public class CinemaDbContext:DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options)
        {

             public DbSet<UsersInfo> UsersInfo { get; set; }
             public DbSet<Cinema> Cinema { get; set; }

    }

    }
}
