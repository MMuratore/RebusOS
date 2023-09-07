using GoRil.Tools.Domain;

namespace RebusOS.Domain.Users.ValueObjects;

public sealed class UserId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}