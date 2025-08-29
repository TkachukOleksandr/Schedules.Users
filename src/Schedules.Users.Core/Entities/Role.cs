using Schedules.Nuget.Abstractions;

namespace Schedules.Users.Core.Entities;

public sealed class Role : ITenantEntity
{
    public required string Name { get; init; }
    public Guid? TenantId { get; set; }
}
