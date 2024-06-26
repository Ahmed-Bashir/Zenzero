using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zenzero.Core.Models;

namespace Zenzero.Core.Persistence
{
    internal sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.CustomerName)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(x => x.OrderDateInitial)
                .IsRequired();

            builder.Property(x => x.TotalAmount)
                .IsRequired();

            builder.HasMany(x => x.OrderLines)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);
        }
    }
}
