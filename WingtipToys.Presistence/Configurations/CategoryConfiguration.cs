using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WingtipToys.Domain.Entities;

namespace WingtipToys.Presistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.CategoryID);
            builder.Property(e => e.CategoryName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Description).IsRequired();
        }
    }
}