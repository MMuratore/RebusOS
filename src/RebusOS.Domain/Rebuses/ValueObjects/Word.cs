using ErrorOr;
using GoRil.Tools.Domain;
using RebusOS.Domain.Common.Interfaces;

namespace RebusOS.Domain.Rebuses.ValueObjects;

public sealed class Word : ValueObject
{
    private Word(string value) => Value = value;

    public string Value { get; private set; }

    public async Task<ErrorOr<Word>> Create(string value, IWordChecker checker)
    {
        if (await checker.IsValidWord(value)) return Errors.Word.UnknownWord;

        return new Word(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}