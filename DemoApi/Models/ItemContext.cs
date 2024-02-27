using Microsoft.EntityFrameworkCore;

namespace DemoApi.Models
{
    public class ItemContext(DbContextOptions<ItemContext> options) : DbContext(options)
    {
        public DbSet<Item> Items { get; set; } = null!;
    }
}
