using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace Show_Negative_Or_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter num 2: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter num 3: ");
            double num3 = double.Parse(Console.ReadLine());

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("0");
            }
            else if ((num1 < 0 && num2 > 0 && num3 > 0) ||
                (num1 > 0 && num2 < 0 && num3 > 0) ||
                (num1 > 0 && num2 > 0 && num3 < 0))
            {
                Console.WriteLine("-");
            }
            else if ((num1 < 0 && num2 > 0 && num3 < 0) ||
                    (num1 < 0 && num2 < 0 && num3 < 0))
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
