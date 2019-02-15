using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 17

namespace Greatest_Common_Divisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            while (num1 != 0 && num2 != 0)
            {
                if (num1 > num2)
                {
                    num1 %= num2;
                }
                else
                {
                    num2 %= num1;
                }
            }

            if (num1 == 0)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num1);
            }    
        }
    }
}
