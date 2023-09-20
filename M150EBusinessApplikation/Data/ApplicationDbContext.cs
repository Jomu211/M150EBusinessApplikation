using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace M150EBusinessApplikation.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Champion> Champions { get; set; }
        public DbSet<Head> Heads { get; set; }
        public DbSet<UserGameChampion> UserGameChampions { get; set; }
        public DbSet<UserProfil> UserProfiles { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
    }
}