namespace MergeConflicts
{
    public interface IValidator
    {
        bool IsValidInt(string input);

        bool IsValidDate(string input);

        bool IsValidString(string input);
    }
}
