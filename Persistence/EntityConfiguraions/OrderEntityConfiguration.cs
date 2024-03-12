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
    public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(nameof(Order));
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Payment)
                .WithOne()
               .HasForeignKey<Order>(x => x.PaymentId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(false);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.OrderProducts)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);
            
            builder.Property(x => x.OrderReference)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(p => p.TotalPrice)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(w => w.Status)
             .HasConversion<int>()
             .IsRequired();




            /* builder.HasMany(x => x.Brands)
                 .WithOne(x => x.Product)
                 .HasForeignKey(x => x.ProductId);

             builder.HasMany(x => x.OrderProducts)
                 .WithOne(x => x.Product)
                 .HasForeignKey(x => x.ProductId);

             builder.HasMany(x => x.Reviews)
                 .WithOne(x => x.Product)
                 .HasForeignKey(x => x.ProductId);

             builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
             builder.Property(p => p.Price).HasColumnType("decimal(18, 2)");*/
        }

        
    }
}
