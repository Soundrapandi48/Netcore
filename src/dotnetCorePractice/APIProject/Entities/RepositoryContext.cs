using APIProject.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProject.Entities
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<UserData> UserDetails { get; set; }
        public DbSet<ManuFacturer> ManuFacturers { get; set; }
    }
}
