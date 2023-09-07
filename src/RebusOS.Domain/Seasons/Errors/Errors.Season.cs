using ErrorOr;

namespace RebusOS.Domain.Seasons.Errors;

public static class Errors
{
    public static class Season
    {
        public static Error DuplicatePlayer =
            Error.Conflict(nameof(DuplicatePlayer), Resources.Season.Season_DuplicatePlayer);
    }
}