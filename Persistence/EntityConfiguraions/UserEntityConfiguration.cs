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
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(t => t.Id);

            builder.HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.UserRoles)
                .WithOne(x => x.User) 
                .HasForeignKey(x => x.UserId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.FirstName)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.LastName)
             .HasMaxLength(10)
             .IsRequired();

            builder.Property(x => x.PhoneNumber)
             .HasMaxLength(15)
             .IsRequired();

            builder.Property(x => x.Address)
             .HasMaxLength(20)
             .IsRequired();

            builder.Property(u => u.Email)
                .HasMaxLength(500)
                .IsRequired();

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(user => user.PasswordHash)
                .HasMaxLength(750)
                .IsRequired();

            builder.Property(user => user.HashSalt)
                .HasMaxLength(700)
                .IsRequired();


        }
    }
}
