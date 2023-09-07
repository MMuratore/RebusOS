using GoRil.Tools.Domain;
using RebusOS.Domain.Users.ValueObjects;

namespace RebusOS.Domain.Seasons.ValueObjects;

public sealed class Result : ValueObject
{
    public Result(UserId playerId, int score)
    {
        PlayerId = playerId;
        Score = score;
    }

    public UserId PlayerId { get; private set; }
    public int Score { get; private set; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return PlayerId;
        yield return Score;
    }
}