
namespace CalastoneApplicationLibrary
{
    /// <summary>
    /// Service for filtering out words from a list of string depending on certain criteria.
    /// </summary>
    public interface IFilterService
    {
        /// <summary>
        /// // Filter out all the words that contains a vowel in the middle of the word – the centre 1 or 2 letters
        /// ("clean" middle is ‘e’, "what" middle is ‘ha’, "currently" middle is ‘e’ and should be filtered, "the", "rather" 
        /// should not be)
        /// </summary>
        /// <param name="input">The inputted list of strings being filtered.</param>
        /// <returns>The new filtered list, with all words with a middle letter vowel removed.</returns>
        List<string> FilterMiddleVowels(List<string> input);

        /// <summary>
        /// Filter out words that have length less than 3.
        /// </summary>
        /// <param name="input">The inputted list of strings being filtered.</param>
        /// <returns>The new filtered list, with all words of length less than 3 removed.</returns>
        List<string> FilterLengthLessThanThree(List<string> input);

        /// <summary>
        /// Filter out words that contains the letter ‘t’
        /// </summary>
        /// <param name="input">The inputted list of strings being filtered.</param>
        /// <returns>The new filtered list, with all words containing the letter 'T' removed.</returns>
        public List<string> FilterWordsContainingLetterT(List<string> input);
    }
}