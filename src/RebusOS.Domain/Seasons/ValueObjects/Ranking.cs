using GoRil.Tools.Domain;

namespace RebusOS.Domain.Seasons.ValueObjects;

public sealed class Ranking : ValueObject
{
    private readonly List<Result> _results = new();

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return _results;
    }
}