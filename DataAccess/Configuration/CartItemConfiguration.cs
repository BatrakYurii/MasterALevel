using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterALevel.DataAccess.Configuration
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.Property(t => t.CartId).IsRequired();
            builder.Property(t => t.ProductId).IsRequired();
            builder.Property(t => t.Count).IsRequired();
        }
    }
}
