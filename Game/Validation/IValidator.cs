namespace GameLogic.Library.Validation
{
    public interface IValidator
    {
        bool ValidateLetter(string? letter);
        bool ValidateWord(string? word);
        bool ValidateNumber(string? number);
    }
}