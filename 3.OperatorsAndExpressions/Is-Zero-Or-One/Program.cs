using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Task 4

namespace Is_Zero_Or_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            bool thirdBit = (n & 8) != 0;

            Console.WriteLine(thirdBit);
        }
    }
}
