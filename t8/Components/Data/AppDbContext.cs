using Microsoft.EntityFrameworkCore;
using t8.Models;

namespace t8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Detenido> Detenidos { get; set; }
    }
}
