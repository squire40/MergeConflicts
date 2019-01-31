using System;

namespace MergeConflicts
{
    public class Validator : IValidator
    {
        public bool IsValidDate(string input)
        {
            DateTime thing;
            try
            {
                thing = DateTime.Parse(input);
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }

        public bool IsValidInt(string input)
        {
            int thing;
            try
            {
                thing = int.Parse(input);
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }

        public bool IsValidString(string input)
        {
            return input != null && input != string.Empty;
        }
    }
}
