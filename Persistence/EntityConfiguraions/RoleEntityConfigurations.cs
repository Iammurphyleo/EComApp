using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Constant;
using System.Reflection.Emit;

namespace Persistence.EntityConfiguraions
{
    public class RoleEntityConfigurations : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable(nameof(Role));
            builder.HasKey(x => x.Id);

            builder.ToTable("Role").HasData(
                new Role { Id = Guid.NewGuid(), Name = ApplicationRoleName.Admin },
                new Role { Id = Guid.NewGuid(), Name = ApplicationRoleName.Customer },
                new Role { Id = Guid.NewGuid(), Name = ApplicationRoleName.SuperAdmin },
                new Role { Id = Guid.NewGuid(), Name = ApplicationRoleName.AllRole }
                );

            builder.Property(r => r.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.HasIndex(r => r.Name)
            .IsUnique();


            builder
            .HasMany(r => r.UserRoles)
            .WithOne(ur => ur.Role)
            .HasForeignKey(ur => ur.RoleId);

        }
    }
}
