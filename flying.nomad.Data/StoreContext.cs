using flying.nomad.Domain.Orders;
using flying.nomad.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using flying.nomad.Data.Initializers;

namespace flying.nomad.Data {
    public class StoreContext : DbContext {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
}

        }
    }
