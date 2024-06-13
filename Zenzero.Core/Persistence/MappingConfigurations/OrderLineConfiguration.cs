using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zenzero.Core.Models;

namespace Zenzero.Core.Persistence.MappingConfigurations
{
    internal sealed class OrderLineConfiguration : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.Property(x => x.ProductName)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
