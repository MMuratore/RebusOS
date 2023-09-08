using ErrorOr;
using GoRil.Tools.Domain;
using RebusOS.Domain.Rebuses.ValueObjects;
using RebusOS.Domain.Seasons.Enums;
using RebusOS.Domain.Seasons.ValueObjects;
using RebusOS.Domain.Users.ValueObjects;
using Result = RebusOS.Domain.Seasons.ValueObjects.Result;

namespace RebusOS.Domain.Seasons;

public sealed class Season : AggregateRoot<SeasonId, Guid>
{
    private readonly List<UserId> _players = new();

    private readonly List<RebusId> _rebuses = new();

    private Season(UserId administrator, string name, RankingRules rules, SeasonId? lastSeason)
    {
        Administrator = administrator;
        Name = name;
        LastSeason = lastSeason;
        Ranking = new Ranking(rules);
        Status = SeasonStatus.Open;
    }

    private Ranking Ranking { get; set; }
    public UserId Administrator { get; private set; }
    public string Name { get; private set; }
    public SeasonStatus Status { get; private set; }
    public SeasonId? LastSeason { get; private set; }
    public IReadOnlyCollection<Result> Board => Ranking.Results;

    public ErrorOr<Season>
        Open(UserId administrator, string name, RankingRules rules, SeasonId? lastSeason = default) =>
        new Season(administrator, name, rules, lastSeason);
}