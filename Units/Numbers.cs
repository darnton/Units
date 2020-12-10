namespace Darnton.Units
{
    /// <summary>
    /// The Numbers class contains utility methods for manipulating numbers
    /// to make code easier to read.
    /// </summary>
    public static class Numbers
    {
        /// <summary>
        /// Multiplies a number by a million.
        /// </summary>
        /// <param name="number">The base number.</param>
        /// <returns>The base number multiplied by a million.</returns>
        public static long Million(this int number) => number * 1000000;
        /// <summary>
        /// Multiplies a number by a million.
        /// </summary>
        /// <param name="number">The base number.</param>
        /// <returns>The base number multiplied by a million.</returns>
        public static long Million(this long number) => number * 1000000;
    }
}
