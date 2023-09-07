using GoRil.Tools.Domain;
using RebusOS.Domain.Users.ValueObjects;

namespace RebusOS.Domain.Rebuses.ValueObjects;

public sealed class Answer : ValueObject
{
    private Answer(UserId userId, Word proposition, DateTimeOffset submitAt)
    {
        PlayerId = userId;
        Proposition = proposition;
        SubmitAt = submitAt;
    }

    public Word Proposition { get; private set; }
    public UserId PlayerId { get; private set; }
    public DateTimeOffset SubmitAt { get; private set; }

    public static Answer Create(UserId userId, Word proposition, TimeProvider timeProvider) =>
        new(userId, proposition, timeProvider.GetUtcNow());

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Proposition;
        yield return PlayerId;
    }
}