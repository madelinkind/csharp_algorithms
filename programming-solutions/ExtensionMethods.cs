namespace ExtensionMethods
{
    public static class StringExtensors
    {
        /// <summary>
        /// Validate that all characters are letters
        /// </summary>
        public static bool IsAllLetters(this string s)
        {
            if (s == string.Empty)
                return false;

            foreach (char c in s)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }
    }
}