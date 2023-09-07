using GoRil.Tools.Domain;

namespace RebusOS.Domain.Rebuses.ValueObjects;

public sealed class RebusId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}