using ErrorOr;

namespace RebusOS.Domain.Rebuses.Errors;

public static class Rebus
{
    public static Error DuplicateAnswer =
        Error.Conflict(nameof(DuplicateAnswer), Resources.Rebus.Rebus_DuplicateAnswer);

    public static Error CreatorCannotSubmitAnswer =
        Error.Conflict(nameof(CreatorCannotSubmitAnswer), Resources.Rebus.Rebus_CreatorCannotSubmitAnswer);
}