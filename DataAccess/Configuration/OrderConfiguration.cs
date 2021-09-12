using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterALevel.DataAccess.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(t => t.UserId).IsRequired();
            builder.Property(t => t.DiscountId).IsRequired();
            builder.Property(t => t.Total).IsRequired();
        }
    }
}
