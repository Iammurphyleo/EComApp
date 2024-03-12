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
    public class PaymentEntityConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable(nameof(Payment));
            builder.HasKey(p => p.Id);

            builder.HasOne(x => x.Order)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User)
                    .WithMany(x => x.Payments)
                    .HasForeignKey(x => x.UserId);

            builder.Property(x => x.PaymentReference)
                .IsRequired();

            builder.Property(p => p.Amount)
           .IsRequired()
           .HasColumnType("decimal(18, 2)");

            builder.Property(w => w.Status)
            .HasConversion<int>()
                .IsRequired();

        }
    }
}
