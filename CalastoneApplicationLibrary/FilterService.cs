namespace CalastoneApplicationLibrary
{
    /// <inheritdoc/>
    public class FilterService : IFilterService
    {
        /// <inheritdoc/>
        public List<string> FilterMiddleVowels(List<string> input)
        {
            if (input == null)
            {
                return new List<string>();
            }
            var words = input.ToList();
            foreach (var word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                {
                    input.Remove(word);
                    continue;
                }
                if (word.Length % 2 == 0)
                {
                    var first = (word.Length / 2) - 1;
                    var second = (word.Length / 2);
                    var fistChar = word.ElementAt(first);
                    var secondChar = word.ElementAt(second);
                    if (fistChar.IsVowel() || secondChar.IsVowel())
                    {
                        input.Remove(word);
                    }
                }
                else
                {
                    var first = ((word.Length + 1) / 2) - 1;
                    var fistChar = word.ElementAt(first);
                    if (fistChar.IsVowel())
                    {
                        input.Remove(word);
                    }
                }
            }
            return input;
        }
        
        /// <inheritdoc/>
        public List<string> FilterLengthLessThanThree(List<string> input)
        {
            if (input == null)
            {
                return new List<string>();
            }
            var words = input.ToList();
            foreach (var word in words.OrEmptyIfNull())
            {
                if (string.IsNullOrWhiteSpace(word))
                {
                    input.Remove(word);
                    continue;
                }
                if (word.Length < 3)
                {
                    input.Remove(word);
                }
            }
            return input;
        }

        /// <inheritdoc/>
        public List<string> FilterWordsContainingLetterT(List<string> input)
        {
            if (input == null)
            {
                return new List<string>();
            }
            var words = input.ToList();
            foreach (var word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                {
                    input.Remove(word);
                    continue;
                }
                if (word.Contains('T', StringComparison.CurrentCultureIgnoreCase))
                {
                    input.Remove(word);
                }
            }
            return input;
        }
    }
}