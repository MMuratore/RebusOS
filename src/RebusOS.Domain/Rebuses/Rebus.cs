using ErrorOr;
using GoRil.Tools.Domain;
using RebusOS.Domain.Rebuses.ValueObjects;
using RebusOS.Domain.Users.ValueObjects;

namespace RebusOS.Domain.Rebuses;

public sealed class Rebus : AggregateRoot<RebusId, Guid>
{
    private readonly List<Answer> _answers = new();

    public Rebus(UserId creatorId, Word solution)
    {
        Creator = creatorId;
        Solution = solution;
    }

    public Word Solution { get; private set; }
    public UserId Creator { get; private set; }

    public IReadOnlyCollection<Answer> Answers => _answers.AsReadOnly();

    public ErrorOr<Success> SubmitAnswer(Answer answer)
    {
        if (answer.PlayerId == Creator) return Errors.Rebus.CreatorCannotSubmitAnswer;

        if (_answers.Contains(answer)) return Errors.Rebus.DuplicateAnswer;

        _answers.Add(answer);
        return Result.Success;
    }
}