using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedules.Users.Core.Entities;

namespace Schedules.Users.Core.Dal.Configurations;

internal sealed class PermissionConfiguration
    : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.ToTable("permissions");

        builder.HasKey(p => p.Code);
        builder.Property(p => p.Code).HasMaxLength(100);

        builder
            .HasMany<Role>()
            .WithMany()
            .UsingEntity(joinBuilder =>
            {
                joinBuilder.ToTable("role_permissions");
            });

        builder.HasOne<Tenant>()
          .WithMany()
          .HasForeignKey(r => r.TenantId)
          .IsRequired(false)
          .OnDelete(DeleteBehavior.SetNull);
    }
}
