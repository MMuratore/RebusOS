using GoRil.Tools.Domain;
using RebusOS.Domain.Seasons.ValueObjects;

namespace RebusOS.Domain.Seasons;

public sealed class Season : AggregateRoot<SeasonId, Guid>
{
}