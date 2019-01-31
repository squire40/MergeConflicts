using System;

namespace MergeConflicts
{
    public class Validator : IValidator
    {
        public bool IsValidDate(string input)
        {
            DateTime result;

            return DateTime.TryParse(input, out result);
        }

        public bool IsValidInt(string input)
        {
            int result;

            return int.TryParse(input, out result);
        }

        public bool IsValidString(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
    }
}
