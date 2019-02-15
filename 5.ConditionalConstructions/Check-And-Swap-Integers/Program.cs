using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace Check_And_Swap_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int num3;

            if (num1 > num2)
            {
                num3 = num1;
                num1 = num2;
                num2 = num3;
                Console.WriteLine(num1 + " " + num2);
            }
            else
            {
                Console.WriteLine(num1 + " " + num2);
            }
        }
    }
}
