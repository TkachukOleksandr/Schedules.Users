using Schedules.Nuget.Abstractions;
using Schedules.Nuget.Enums;

namespace Schedules.Users.Core.Events;

public sealed record UserModifiedDomainEvent : DomainEvent
{
    public required Guid UserId { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string? MiddleName { get; init; }
    public DateTime? BirthDate { get; init; }
}
