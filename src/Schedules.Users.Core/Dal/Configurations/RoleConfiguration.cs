using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedules.Users.Core.Entities;

namespace Schedules.Users.Core.Dal.Configurations;

internal sealed class RoleConfiguration
    : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("roles");

        builder.HasKey(r => r.Name);
        builder.Property(r => r.Name).HasMaxLength(256);

        builder
           .HasMany<User>()
           .WithMany(u => u.Roles)
           .UsingEntity(joinBuilder =>
           {
               joinBuilder.ToTable("user_roles");

               joinBuilder.Property("RolesName").HasColumnName("role_name");
           });

        builder.HasOne<Tenant>()
            .WithMany()
            .HasForeignKey(r => r.TenantId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
