using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace StringToUnicodeSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some string: ");
            string input = Console.ReadLine();

            Console.WriteLine("\nUnicode sequence of {0}:", input);

            foreach (char symbol in input)
            {
                int unicodeNum = symbol;
                Console.Write("\\u{0:x4}", unicodeNum);
            }
            Console.WriteLine("\n");
        }
    }
}
