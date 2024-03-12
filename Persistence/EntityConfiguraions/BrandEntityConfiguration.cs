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
    public class BrandEntityConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable(nameof(Brand));
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Product)
            .WithMany(x => x.Brands)
            .HasForeignKey(x => x.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
            

            builder.HasMany(x => x.Reviews)
                .WithOne(x => x.Brand)
                .HasForeignKey(x => x.BrandId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(10);
        }
    }
}
