using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    public class helper
    {

        public static int CountCharsOfinputString(string _string)
        {
            //simple method return length of input string using Length Method
            try
            {
                while (_string == string.Empty)
                {
                    Console.Write("RE input string in Valid Format: ");
                }
                return _string.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is Error in Input string maybe null or invalid format");
            }
            return 0;
        }
    }
}
