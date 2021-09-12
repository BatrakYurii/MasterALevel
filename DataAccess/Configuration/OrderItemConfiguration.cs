using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterALevel.DataAccess.Configuration
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.Property(t => t.OrderId).IsRequired();
            builder.Property(t => t.ProductId).IsRequired();
            builder.Property(t => t.Count).IsRequired();
        }
    }
}
