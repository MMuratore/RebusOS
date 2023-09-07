using GoRil.Tools.Domain;
using RebusOS.Domain.Users.ValueObjects;

namespace RebusOS.Domain.Users;

public sealed class User : AggregateRoot<UserId, Guid>
{
}