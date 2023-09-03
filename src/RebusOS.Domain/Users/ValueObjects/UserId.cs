using GoRil.Tools.Domain;

namespace RebusOS.Domain.Users.ValueObjects;

public class UserId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }
    protected override IEnumerable<object> GetEqualityComponents() => throw new NotImplementedException();
}