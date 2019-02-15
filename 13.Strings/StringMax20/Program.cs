using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 7

namespace StringMax20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string with maximum 20 characters: ");
            string input = Console.ReadLine();

            if (input.Length > 20)
            {
                Console.WriteLine("Too large string!");
            }
            else
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
        }
    }
}
