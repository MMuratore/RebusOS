using ErrorOr;

namespace RebusOS.Domain.Seasons.Errors;

public static partial class Errors
{
    public static class Season
    {
        public static Error DuplicatePlayer = Error.Conflict(nameof(DuplicatePlayer), "Player already exists.");
    }
}