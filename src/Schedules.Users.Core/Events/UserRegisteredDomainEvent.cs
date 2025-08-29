using Schedules.Nuget.Abstractions;
using Schedules.Nuget.Enums;

namespace Schedules.Users.Core.Events;

public sealed record UserRegisteredDomainEvent : DomainEvent
{
    public required Guid UserId { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string? MiddleName { get; init; }
    public required string Email { get; init; }
    public DateTime? BirthDate { get; init; }
    public SexType SexType { get; init; }
    public string? IdentityId { get; set; }
}
