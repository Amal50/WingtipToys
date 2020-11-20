using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WingtipToys.Domain.Entities;

namespace WingtipToys.Presistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.ProductID);
            builder.Property(e => e.ProductName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Description).IsRequired();
            
            builder.HasOne(d => d.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}