
using Schedules.Nuget.Abstractions;

namespace Schedules.Users.Core.Entities;

public sealed class Permission : ITenantEntity
{
    public required string Code { get; init; }
    public Guid? TenantId { get; set; }
}
