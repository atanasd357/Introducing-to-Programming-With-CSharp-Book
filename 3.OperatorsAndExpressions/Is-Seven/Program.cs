using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3

namespace Is_Seven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int thirdDigit = (n / 100) % 10;
            bool isSeven = (thirdDigit == 7);

            Console.WriteLine(isSeven);
        }
    }
}
