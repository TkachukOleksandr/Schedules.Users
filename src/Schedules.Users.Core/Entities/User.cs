using Schedules.Nuget.Abstractions;
using Schedules.Nuget.Enums;

namespace Schedules.Users.Core.Entities;

public sealed class User : ITenantEntity, ISoftDeleteEntity
{
    private readonly List<Role> _roles = [];

    public required Guid Id { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string? MiddleName { get; init; }
    public required string Email { get; init; }
    public DateTime? BirthDate { get; init; }
    public SexType SexType { get; init; }
    public string? IdentityId { get; set; }

    public Guid? TenantId { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedOnUtc { get; set; }

    public IReadOnlyCollection<Role> Roles => _roles;
}
