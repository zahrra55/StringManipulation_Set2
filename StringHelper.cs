using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    public static class StringHelper
    {
        public static bool CheckPrefex(string input,string prefex)
        {
            input = SafteyCheckUsingLoop(input);
            prefex = SafteyCheckUsingLoop(prefex);
            try
            {
                return input.StartsWith(prefex);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
                return false;
            }

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
        public static string ToLowerCase(string input)
        {
            // Returns the input string in lowecase.
            input = SafteyCheckUsingLoop(input);
            try
            {
                input = input.ToLowerInvariant();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while process the input string({ex.Message}). Please try again.");
            }
            return input;
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
        private static string SafteyCheckUsingLoop(string input)
        {
            while (input == string.Empty)
            {
                Console.Write("Re Input string: ");
                input = Console.ReadLine();
            }

            return input;
        }


    }
}
