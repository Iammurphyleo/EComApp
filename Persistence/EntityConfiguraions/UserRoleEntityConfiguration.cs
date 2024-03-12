using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfiguraions
{
    public class UserRoleEntityConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable(name: nameof(UserRole));
            builder.HasKey(t => t.Id);

            builder.HasOne(t => t.Role)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(t => t.RoleId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.User)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(t => t.UserId)
                 .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
