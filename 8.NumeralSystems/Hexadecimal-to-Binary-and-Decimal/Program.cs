using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3

namespace Hexadecimal_to_Binary_and_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "2A3E";
            string num2 = "FA";
            string num3 = "FFFF";
            string num4 = "5A0E9";

            Console.WriteLine(num1 + " to decimal = {0}", ToDecimal(num1));
            Console.WriteLine(num2 + " to decimal = {0}", ToDecimal(num2));
            Console.WriteLine(num3 + " to decimal = {0}", ToDecimal(num3));
            Console.WriteLine(num4 + " to decimal = {0}", ToDecimal(num4));

            Console.WriteLine();

            Console.WriteLine(num1 + " to binary = {0}", ToBinary(ToDecimal(num1)));
            Console.WriteLine(num2 + " to binary = {0}", ToBinary(ToDecimal(num2)));
            Console.WriteLine(num3 + " to binary = {0}", ToBinary(ToDecimal(num3)));
            Console.WriteLine(num4 + " to binary = {0}", ToBinary(ToDecimal(num4)));
        }

        private static double ToDecimal(string number)
        {
            double resultDecNum = 0;
            int count = number.Length;
            foreach (char num in number)
            {
                count--;
                if (num == 'A' || num == 'B' || num == 'C' || num == 'D' ||
                    num == 'E' || num == 'F')
                {
                    switch (num)
                    {
                        case 'A': resultDecNum += 10 * (Math.Pow(16, count)); break;
                        case 'B': resultDecNum += 11 * (Math.Pow(16, count)); break;
                        case 'C': resultDecNum += 12 * (Math.Pow(16, count)); break;
                        case 'D': resultDecNum += 13 * (Math.Pow(16, count)); break;
                        case 'E': resultDecNum += 14 * (Math.Pow(16, count)); break;
                        case 'F': resultDecNum += 15 * (Math.Pow(16, count)); break;
                    }
                }
                else
                {
                    resultDecNum += ((int)num - 48) * (Math.Pow(16, count));
                }
            }

            return resultDecNum;
        }

        private static string ToBinary(double num)
        {
            int decNum = (int)num;
            int resultAnswer = 0;
            string resultNumBinary = "";

            while (decNum > 0)
            {
                resultAnswer = decNum % 2;
                resultNumBinary = resultAnswer + resultNumBinary;
                decNum /= 2;
            }

            return resultNumBinary;
        }
    }
}
