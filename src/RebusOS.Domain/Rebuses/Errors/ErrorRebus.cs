using ErrorOr;

namespace RebusOS.Domain.Rebuses.Errors;

public static partial class Errors
{
    public static class Rebus
    {
        public static Error DuplicateAnswer =
            Error.Conflict(nameof(DuplicateAnswer), "Answer with given value already exists.");
    }
}