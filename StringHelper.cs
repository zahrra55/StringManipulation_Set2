using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    public static class StringHelper
    {
        public static string Reverse(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ToUpperCase(string input)
        {
            // Returns the input string in uppercase.
            input = SafteyCheckUsingLoop(input);
            try
            {
                input = input.ToUpperInvariant();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
            }
            return input;
        }

        private static string SafteyCheckUsingLoop(string input)
        {
            while (input == string.Empty)
            {
                Console.Write("Re Input string: ");
                input = Console.ReadLine();
            }

            return input;
        }

        public static string ToLowerCase(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return input.ToLowerInvariant();
        }
        public static string Capitalize(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (input.Length == 0) return input;
            return char.ToUpper(input[0]) + input.Substring(1).ToLowerInvariant();
        }
        public static string TrimWhitespace(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return input.Trim();
        }
        public static string ReplaceWhitespaceWithUnderscore(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return input.Replace(" ", "_");
        }
        public static int Length(string input)
        {
            // Returns the length of the string.
            int count = 0;
            input = SafteyCheckUsingLoop(input);
            try
            {
                count = input.Length;
            }
            catch (Exception)
            {

                Console.WriteLine("An error occurred while calculating the length of the string. Please try again.");
            }
            Console.WriteLine($"The length of the string is: {count}");
            return count;
        }
    }
}
