using GoRil.Tools.Domain;

namespace RebusOS.Domain.Rebuses.ValueObjects;

public class RebusId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }
    protected override IEnumerable<object> GetEqualityComponents() => throw new NotImplementedException();
}