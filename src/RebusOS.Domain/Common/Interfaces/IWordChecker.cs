namespace RebusOS.Domain.Common.Interfaces;

public interface IWordChecker
{
    public Task<bool> IsValidWord(string value);
}