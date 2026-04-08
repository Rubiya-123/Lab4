using System;

namespace StringExtensionsLib
{
    public static class StringExtensions
    {
        public static bool StartsWithUpperCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return char.IsUpper(input[0]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello";
            Console.WriteLine(test.StartsWithUpperCase()); // true
        }
    }
}