using Microsoft.EntityFrameworkCore;
using Zenzero.Core.Models;
using Zenzero.Core.Persistence.MappingConfigurations;

namespace Zenzero.Core.Persistence
{
    public sealed class ZenzeroContext : DbContext
    {
        public ZenzeroContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderLine> OrderLines { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); // Use default configuration.

            builder
            .ApplyConfiguration(new OrderConfiguration())
            .ApplyConfiguration(new OrderLineConfiguration());
        }
    }
}
