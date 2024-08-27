using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class ItemDbContext : DbContext
    {
        public ItemDbContext(DbContextOptions options) : base(options)
        {
        }
        DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ItemDbContext).Assembly);
        }
    }
}
