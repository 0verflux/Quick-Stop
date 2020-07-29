using System;
using System.Text;

namespace QuickStop.Components.Helpers
{
    /// <summary>
    /// Provides Generation of Reference key for <see cref="Domain.Models.HotelBook"/>.
    /// </summary>
    public static class ReferenceGenerator
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        private const char OFFSET = 'A';
        private const int LETTER_OFFSET = 26;

        /// <summary>
        /// Generates a randomized reference key depending on the length.
        /// </summary>
        /// <param name="length">The reference key length.</param>
        /// <returns>A reference key.</returns>
        public static string Generate(int length)
        {
            var builder = new StringBuilder(length + 3);

            builder.Append("QS-");

            for (var i = 0; i < length; i++)
            {
                var ch = (char)NextRandom(OFFSET, OFFSET + LETTER_OFFSET);
                builder.Append(ch);
            }

            return builder.ToString();
        }

        private static int NextRandom(int min, int max)
        {
            lock(syncLock)
            {
                return random.Next(min, max);
            }
        }
    }
}
