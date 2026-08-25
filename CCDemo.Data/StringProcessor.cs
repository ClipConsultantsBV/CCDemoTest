namespace CCDemo.Data
{
    /// <summary>
    /// String manipulatie en analyse.
    /// </summary>
    public class StringProcessor
    {
        public string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException(nameof(input));

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            const string vowels = "aeiouAEIOU";
            return input.Count(vowels.Contains);
        }

        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            string cleaned = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            return cleaned == Reverse(cleaned);
        }

        public string CapitalizeWords(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words.Select(w => char.ToUpper(w[0]) + w[1..]));
        }

        public int CountWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            return input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
