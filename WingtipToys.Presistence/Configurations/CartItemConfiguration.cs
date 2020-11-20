using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WingtipToys.Domain.Entities;

namespace WingtipToys.Presistence.Configurations
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(e => e.ItemId);
            builder.Property(e => e.ItemId).IsRequired().HasMaxLength(128).ValueGeneratedNever();

            builder.HasOne(d => d.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(d => d.ProductId);
        }
    }
}
