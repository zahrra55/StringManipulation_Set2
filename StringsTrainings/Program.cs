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

            //calling CapitalizeFirstLetter method and print the result
            Console.WriteLine(Solutions.CapitalizeFirstLetter("  "));

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
            
        }
    }
}
