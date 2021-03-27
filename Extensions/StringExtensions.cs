using System;
using System.Linq;

namespace Extensions
{
    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
            {
                return str;
            }
            return string.Join(" ", words.Take(numberOfWords));
        }
    }

}
