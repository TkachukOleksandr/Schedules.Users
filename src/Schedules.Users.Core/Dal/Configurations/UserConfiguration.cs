using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedules.Users.Core.Entities;

namespace Schedules.Users.Core.Dal.Configurations;

internal sealed class UserConfiguration
    : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).ValueGeneratedNever();

        builder.Property(u => u.FirstName)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(u => u.LastName)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(u => u.SexType)
            .HasConversion<string>();

        builder.HasIndex(u => u.Email).IsUnique();
        builder.HasIndex(u => u.IdentityId).IsUnique();
        builder.HasIndex(u => u.TenantId);

        builder.HasOne<Tenant>()
           .WithMany()
           .HasForeignKey(r => r.TenantId)
           .IsRequired(false)
           .OnDelete(DeleteBehavior.SetNull);
    }
}
