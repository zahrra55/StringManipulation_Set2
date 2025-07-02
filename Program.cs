// See https://aka.ms/new-console-template for more information
using strings;

Console.Write("Input string to Process: ");
string input = Console.ReadLine();
Console.WriteLine($"Lowercase: {StringHelper.ToLowerCase(input)}");