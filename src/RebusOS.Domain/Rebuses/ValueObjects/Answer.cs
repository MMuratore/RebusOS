using GoRil.Tools.Domain;

namespace RebusOS.Domain.Rebuses.ValueObjects;

public class Answer : ValueObject
{
    protected override IEnumerable<object> GetEqualityComponents() => throw new NotImplementedException();
}