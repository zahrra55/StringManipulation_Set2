namespace zahra
{
    class Program
    {
        /*Count the number of characters in a string.*/
        static int CountCharacters(string string1)
        {
            return string1.Length;
        }

        static string ToUpper(string string1) 
        { 
            return string1.ToUpper();
        }

        static string ToLower(string string1) 
        { 
            return string1.ToLower();
        }
        /*Check if a string starts with a given prefix.*/
        static bool StartsWithPrefix(string string1, string prefix)
        {
            return string1.StartsWith(prefix);
        }
        //Check if a string ends with a given suffix.
        static bool EndsWithSuffix(string string1, string suffix)
        {
            return string1.EndsWith(suffix);
        }
        //Check if a string contains only digits
        static bool ContainsOnlyDigits(string string1)
        {
            foreach (char c in string1)
                if (!char.IsDigit(c))
                    return false;
            return true;
        }
        //Check if a string contains only letters
        static bool ContainsOnlyLetters(string string1)
        {
            foreach (char c in string1)
                if (!char.IsLetter(c))
                    return false;
            return true;
        }
        //Capitalize the first character of a string
        static string CapitalizeFirstCharacter(string string1)
        {
            return char.ToUpper(string1[0]) + string1.Substring(1);
        }
        //Swap the case of each character in a string
        static string SwapCase(string string1)
        {
            // we create a new char array to hold the swapped characters
            char[] swapped = new char[string1.Length];

            // if upper turn to lower and vice versa
            for (int i = 0; i < string1.Length; i++)
            {
                if (char.IsUpper(string1[i]))
                    swapped[i] = char.ToLower(string1[i]);
                else
                    swapped[i] = char.ToUpper(string1[i]);
            }
            // here we return the new string with the swapped cases
            return new string(swapped);
        }

        // Split a string into words  Input: 'hello world' -> Output: ['hello', 'world']
        static string[] SplitIntoWords(string string1)
        {
            return string1.Split(' ');
        }

        // Remove leading and trailing whitespace from a string
        static string TrimWhitespace(string string1)
        {
            return string1.Trim();
        }

        // Count the number of spaces in a string
        static int CountSpaces(string string1)
        {
            int count = 0;
            foreach (char c in string1)
            {
                if (c == ' ')
                    count++;
            }
            return count;
        }

        // Get the first 5 characters of a string
        static string GetFirstFiveCharacters(string string1)
        {
            if (string1.Length < 5)
                // if it's less than 5 characters Return it
                return string1;
            // else return the first 5 chars
            return string1.Substring(0, 5);
        }

        // Get the last 3 characters of a string
        static string GetLastThreeCharacters(string string1)
        {
            if (string1.Length < 3)
                // if it's less than 3 characters return it
                return string1;
            // else return the last 3 chars
            return string1.Substring(string1.Length - 3);
        }
        static void Main(string[] args)
        {
            Console.Write("Hello, World!\nEnter your string...");
            string UserString = Console.ReadLine();
            if (UserString == null)
            {
                Console.WriteLine("Bruh, you need to write something...");
                return;
            }

            // print an array of words FROM string[] SplitIntoWords(string string1) sunction
            string[] words = SplitIntoWords(UserString);
            Console.WriteLine("Words in the string:");
            Console.Write("[");
            foreach (string word in words)
            {
                Console.Write($"'{word}' ");
            }
            Console.Write("]\n");
 
        }
    }
}