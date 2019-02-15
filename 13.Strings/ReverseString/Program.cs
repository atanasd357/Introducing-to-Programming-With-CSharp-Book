using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string: ");
            string enterStr = Console.ReadLine();

            string reversedStr = ReverseStr(enterStr);
            Console.WriteLine("\nThe reversed string is: {0}\n", reversedStr);
        }

        static string ReverseStr(string enterStr)
        {
            StringBuilder buildStr = new StringBuilder();

            for (int i = enterStr.Length-1; i >= 0; i--)
            {
                buildStr.Append(enterStr[i]);
            }

            return buildStr.ToString();
        }
    }
}
