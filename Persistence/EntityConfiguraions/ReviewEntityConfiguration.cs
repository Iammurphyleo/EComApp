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
    public class ReviewEntityConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.Reviews)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Brand)
                .WithMany(x => x.Reviews)
                .HasForeignKey(x => x.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Comment)
                   .HasMaxLength(500);

            builder.Property(x => x.Ratings);
            builder.Property(x => x.DisLike);
            builder.Property(x => x.Like);









        }
    }
}
