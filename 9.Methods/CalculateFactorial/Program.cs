using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Task 10

namespace CalculateBigFactorial
{
    class BigFactorialCalculate
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for calculate: ");
            int num = int.Parse(Console.ReadLine());

            BigInteger result = CalculateFactorial(num);

            Console.WriteLine("{0}! = {1}", num, result);        
        }

        static BigInteger CalculateFactorial(int num)
        {
            BigInteger result = 1;

            while (num > 0)
            {
                result *= num;
                num -= 1;
            }

            return result;
        }
    }
}
