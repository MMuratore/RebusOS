using GoRil.Tools.Domain;
using RebusOS.Domain.Users.ValueObjects;

namespace RebusOS.Domain.Users;

public class User : AggregateRoot<UserId, Guid>
{
}