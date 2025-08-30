using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedules.Users.Core.Entities;

namespace Schedules.Users.Core.Dal.Configurations;

internal sealed class TenantConfiguration
    : IEntityTypeConfiguration<Tenant>
{
    public void Configure(EntityTypeBuilder<Tenant> builder)
    {
        builder.ToTable("tenants");

        builder.HasKey(t => t.Id);
        builder.Property(t => t.Id).ValueGeneratedNever();

        builder.Property(x => x.Name).IsRequired();
        builder.HasIndex(t => t.Name).IsUnique();
    }
}
