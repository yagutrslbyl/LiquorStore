using LiquorStore.Models;
using Microsoft.EntityFrameworkCore;

namespace LiquorStore.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option): base(option)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }



    }
}
