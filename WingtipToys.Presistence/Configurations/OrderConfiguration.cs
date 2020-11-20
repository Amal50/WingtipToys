using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WingtipToys.Domain.Entities;

namespace WingtipToys.Presistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.OrderId);
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(160);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(160);
            builder.Property(e => e.Address).IsRequired().HasMaxLength(70);
            builder.Property(e => e.City).IsRequired().HasMaxLength(40);
            builder.Property(e => e.State).IsRequired().HasMaxLength(40);
            builder.Property(e => e.PostalCode).IsRequired().HasMaxLength(10);
            builder.Property(e => e.Country).IsRequired().HasMaxLength(40);
            builder.Property(e => e.Phone).IsRequired(false).HasMaxLength(24);
            builder.Property(e => e.Email).IsRequired();
            builder.Property(e => e.Total).HasPrecision(18,2);
        }
    }
}
