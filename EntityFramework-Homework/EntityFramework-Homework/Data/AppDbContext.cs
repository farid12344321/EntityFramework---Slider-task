using EntityFramework_Homework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Homework.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
    }
}
