using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterALevel.DataAccess.Configuration
{
    public class UserAddressConfiguration : IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.Property(t => t.UserId).IsRequired();
            builder.Property(t => t.CountryCode).IsRequired().HasMaxLength(50);
            builder.Property(t => t.State).IsRequired().HasMaxLength(7);
            builder.Property(t => t.City).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Address).IsRequired().HasMaxLength(50);
            builder.Property(t => t.PhoneNumber).IsRequired().HasMaxLength(50);
        }
    }
}
