namespace CalastoneApplicationLibrary
{
    /// <summary>
    /// A static class of extension methods to be reused and avoid repeated code.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Extension method for <see cref="char"/> to see if it is a vowel.
        /// </summary>
        /// <param name="c">The <see cref="char"/>being checked.</param>
        /// <returns>True if it is a vowel, otherwise false.</returns>
        public static bool IsVowel(this char c)
        {
            return "aeiou".IndexOf(c.ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0;
        }

        /// <summary>
        /// Checks if a list is null, and returns a new empty list of that type if it is.
        /// </summary>
        /// <typeparam name="T">The type of list.</typeparam>
        /// <param name="list">The collection to be checked for null.</param>
        /// <returns>Either the original collection or a new empty collection of the same type
        /// if it is null.</returns>
        public static List<T> OrEmptyIfNull<T>(this List<T> list)
        {
            if (list == null) return new List<T>();
            return list;
        }

        /// <summary>
        /// Checks if a list is null or empty.
        /// </summary>
        /// <typeparam name="T">The type of list.</typeparam>
        /// <param name="list">The collection to be checked for null or empty.</param>
        /// <returns>False if the collection is null or empty, otherwise true.</returns>
        public static bool IsNotNullOrEmpty<T>(this List<T> list)
        {
            if (list == null) return false;
            if (list.Count == 0) return false;
            return true;
        }
    }
}
