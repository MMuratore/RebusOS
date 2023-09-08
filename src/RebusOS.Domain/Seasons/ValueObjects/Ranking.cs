using GoRil.Tools.Domain;

namespace RebusOS.Domain.Seasons.ValueObjects;

public sealed class Ranking : ValueObject
{
    private readonly List<Result> _results = new();

    public Ranking(RankingRules rules) => Rules = rules;

    private RankingRules Rules { get; set; }

    public IReadOnlyCollection<Result> Results => _results.AsReadOnly();

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return _results;
    }
}