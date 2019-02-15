using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3

namespace Accurate_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first num: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second num: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal product = num1 * num2;

            Console.WriteLine(product);
        }
    }
}
