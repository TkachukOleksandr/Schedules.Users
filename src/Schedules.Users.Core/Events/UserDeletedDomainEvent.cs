using Schedules.Nuget.Abstractions;

namespace Schedules.Users.Core.Events;

public sealed record UserDeletedDomainEvent : DomainEvent
{
    public required Guid UserId { get; init; }
}
