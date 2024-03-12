using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfiguraions
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Brands)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.OrderProducts)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Reviews)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(10);
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18, 2)");

            builder.Property(w => w.Description)
               .HasMaxLength(int.MaxValue)
               .IsRequired();

            builder.Property(w => w.Images)
                .HasMaxLength(int.MaxValue)
                .IsRequired();

         
        }
    }
}
