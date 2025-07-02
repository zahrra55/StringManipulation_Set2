using System;

namespace StringsTrainings
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling WordApearingCounts method and print the count
            Console.WriteLine(Solutions.WordApearingCounts("apple"));

            //calling ConvertToUpperCase method and print the result
            Console.WriteLine(Solutions.ConvertToUpperCase("moosa"));

            //calling ConvertToLowerCase method and print the result
            Console.WriteLine(Solutions.ConvertToLowerCase("MOOSA"));

            //calling IsStartsWith method and print the result
            Console.WriteLine(Solutions.IsStartsWith("wel"));

            //calling IsStartsWith method and print the result
            Console.WriteLine(Solutions.IsEndsWith("txt"));

            //calling IsContainOnlyDigits method and print the result
            Console.WriteLine(Solutions.IsContainOnlyDigits("12345"));

            //calling IsContainOnlyLetters method and print the result
            Console.WriteLine(Solutions.IsContainOnlyLetters("abcd"));

            //calling CapitalizeFirstLetter method and print the result
            Console.WriteLine(Solutions.CapitalizeFirstLetter("moosa"));

            //calling ChangeLetterCase method
            Solutions.ChangeLetterCase("MoOsA");

            //calling SplitString method
            Solutions.SplitString("apple banana apple orange apple");

            //calling JoinString method
            string[] text = { "C#", "Java", "C++" };
            Solutions.JoinString(text);

            //calling RemoveWhiteSpaces method and print the result
            Console.WriteLine(Solutions.RemoveWhiteSpaces(" Hello world "));

            //calling NumberOfSpaces method and print the result
            Console.WriteLine(Solutions.NumberOfSpaces("Hello World"));

            //calling GetFirst5Char method and print the result
            Console.WriteLine(Solutions.GetFirst5Char("Hello world!"));

            //calling GetLast3Char method and print the result
            Console.WriteLine(Solutions.GetLast3Char("Hello world!"));

            //calling ReplaceCommasWithSemicolons method and print the result
            Console.WriteLine(Solutions.ReplaceCommasWithSemicolons("1,2,3,4"));

            //calling AreAnagrams method and print the result
            Console.WriteLine(Solutions.AreAnagrams("listen","silent"));


        }
    }
}
