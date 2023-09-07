using ErrorOr;

namespace RebusOS.Domain.Rebuses.Errors;

public static class Rebus
{
    public static Error DuplicateAnswer =
        Error.Conflict(nameof(DuplicateAnswer), Resources.Rebus.Rebus_DuplicateAnswer);
}