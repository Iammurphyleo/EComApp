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
    internal class OrderProductEntityConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.ToTable(nameof(OrderProduct));
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.OrderProducts)
                .HasForeignKey(x => x.ProductId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderProducts)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Quantity)
                .IsRequired();

            builder.Property(p => p.UnitPrice)
              .IsRequired()
              .HasColumnType("decimal(18, 2)");
        }
    }
}
