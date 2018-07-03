using GamesPortal.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GamesPortal.DAL.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Score> Scores { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {    
        }
    }
}
