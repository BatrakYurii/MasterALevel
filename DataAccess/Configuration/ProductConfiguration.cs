using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterALevel.DataAccess.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(t => t.CategoryId).IsRequired();
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Price).IsRequired();
        }
    }
}
