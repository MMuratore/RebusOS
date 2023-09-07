using ErrorOr;

namespace RebusOS.Domain.Rebuses.Errors;

public static class Word
{
    public static Error UnknownWord =
        Error.Conflict(nameof(UnknownWord), Resources.Rebus.Word_UnknownWord);
}