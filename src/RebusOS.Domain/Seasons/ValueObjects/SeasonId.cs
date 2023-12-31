﻿using GoRil.Tools.Domain;

namespace RebusOS.Domain.Seasons.ValueObjects;

public sealed class SeasonId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}