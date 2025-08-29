using Schedules.Nuget.Abstractions;

namespace Schedules.Users.Core.Entities;

public sealed class Tenant : ISoftDeleteEntity
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }

    public DateTime CreatedOnUtc { get; init; }
    public DateTime? ModifiedOnUtc { get; init; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedOnUtc { get; set; }
}
