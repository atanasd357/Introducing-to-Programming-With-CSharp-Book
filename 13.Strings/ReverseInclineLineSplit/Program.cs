using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4

namespace ReverseInclineLineSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter words separated by \"\\\": ");
            string words = Console.ReadLine();

            string[] separatedWords = words.Split('\\');

            Console.WriteLine("\nThe separated words are: ");
            for (int i = 0; i < separatedWords.Length; i++)
            {
                Console.WriteLine(separatedWords[i]);
            }
            Console.WriteLine();
        }
    }
}
