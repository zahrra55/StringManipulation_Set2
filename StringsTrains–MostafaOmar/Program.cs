using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StringsTrains_MostafaOmar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = SolutionOfStringTrains.NumberOfCharacterInString("HI");
            Console.WriteLine($"number of characters in : '{count}'");
        }
    }
    public class SolutionOfStringTrains
    {
        //Exercise 1  :
        //Count the number of characters in a string.

        //Sol
        // i will use method length to count the number of string

        public static int NumberOfCharacterInString(string str) // string will take the name or whatever it is
        {
            int NumberOfCharInString = str.Length; // initialze variable to store length in it
            return NumberOfCharInString;
        }
    }
}
