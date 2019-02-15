using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace Decimal_Numbers_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 151;
            int num2 = 35;
            int num3 = 43;
            int num4 = 251;
            double num5 = -0.41;

            Console.WriteLine(num1 + " to binary = {0}", ToBinary(num1));
            Console.WriteLine(num2 + " to binary = {0}", ToBinary(num2));
            Console.WriteLine(num3 + " to binary = {0}", ToBinary(num3));
            Console.WriteLine(num4 + " to binary = {0}", ToBinary(num4));
            
            long num5ToLong = DoubleToLongBits(num5);
            Console.WriteLine(num5 + " to binary = {0}", ToBinary(num5ToLong));
        }

        private static string ToBinary(long num)
        {         
            long resultAnswer = 0;
            string resultNum = "";
            bool isNegative = false;

            if (num < 0)
            {
                isNegative = true;
                num *= -1;
            }

            while (num > 0)
            {
                resultAnswer = num % 2;
                resultNum = resultAnswer + resultNum;
                num /= 2;
            }

            if(isNegative)
            {
                return 1 + resultNum;
            }
            else
            {
                return resultNum;
            }
        }

        public static long DoubleToLongBits(double num)
        {
            return BitConverter.DoubleToInt64Bits(num);     
        }
    }
}
