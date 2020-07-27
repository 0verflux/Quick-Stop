using System;
using System.Text;

namespace QuickStop.Components.Helpers
{
    public static class ReferenceGenerator
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        private const char OFFSET = 'A';
        private const int LETTER_OFFSET = 26;

        public static string Generate(int size)
        {
            var builder = new StringBuilder(size + 3);

            builder.Append("QS-");

            for (var i = 0; i < size; i++)
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
