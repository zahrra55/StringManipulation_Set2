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
        }
    }
}
