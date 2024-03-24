using DoIT.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DoIT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lector> Lectors { get; set; }
    }
}
